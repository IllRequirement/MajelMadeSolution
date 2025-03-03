using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace majelmade.data.Migrations
{
    /// <inheritdoc />
    public partial class TypeSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AddressTypes",
                columns: new[] { "AddressTypeID", "TypeName" },
                values: new object[,]
                {
                    { 1, "Home" },
                    { 2, "Work" },
                    { 3, "Billing" },
                    { 4, "Shipping" },
                    { 5, "Other" }
                });

            migrationBuilder.InsertData(
                table: "EmailType",
                columns: new[] { "EmailTypeID", "TypeName" },
                values: new object[,]
                {
                    { 1, "Personal" },
                    { 2, "Work" },
                    { 3, "School" },
                    { 4, "Other" },
                    { 5, "Family" }
                });

            migrationBuilder.InsertData(
                table: "EmployeePositions",
                columns: new[] { "EmployeePositionID", "PositionName" },
                values: new object[,]
                {
                    { 1, "Cook" },
                    { 2, "Server" },
                    { 3, "Manager" },
                    { 4, "Chef" },
                    { 5, "Delivery" }
                });

            migrationBuilder.InsertData(
                table: "EquipmentLogTypes",
                columns: new[] { "EquipmentLogTypeID", "LogTypeName" },
                values: new object[,]
                {
                    { 1, "Maintenance" },
                    { 2, "Repair" },
                    { 3, "Inspection" },
                    { 4, "Calibration" },
                    { 5, "Upgrade" }
                });

            migrationBuilder.InsertData(
                table: "EquipmentStatuses",
                columns: new[] { "EquipmentStatusID", "StatusName" },
                values: new object[,]
                {
                    { 1, "In Service" },
                    { 2, "Under Repair" },
                    { 3, "Out of Service" },
                    { 4, "Maintenance Required" },
                    { 5, "Retired" }
                });

            migrationBuilder.InsertData(
                table: "InventoryCategories",
                columns: new[] { "InventoryCategoryID", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Meat", "Animal meat products" },
                    { 2, "Dairy", "Milk, cheese, and related products" },
                    { 3, "Vegetable", "Fresh vegetables" },
                    { 4, "Grain", "Cereals and grain products" },
                    { 5, "Fruit", "Fresh fruit" }
                });

            migrationBuilder.InsertData(
                table: "InventoryTransactionTypes",
                columns: new[] { "InventoryTransactionTypeID", "TransactionTypeName" },
                values: new object[,]
                {
                    { 1, "Add" },
                    { 2, "Subtract" },
                    { 3, "Adjustment" },
                    { 4, "Transfer" },
                    { 5, "Return" }
                });

            migrationBuilder.InsertData(
                table: "MeasurementUnits",
                columns: new[] { "MeasurementUnitID", "UnitName" },
                values: new object[,]
                {
                    { 1, "lb" },
                    { 2, "each" },
                    { 3, "kg" },
                    { 4, "liters" },
                    { 5, "gallon" }
                });

            migrationBuilder.InsertData(
                table: "ModificationTypes",
                columns: new[] { "ModificationTypeID", "ModificationName" },
                values: new object[,]
                {
                    { 1, "Extra Sauce" },
                    { 2, "No Salt" },
                    { 3, "Gluten-Free" },
                    { 4, "Extra Cheese" },
                    { 5, "Spicy" }
                });

            migrationBuilder.InsertData(
                table: "OrderTypes",
                columns: new[] { "OrderTypeID", "TypeName" },
                values: new object[,]
                {
                    { 1, "Dine-In" },
                    { 2, "Pickup" },
                    { 3, "Delivery" },
                    { 4, "Catering" },
                    { 5, "Online" }
                });

            migrationBuilder.InsertData(
                table: "PhoneTypes",
                columns: new[] { "PhoneTypeID", "TypeName" },
                values: new object[,]
                {
                    { 1, "Home" },
                    { 2, "Mobile" },
                    { 3, "Work" },
                    { 4, "Fax" },
                    { 5, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "RoleName" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Manager" },
                    { 3, "Employee" },
                    { 4, "Supervisor" },
                    { 5, "Guest" }
                });

            migrationBuilder.InsertData(
                table: "ShippingMethodTypes",
                columns: new[] { "ShippingMethodTypeID", "MethodName" },
                values: new object[,]
                {
                    { 1, "Air" },
                    { 2, "Ground" },
                    { 3, "Express" },
                    { 4, "Standard" },
                    { 5, "Overnight" }
                });

            migrationBuilder.InsertData(
                table: "StatusTypes",
                columns: new[] { "StatusTypeID", "StatusName" },
                values: new object[,]
                {
                    { 1, "Pending" },
                    { 2, "Processing" },
                    { 3, "Shipped" },
                    { 4, "Delivered" },
                    { 5, "Cancelled" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddressTypes",
                keyColumn: "AddressTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AddressTypes",
                keyColumn: "AddressTypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AddressTypes",
                keyColumn: "AddressTypeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AddressTypes",
                keyColumn: "AddressTypeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AddressTypes",
                keyColumn: "AddressTypeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EmailType",
                keyColumn: "EmailTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmailType",
                keyColumn: "EmailTypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmailType",
                keyColumn: "EmailTypeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmailType",
                keyColumn: "EmailTypeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EmailType",
                keyColumn: "EmailTypeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumn: "EmployeePositionID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumn: "EmployeePositionID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumn: "EmployeePositionID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumn: "EmployeePositionID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumn: "EmployeePositionID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EquipmentLogTypes",
                keyColumn: "EquipmentLogTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EquipmentLogTypes",
                keyColumn: "EquipmentLogTypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EquipmentLogTypes",
                keyColumn: "EquipmentLogTypeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EquipmentLogTypes",
                keyColumn: "EquipmentLogTypeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EquipmentLogTypes",
                keyColumn: "EquipmentLogTypeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EquipmentStatuses",
                keyColumn: "EquipmentStatusID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EquipmentStatuses",
                keyColumn: "EquipmentStatusID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EquipmentStatuses",
                keyColumn: "EquipmentStatusID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EquipmentStatuses",
                keyColumn: "EquipmentStatusID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EquipmentStatuses",
                keyColumn: "EquipmentStatusID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "InventoryCategories",
                keyColumn: "InventoryCategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InventoryCategories",
                keyColumn: "InventoryCategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InventoryCategories",
                keyColumn: "InventoryCategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InventoryCategories",
                keyColumn: "InventoryCategoryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InventoryCategories",
                keyColumn: "InventoryCategoryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "InventoryTransactionTypes",
                keyColumn: "InventoryTransactionTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InventoryTransactionTypes",
                keyColumn: "InventoryTransactionTypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InventoryTransactionTypes",
                keyColumn: "InventoryTransactionTypeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InventoryTransactionTypes",
                keyColumn: "InventoryTransactionTypeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InventoryTransactionTypes",
                keyColumn: "InventoryTransactionTypeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MeasurementUnits",
                keyColumn: "MeasurementUnitID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MeasurementUnits",
                keyColumn: "MeasurementUnitID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MeasurementUnits",
                keyColumn: "MeasurementUnitID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MeasurementUnits",
                keyColumn: "MeasurementUnitID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MeasurementUnits",
                keyColumn: "MeasurementUnitID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ModificationTypes",
                keyColumn: "ModificationTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ModificationTypes",
                keyColumn: "ModificationTypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ModificationTypes",
                keyColumn: "ModificationTypeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ModificationTypes",
                keyColumn: "ModificationTypeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ModificationTypes",
                keyColumn: "ModificationTypeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "OrderTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "OrderTypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "OrderTypeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "OrderTypeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "OrderTypeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PhoneTypes",
                keyColumn: "PhoneTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PhoneTypes",
                keyColumn: "PhoneTypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PhoneTypes",
                keyColumn: "PhoneTypeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PhoneTypes",
                keyColumn: "PhoneTypeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PhoneTypes",
                keyColumn: "PhoneTypeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ShippingMethodTypes",
                keyColumn: "ShippingMethodTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShippingMethodTypes",
                keyColumn: "ShippingMethodTypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ShippingMethodTypes",
                keyColumn: "ShippingMethodTypeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ShippingMethodTypes",
                keyColumn: "ShippingMethodTypeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ShippingMethodTypes",
                keyColumn: "ShippingMethodTypeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StatusTypes",
                keyColumn: "StatusTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StatusTypes",
                keyColumn: "StatusTypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StatusTypes",
                keyColumn: "StatusTypeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StatusTypes",
                keyColumn: "StatusTypeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StatusTypes",
                keyColumn: "StatusTypeID",
                keyValue: 5);
        }
    }
}
