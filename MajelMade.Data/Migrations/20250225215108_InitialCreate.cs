using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace majelmade.data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressTypes",
                columns: table => new
                {
                    AddressTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressTypes", x => x.AddressTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "EmailType",
                columns: table => new
                {
                    EmailTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailType", x => x.EmailTypeID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePositions",
                columns: table => new
                {
                    EmployeePositionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePositions", x => x.EmployeePositionID);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentLogTypes",
                columns: table => new
                {
                    EquipmentLogTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentLogTypes", x => x.EquipmentLogTypeID);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentStatuses",
                columns: table => new
                {
                    EquipmentStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentStatuses", x => x.EquipmentStatusID);
                });

            migrationBuilder.CreateTable(
                name: "InventoryCategories",
                columns: table => new
                {
                    InventoryCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryCategories", x => x.InventoryCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "InventoryTransactionTypes",
                columns: table => new
                {
                    InventoryTransactionTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryTransactionTypes", x => x.InventoryTransactionTypeID);
                });

            migrationBuilder.CreateTable(
                name: "MeasurementUnits",
                columns: table => new
                {
                    MeasurementUnitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasurementUnits", x => x.MeasurementUnitID);
                });

            migrationBuilder.CreateTable(
                name: "ModificationTypes",
                columns: table => new
                {
                    ModificationTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModificationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModificationTypes", x => x.ModificationTypeID);
                });

            migrationBuilder.CreateTable(
                name: "OrderTypes",
                columns: table => new
                {
                    OrderTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTypes", x => x.OrderTypeID);
                });

            migrationBuilder.CreateTable(
                name: "PhoneTypes",
                columns: table => new
                {
                    PhoneTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneTypes", x => x.PhoneTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "ScannableLabels",
                columns: table => new
                {
                    LabelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BarcodeValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LabelType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScannableLabels", x => x.LabelID);
                });

            migrationBuilder.CreateTable(
                name: "ShippingMethodTypes",
                columns: table => new
                {
                    ShippingMethodTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MethodName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingMethodTypes", x => x.ShippingMethodTypeID);
                });

            migrationBuilder.CreateTable(
                name: "StatusTypes",
                columns: table => new
                {
                    StatusTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusTypes", x => x.StatusTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    TableID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeatCapacity = table.Column<int>(type: "int", nullable: false),
                    IsCombinable = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.TableID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAddresses",
                columns: table => new
                {
                    AddressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressTypeID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddresses", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK_CustomerAddresses_AddressTypes_AddressTypeID",
                        column: x => x.AddressTypeID,
                        principalTable: "AddressTypes",
                        principalColumn: "AddressTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerAddresses_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerEmails",
                columns: table => new
                {
                    EmailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailTypeID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerEmails", x => x.EmailID);
                    table.ForeignKey(
                        name: "FK_CustomerEmails_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerEmails_EmailType_EmailTypeID",
                        column: x => x.EmailTypeID,
                        principalTable: "EmailType",
                        principalColumn: "EmailTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomerPhones",
                columns: table => new
                {
                    PhoneID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneTypeID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerPhones", x => x.PhoneID);
                    table.ForeignKey(
                        name: "FK_CustomerPhones_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerPhones_PhoneTypes_PhoneTypeID",
                        column: x => x.PhoneTypeID,
                        principalTable: "PhoneTypes",
                        principalColumn: "PhoneTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_User_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    EquipmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentStatusID = table.Column<int>(type: "int", nullable: false),
                    LastMaintenanceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NextMaintenanceDue = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CodeID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScannableLabelID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.EquipmentID);
                    table.ForeignKey(
                        name: "FK_Equipment_EquipmentStatuses_EquipmentStatusID",
                        column: x => x.EquipmentStatusID,
                        principalTable: "EquipmentStatuses",
                        principalColumn: "EquipmentStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipment_ScannableLabels_ScannableLabelID",
                        column: x => x.ScannableLabelID,
                        principalTable: "ScannableLabels",
                        principalColumn: "LabelID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScannableLabelID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationID);
                    table.ForeignKey(
                        name: "FK_Locations_ScannableLabels_ScannableLabelID",
                        column: x => x.ScannableLabelID,
                        principalTable: "ScannableLabels",
                        principalColumn: "LabelID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScannableLabelID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomID);
                    table.ForeignKey(
                        name: "FK_Rooms_ScannableLabels_ScannableLabelID",
                        column: x => x.ScannableLabelID,
                        principalTable: "ScannableLabels",
                        principalColumn: "LabelID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TableCombinations",
                columns: table => new
                {
                    TableComboID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableID = table.Column<int>(type: "int", nullable: false),
                    CombinedWithTableID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableCombinations", x => x.TableComboID);
                    table.ForeignKey(
                        name: "FK_TableCombinations_Tables_CombinedWithTableID",
                        column: x => x.CombinedWithTableID,
                        principalTable: "Tables",
                        principalColumn: "TableID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TableCombinations_Tables_TableID",
                        column: x => x.TableID,
                        principalTable: "Tables",
                        principalColumn: "TableID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeePositionID = table.Column<int>(type: "int", nullable: false),
                    CodeID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HourlyRate = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employees_EmployeePositions_EmployeePositionID",
                        column: x => x.EmployeePositionID,
                        principalTable: "EmployeePositions",
                        principalColumn: "EmployeePositionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    InventoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InventoryCategoryID = table.Column<int>(type: "int", nullable: false),
                    CostPerUnit = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    MeasurementUnitID = table.Column<int>(type: "int", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    CodeID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScannableLabelID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.InventoryID);
                    table.ForeignKey(
                        name: "FK_Inventories_InventoryCategories_InventoryCategoryID",
                        column: x => x.InventoryCategoryID,
                        principalTable: "InventoryCategories",
                        principalColumn: "InventoryCategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inventories_MeasurementUnits_MeasurementUnitID",
                        column: x => x.MeasurementUnitID,
                        principalTable: "MeasurementUnits",
                        principalColumn: "MeasurementUnitID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inventories_ScannableLabels_ScannableLabelID",
                        column: x => x.ScannableLabelID,
                        principalTable: "ScannableLabels",
                        principalColumn: "LabelID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inventories_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    RequiresShipping = table.Column<bool>(type: "bit", nullable: false),
                    OrderTypeID = table.Column<int>(type: "int", nullable: false),
                    CustomerComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryInstructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodeID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScannableLabelID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_OrderTypes_OrderTypeID",
                        column: x => x.OrderTypeID,
                        principalTable: "OrderTypes",
                        principalColumn: "OrderTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_ScannableLabels_ScannableLabelID",
                        column: x => x.ScannableLabelID,
                        principalTable: "ScannableLabels",
                        principalColumn: "LabelID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstimatedPrepTimeMinutes = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    EstimatedCost = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ServingSize = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeID);
                    table.ForeignKey(
                        name: "FK_Recipes_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentLogs",
                columns: table => new
                {
                    LogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipmentID = table.Column<int>(type: "int", nullable: false),
                    EquipmentLogTypeID = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentLogs", x => x.LogID);
                    table.ForeignKey(
                        name: "FK_EquipmentLogs_EquipmentLogTypes_EquipmentLogTypeID",
                        column: x => x.EquipmentLogTypeID,
                        principalTable: "EquipmentLogTypes",
                        principalColumn: "EquipmentLogTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EquipmentLogs_Equipment_EquipmentID",
                        column: x => x.EquipmentID,
                        principalTable: "Equipment",
                        principalColumn: "EquipmentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StorageLocations",
                columns: table => new
                {
                    StorageLocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomID = table.Column<int>(type: "int", nullable: false),
                    LocationID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageLocations", x => x.StorageLocationID);
                    table.ForeignKey(
                        name: "FK_StorageLocations_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StorageLocations_Rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Rooms",
                        principalColumn: "RoomID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatusHistories",
                columns: table => new
                {
                    OrderStatusHistoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    StatusTypeID = table.Column<int>(type: "int", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatusHistories", x => x.OrderStatusHistoryID);
                    table.ForeignKey(
                        name: "FK_OrderStatusHistories_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderStatusHistories_StatusTypes_StatusTypeID",
                        column: x => x.StatusTypeID,
                        principalTable: "StatusTypes",
                        principalColumn: "StatusTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PackingDetails",
                columns: table => new
                {
                    PackingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    PackedByUserID = table.Column<int>(type: "int", nullable: false),
                    StartPackingTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndPackingTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalPackedItems = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackingDetails", x => x.PackingID);
                    table.ForeignKey(
                        name: "FK_PackingDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackingDetails_User_PackedByUserID",
                        column: x => x.PackedByUserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shipping",
                columns: table => new
                {
                    ShippingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ShippingMethodTypeID = table.Column<int>(type: "int", nullable: false),
                    TrackingNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpectedDeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShippingCost = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    StatusTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipping", x => x.ShippingID);
                    table.ForeignKey(
                        name: "FK_Shipping_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shipping_ShippingMethodTypes_ShippingMethodTypeID",
                        column: x => x.ShippingMethodTypeID,
                        principalTable: "ShippingMethodTypes",
                        principalColumn: "ShippingMethodTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shipping_StatusTypes_StatusTypeID",
                        column: x => x.StatusTypeID,
                        principalTable: "StatusTypes",
                        principalColumn: "StatusTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SpecialOrderDetails",
                columns: table => new
                {
                    SpecialOrderDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    InventoryID = table.Column<int>(type: "int", nullable: false),
                    ModificationTypeID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    MeasurementUnitID = table.Column<int>(type: "int", nullable: false),
                    ModificationCost = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialOrderDetails", x => x.SpecialOrderDetailID);
                    table.ForeignKey(
                        name: "FK_SpecialOrderDetails_Inventories_InventoryID",
                        column: x => x.InventoryID,
                        principalTable: "Inventories",
                        principalColumn: "InventoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SpecialOrderDetails_MeasurementUnits_MeasurementUnitID",
                        column: x => x.MeasurementUnitID,
                        principalTable: "MeasurementUnits",
                        principalColumn: "MeasurementUnitID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SpecialOrderDetails_ModificationTypes_ModificationTypeID",
                        column: x => x.ModificationTypeID,
                        principalTable: "ModificationTypes",
                        principalColumn: "ModificationTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SpecialOrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    RecipeID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CodeID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.OrderItemID);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_Recipes_RecipeID",
                        column: x => x.RecipeID,
                        principalTable: "Recipes",
                        principalColumn: "RecipeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RecipeEquipment",
                columns: table => new
                {
                    RecipeEquipmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeID = table.Column<int>(type: "int", nullable: false),
                    EquipmentID = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeEquipment", x => x.RecipeEquipmentID);
                    table.ForeignKey(
                        name: "FK_RecipeEquipment_Equipment_EquipmentID",
                        column: x => x.EquipmentID,
                        principalTable: "Equipment",
                        principalColumn: "EquipmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RecipeEquipment_Recipes_RecipeID",
                        column: x => x.RecipeID,
                        principalTable: "Recipes",
                        principalColumn: "RecipeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    RecipeIngredientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeID = table.Column<int>(type: "int", nullable: false),
                    InventoryID = table.Column<int>(type: "int", nullable: false),
                    QuantityRequired = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    MeasurementUnitID = table.Column<int>(type: "int", nullable: false),
                    CodeID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NeedsReorder = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => x.RecipeIngredientID);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Inventories_InventoryID",
                        column: x => x.InventoryID,
                        principalTable: "Inventories",
                        principalColumn: "InventoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_MeasurementUnits_MeasurementUnitID",
                        column: x => x.MeasurementUnitID,
                        principalTable: "MeasurementUnits",
                        principalColumn: "MeasurementUnitID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Recipes_RecipeID",
                        column: x => x.RecipeID,
                        principalTable: "Recipes",
                        principalColumn: "RecipeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RecipeSteps",
                columns: table => new
                {
                    RecipeStepID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeID = table.Column<int>(type: "int", nullable: false),
                    StepNumber = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstimatedTimeMinutes = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    EstimatedCost = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    AdditionalNotes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeSteps", x => x.RecipeStepID);
                    table.ForeignKey(
                        name: "FK_RecipeSteps_Recipes_RecipeID",
                        column: x => x.RecipeID,
                        principalTable: "Recipes",
                        principalColumn: "RecipeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InventoryBatches",
                columns: table => new
                {
                    InventoryBatchID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventoryID = table.Column<int>(type: "int", nullable: false),
                    BatchNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    MeasurementUnitID = table.Column<int>(type: "int", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReceivedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StorageLocationID = table.Column<int>(type: "int", nullable: false),
                    ScannableLabelID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryBatches", x => x.InventoryBatchID);
                    table.ForeignKey(
                        name: "FK_InventoryBatches_Inventories_InventoryID",
                        column: x => x.InventoryID,
                        principalTable: "Inventories",
                        principalColumn: "InventoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryBatches_MeasurementUnits_MeasurementUnitID",
                        column: x => x.MeasurementUnitID,
                        principalTable: "MeasurementUnits",
                        principalColumn: "MeasurementUnitID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryBatches_ScannableLabels_ScannableLabelID",
                        column: x => x.ScannableLabelID,
                        principalTable: "ScannableLabels",
                        principalColumn: "LabelID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryBatches_StorageLocations_StorageLocationID",
                        column: x => x.StorageLocationID,
                        principalTable: "StorageLocations",
                        principalColumn: "StorageLocationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PackedItems",
                columns: table => new
                {
                    PackedItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackingID = table.Column<int>(type: "int", nullable: false),
                    OrderItemID = table.Column<int>(type: "int", nullable: false),
                    QuantityPacked = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackedItems", x => x.PackedItemID);
                    table.ForeignKey(
                        name: "FK_PackedItems_OrderItems_OrderItemID",
                        column: x => x.OrderItemID,
                        principalTable: "OrderItems",
                        principalColumn: "OrderItemID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackedItems_PackingDetails_PackingID",
                        column: x => x.PackingID,
                        principalTable: "PackingDetails",
                        principalColumn: "PackingID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RecipeStepLogs",
                columns: table => new
                {
                    RecipeStepLogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeStepID = table.Column<int>(type: "int", nullable: false),
                    ExecutionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualTimeMinutes = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ActualCost = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ExecutedByUserID = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeStepLogs", x => x.RecipeStepLogID);
                    table.ForeignKey(
                        name: "FK_RecipeStepLogs_RecipeSteps_RecipeStepID",
                        column: x => x.RecipeStepID,
                        principalTable: "RecipeSteps",
                        principalColumn: "RecipeStepID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InventoryTransactions",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventoryBatchID = table.Column<int>(type: "int", nullable: false),
                    InventoryTransactionTypeID = table.Column<int>(type: "int", nullable: false),
                    QuantityChange = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryTransactions", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_InventoryTransactions_InventoryBatches_InventoryBatchID",
                        column: x => x.InventoryBatchID,
                        principalTable: "InventoryBatches",
                        principalColumn: "InventoryBatchID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddresses_AddressTypeID",
                table: "CustomerAddresses",
                column: "AddressTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddresses_CustomerID",
                table: "CustomerAddresses",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerEmails_CustomerID",
                table: "CustomerEmails",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerEmails_EmailTypeID",
                table: "CustomerEmails",
                column: "EmailTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPhones_CustomerID",
                table: "CustomerPhones",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPhones_PhoneTypeID",
                table: "CustomerPhones",
                column: "PhoneTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeePositionID",
                table: "Employees",
                column: "EmployeePositionID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserID",
                table: "Employees",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_EquipmentStatusID",
                table: "Equipment",
                column: "EquipmentStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_ScannableLabelID",
                table: "Equipment",
                column: "ScannableLabelID");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentLogs_EquipmentID",
                table: "EquipmentLogs",
                column: "EquipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentLogs_EquipmentLogTypeID",
                table: "EquipmentLogs",
                column: "EquipmentLogTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_InventoryCategoryID",
                table: "Inventories",
                column: "InventoryCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_MeasurementUnitID",
                table: "Inventories",
                column: "MeasurementUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_ScannableLabelID",
                table: "Inventories",
                column: "ScannableLabelID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_UserID",
                table: "Inventories",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryBatches_InventoryID",
                table: "InventoryBatches",
                column: "InventoryID");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryBatches_MeasurementUnitID",
                table: "InventoryBatches",
                column: "MeasurementUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryBatches_ScannableLabelID",
                table: "InventoryBatches",
                column: "ScannableLabelID");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryBatches_StorageLocationID",
                table: "InventoryBatches",
                column: "StorageLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryTransactions_InventoryBatchID",
                table: "InventoryTransactions",
                column: "InventoryBatchID");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_ScannableLabelID",
                table: "Locations",
                column: "ScannableLabelID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderID",
                table: "OrderItems",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_RecipeID",
                table: "OrderItems",
                column: "RecipeID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderTypeID",
                table: "Orders",
                column: "OrderTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ScannableLabelID",
                table: "Orders",
                column: "ScannableLabelID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderStatusHistories_OrderID",
                table: "OrderStatusHistories",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderStatusHistories_StatusTypeID",
                table: "OrderStatusHistories",
                column: "StatusTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_PackedItems_OrderItemID",
                table: "PackedItems",
                column: "OrderItemID");

            migrationBuilder.CreateIndex(
                name: "IX_PackedItems_PackingID",
                table: "PackedItems",
                column: "PackingID");

            migrationBuilder.CreateIndex(
                name: "IX_PackingDetails_OrderID",
                table: "PackingDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_PackingDetails_PackedByUserID",
                table: "PackingDetails",
                column: "PackedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeEquipment_EquipmentID",
                table: "RecipeEquipment",
                column: "EquipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeEquipment_RecipeID",
                table: "RecipeEquipment",
                column: "RecipeID");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_InventoryID",
                table: "RecipeIngredients",
                column: "InventoryID");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_MeasurementUnitID",
                table: "RecipeIngredients",
                column: "MeasurementUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_RecipeID",
                table: "RecipeIngredients",
                column: "RecipeID");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_UserID",
                table: "Recipes",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeStepLogs_RecipeStepID",
                table: "RecipeStepLogs",
                column: "RecipeStepID");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeSteps_RecipeID",
                table: "RecipeSteps",
                column: "RecipeID");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_ScannableLabelID",
                table: "Rooms",
                column: "ScannableLabelID");

            migrationBuilder.CreateIndex(
                name: "IX_Shipping_OrderID",
                table: "Shipping",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Shipping_ShippingMethodTypeID",
                table: "Shipping",
                column: "ShippingMethodTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Shipping_StatusTypeID",
                table: "Shipping",
                column: "StatusTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialOrderDetails_InventoryID",
                table: "SpecialOrderDetails",
                column: "InventoryID");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialOrderDetails_MeasurementUnitID",
                table: "SpecialOrderDetails",
                column: "MeasurementUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialOrderDetails_ModificationTypeID",
                table: "SpecialOrderDetails",
                column: "ModificationTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialOrderDetails_OrderID",
                table: "SpecialOrderDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_StorageLocations_LocationID",
                table: "StorageLocations",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_StorageLocations_RoomID",
                table: "StorageLocations",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_TableCombinations_CombinedWithTableID",
                table: "TableCombinations",
                column: "CombinedWithTableID");

            migrationBuilder.CreateIndex(
                name: "IX_TableCombinations_TableID",
                table: "TableCombinations",
                column: "TableID");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleID",
                table: "User",
                column: "RoleID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerAddresses");

            migrationBuilder.DropTable(
                name: "CustomerEmails");

            migrationBuilder.DropTable(
                name: "CustomerPhones");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "EquipmentLogs");

            migrationBuilder.DropTable(
                name: "InventoryTransactions");

            migrationBuilder.DropTable(
                name: "InventoryTransactionTypes");

            migrationBuilder.DropTable(
                name: "OrderStatusHistories");

            migrationBuilder.DropTable(
                name: "PackedItems");

            migrationBuilder.DropTable(
                name: "RecipeEquipment");

            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "RecipeStepLogs");

            migrationBuilder.DropTable(
                name: "Shipping");

            migrationBuilder.DropTable(
                name: "SpecialOrderDetails");

            migrationBuilder.DropTable(
                name: "TableCombinations");

            migrationBuilder.DropTable(
                name: "AddressTypes");

            migrationBuilder.DropTable(
                name: "EmailType");

            migrationBuilder.DropTable(
                name: "PhoneTypes");

            migrationBuilder.DropTable(
                name: "EmployeePositions");

            migrationBuilder.DropTable(
                name: "EquipmentLogTypes");

            migrationBuilder.DropTable(
                name: "InventoryBatches");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "PackingDetails");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "RecipeSteps");

            migrationBuilder.DropTable(
                name: "ShippingMethodTypes");

            migrationBuilder.DropTable(
                name: "StatusTypes");

            migrationBuilder.DropTable(
                name: "ModificationTypes");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "StorageLocations");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "EquipmentStatuses");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "InventoryCategories");

            migrationBuilder.DropTable(
                name: "MeasurementUnits");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OrderTypes");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "ScannableLabels");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
