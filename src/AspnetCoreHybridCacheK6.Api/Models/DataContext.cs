using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace AspnetCoreHybridCacheK6.Api.Models;

// Order entity
[Table("Orders", Schema = "Sales")]
public class Order
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int OrderID { get; set; }

    [Required]
    public int CustomerID { get; set; }

    [Required]
    public int SalespersonPersonID { get; set; }

    public int? PickedByPersonID { get; set; }

    [Required]
    public int ContactPersonID { get; set; }

    public int? BackorderOrderID { get; set; }

    [Required]
    public DateTime OrderDate { get; set; }

    public DateTime? ExpectedDeliveryDate { get; set; }

    [MaxLength(50)]
    public string CustomerPurchaseOrderNumber { get; set; }

    [Required]
    public bool IsUndersupplyBackordered { get; set; }

    public string Comments { get; set; }

    public string DeliveryInstructions { get; set; }

    public string InternalComments { get; set; }

    public DateTime? PickingCompletedWhen { get; set; }

    [Required]
    public int LastEditedBy { get; set; }

    [Required]
    public DateTime LastEditedWhen { get; set; }

    // Navigation properties
    public ICollection<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
}

// OrderLine entity
[Table("OrderLines", Schema = "Sales")]
public class OrderLine
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int OrderLineID { get; set; }

    [Required]
    public int OrderID { get; set; }

    [Required]
    public int StockItemID { get; set; }

    [MaxLength(200)]
    public string Description { get; set; }

    [Required]
    public int PackageTypeID { get; set; }

    [Required]
    public int Quantity { get; set; }

    [Required]
    public decimal UnitPrice { get; set; }

    [Required]
    public decimal TaxRate { get; set; }

    public int? PickedQuantity { get; set; }

    public DateTime? PickingCompletedWhen { get; set; }

    [Required]
    public int LastEditedBy { get; set; }

    [Required]
    public DateTime LastEditedWhen { get; set; }

    [ForeignKey("OrderID"), JsonIgnore]
    public Order Order { get; set; }
}

// DbContext
public class WideWorldImportersContext(DbContextOptions<WideWorldImportersContext> options) : DbContext(options)
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderLine> OrderLines { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuring relationships
        modelBuilder.Entity<Order>()
            .HasMany(o => o.OrderLines)
            .WithOne(ol => ol.Order)
            .HasForeignKey(ol => ol.OrderID);
    }
}