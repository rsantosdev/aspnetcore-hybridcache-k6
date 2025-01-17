using AspnetCoreHybridCacheK6.Api.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Hybrid;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<WideWorldImportersContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

#pragma warning disable EXTEXP0018
builder.Services.AddHybridCache(options =>
{
    options.DefaultEntryOptions = new HybridCacheEntryOptions
    {
        Expiration = TimeSpan.FromMinutes(10),
        LocalCacheExpiration = TimeSpan.FromMinutes(10)
    };
});
#pragma warning restore EXTEXP0018

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/orders/{id}", async (int id, WideWorldImportersContext dbContext) =>
{
    var order = await dbContext.Orders
        .Include(x => x.OrderLines)
        .AsNoTrackingWithIdentityResolution()
        .FirstOrDefaultAsync(x => x.OrderID == id);

    return order;
});

app.MapGet("/orders/{id}/dapper", async (int id, IConfiguration configuration) =>
{
    await using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
    var sql = @"
                    SELECT 
                        o.OrderID, o.CustomerID, o.SalespersonPersonID, o.PickedByPersonID, 
                        o.ContactPersonID, o.BackorderOrderID, o.OrderDate, o.ExpectedDeliveryDate, 
                        o.CustomerPurchaseOrderNumber, o.IsUndersupplyBackordered, o.Comments, 
                        o.DeliveryInstructions, o.InternalComments, o.PickingCompletedWhen, 
                        o.LastEditedBy, o.LastEditedWhen,
                        ol.OrderLineID, ol.OrderID, ol.StockItemID, ol.Description, 
                        ol.PackageTypeID, ol.Quantity, ol.UnitPrice, ol.TaxRate, 
                        ol.PickedQuantity, ol.PickingCompletedWhen, ol.LastEditedBy, 
                        ol.LastEditedWhen
                    FROM Sales.Orders o
                    LEFT JOIN Sales.OrderLines ol ON o.OrderID = ol.OrderID
                    WHERE o.OrderID = @OrderId";

    var orderDictionary = new Dictionary<int, Order>();

    var result = connection.Query<Order, OrderLine, Order>(
        sql,
        (order, orderLine) =>
        {
            if (!orderDictionary.TryGetValue(order.OrderID, out var currentOrder))
            {
                currentOrder = order;
                orderDictionary.Add(order.OrderID, currentOrder);
            }

            if (orderLine != null)
            {
                currentOrder.OrderLines.Add(orderLine);
            }

            return currentOrder;
        },
        new { OrderId = id },
        splitOn: "OrderLineID"
    );

    return result.FirstOrDefault();

});

app.MapGet("/orders/{id}/cache", async (int id, WideWorldImportersContext dbContext, HybridCache cache) =>
{
    var orderResponse = await cache.GetOrCreateAsync($"order-{id}",
        async token =>
        {
            var order = await dbContext.Orders
                .Include(x => x.OrderLines)
                .AsNoTrackingWithIdentityResolution()
                .FirstOrDefaultAsync(x => x.OrderID == id);
            return order;
        });
    
    if (orderResponse == null)
    {
        return null;
    }

    return orderResponse;
});

app.Run();