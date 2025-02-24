﻿// <auto-generated />
using System;
using System.Reflection;
using AspnetCoreHybridCacheK6.Api.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable disable

namespace AspnetCoreHybridCacheK6.Api
{
    [EntityFrameworkInternal]
    public partial class OrderEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "AspnetCoreHybridCacheK6.Api.Models.Order",
                typeof(Order),
                baseEntityType,
                propertyCount: 16,
                navigationCount: 1,
                keyCount: 1);

            var orderID = runtimeEntityType.AddProperty(
                "OrderID",
                typeof(int),
                propertyInfo: typeof(Order).GetProperty("OrderID", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Order).GetField("<OrderID>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            orderID.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var backorderOrderID = runtimeEntityType.AddProperty(
                "BackorderOrderID",
                typeof(int?),
                propertyInfo: typeof(Order).GetProperty("BackorderOrderID", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Order).GetField("<BackorderOrderID>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            backorderOrderID.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var comments = runtimeEntityType.AddProperty(
                "Comments",
                typeof(string),
                propertyInfo: typeof(Order).GetProperty("Comments", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Order).GetField("<Comments>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            comments.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var contactPersonID = runtimeEntityType.AddProperty(
                "ContactPersonID",
                typeof(int),
                propertyInfo: typeof(Order).GetProperty("ContactPersonID", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Order).GetField("<ContactPersonID>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            contactPersonID.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var customerID = runtimeEntityType.AddProperty(
                "CustomerID",
                typeof(int),
                propertyInfo: typeof(Order).GetProperty("CustomerID", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Order).GetField("<CustomerID>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            customerID.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var customerPurchaseOrderNumber = runtimeEntityType.AddProperty(
                "CustomerPurchaseOrderNumber",
                typeof(string),
                propertyInfo: typeof(Order).GetProperty("CustomerPurchaseOrderNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Order).GetField("<CustomerPurchaseOrderNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            customerPurchaseOrderNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var deliveryInstructions = runtimeEntityType.AddProperty(
                "DeliveryInstructions",
                typeof(string),
                propertyInfo: typeof(Order).GetProperty("DeliveryInstructions", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Order).GetField("<DeliveryInstructions>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            deliveryInstructions.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var expectedDeliveryDate = runtimeEntityType.AddProperty(
                "ExpectedDeliveryDate",
                typeof(DateTime?),
                propertyInfo: typeof(Order).GetProperty("ExpectedDeliveryDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Order).GetField("<ExpectedDeliveryDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            expectedDeliveryDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var internalComments = runtimeEntityType.AddProperty(
                "InternalComments",
                typeof(string),
                propertyInfo: typeof(Order).GetProperty("InternalComments", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Order).GetField("<InternalComments>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            internalComments.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isUndersupplyBackordered = runtimeEntityType.AddProperty(
                "IsUndersupplyBackordered",
                typeof(bool),
                propertyInfo: typeof(Order).GetProperty("IsUndersupplyBackordered", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Order).GetField("<IsUndersupplyBackordered>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            isUndersupplyBackordered.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var lastEditedBy = runtimeEntityType.AddProperty(
                "LastEditedBy",
                typeof(int),
                propertyInfo: typeof(Order).GetProperty("LastEditedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Order).GetField("<LastEditedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            lastEditedBy.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var lastEditedWhen = runtimeEntityType.AddProperty(
                "LastEditedWhen",
                typeof(DateTime),
                propertyInfo: typeof(Order).GetProperty("LastEditedWhen", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Order).GetField("<LastEditedWhen>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            lastEditedWhen.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var orderDate = runtimeEntityType.AddProperty(
                "OrderDate",
                typeof(DateTime),
                propertyInfo: typeof(Order).GetProperty("OrderDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Order).GetField("<OrderDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            orderDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var pickedByPersonID = runtimeEntityType.AddProperty(
                "PickedByPersonID",
                typeof(int?),
                propertyInfo: typeof(Order).GetProperty("PickedByPersonID", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Order).GetField("<PickedByPersonID>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            pickedByPersonID.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var pickingCompletedWhen = runtimeEntityType.AddProperty(
                "PickingCompletedWhen",
                typeof(DateTime?),
                propertyInfo: typeof(Order).GetProperty("PickingCompletedWhen", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Order).GetField("<PickingCompletedWhen>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            pickingCompletedWhen.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var salespersonPersonID = runtimeEntityType.AddProperty(
                "SalespersonPersonID",
                typeof(int),
                propertyInfo: typeof(Order).GetProperty("SalespersonPersonID", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Order).GetField("<SalespersonPersonID>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            salespersonPersonID.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { orderID });
            runtimeEntityType.SetPrimaryKey(key);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", "Sales");
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "Orders");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
