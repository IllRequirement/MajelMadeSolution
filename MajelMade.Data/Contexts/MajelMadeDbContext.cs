using Microsoft.EntityFrameworkCore;
using MajelMade.Data;
using MajelMade.Domain.Entities;
using System;

namespace MajelMade.Data.Contexts
{
    public class MajelMadeDbContext(DbContextOptions<MajelMadeDbContext> options) : DbContext(options)
    {

        // Core Entities
            public DbSet<AddressType> AddressTypes { get; set; }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<CustomerAddress> CustomerAddresses { get; set; }
            public DbSet<CustomerEmail> CustomerEmails { get; set; }
            public DbSet<CustomerPhone> CustomerPhones { get; set; }
            public DbSet<Employee> Employees { get; set; }
            public DbSet<EmployeePosition> EmployeePositions { get; set; }
            public DbSet<Equipment> Equipment { get; set; }
            public DbSet<EquipmentLog> EquipmentLogs { get; set; }
            public DbSet<EquipmentLogType> EquipmentLogTypes { get; set; }
            public DbSet<EquipmentStatus> EquipmentStatuses { get; set; }
            public DbSet<Inventory> Inventories { get; set; }
            public DbSet<InventoryBatch> InventoryBatches { get; set; }
            public DbSet<InventoryCategory> InventoryCategories { get; set; }
            public DbSet<InventoryTransaction> InventoryTransactions { get; set; }
            public DbSet<InventoryTransactionType> InventoryTransactionTypes { get; set; }
            public DbSet<Location> Locations { get; set; }
            public DbSet<MeasurementUnit> MeasurementUnits { get; set; }
            public DbSet<ModificationType> ModificationTypes { get; set; }
            public DbSet<Order> Orders { get; set; }
            public DbSet<OrderItem> OrderItems { get; set; }
            public DbSet<OrderStatusHistory> OrderStatusHistories { get; set; }
            public DbSet<OrderType> OrderTypes { get; set; }
            public DbSet<PhoneType> PhoneTypes { get; set; }
            public DbSet<Recipe> Recipes { get; set; }
            public DbSet<RecipeEquipment> RecipeEquipment { get; set; }
            public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
            public DbSet<RecipeStep> RecipeSteps { get; set; }
            public DbSet<RecipeStepLog> RecipeStepLogs { get; set; }
            public DbSet<Role> Roles { get; set; }
            public DbSet<Room> Rooms { get; set; }
            public DbSet<ScannableLabel> ScannableLabels { get; set; }
            public DbSet<Shipping> Shipping { get; set; }
            public DbSet<ShippingMethodType> ShippingMethodTypes { get; set; }
            public DbSet<SpecialOrderDetail> SpecialOrderDetails { get; set; }
            public DbSet<StatusType> StatusTypes { get; set; }
            public DbSet<StorageLocation> StorageLocations { get; set; }
            public DbSet<Table> Tables { get; set; }
            public DbSet<TableCombination> TableCombinations { get; set; }
            public DbSet<PackingDetails> PackingDetails { get; set; }
            public DbSet<PackedItem> PackedItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // --- Fluent Configuration & Seed Data ---

            // AddressType (Lookup)
            modelBuilder.Entity<AddressType>(entity =>
            {
                entity.HasKey(e => e.AddressTypeID);
                entity.Property(e => e.TypeName).IsRequired();
                entity.HasData(
                    new AddressType(1, "Home"),
                    new AddressType(2, "Work"),
                    new AddressType(3, "Billing"),
                    new AddressType(4, "Shipping"),
                    new AddressType(5, "Other")
                );

            });

            // Customer
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerID);
                entity.Property(e => e.FirstName).IsRequired();
                entity.Property(e => e.LastName).IsRequired();
                entity.Property(e => e.DateCreated).IsRequired();
                //entity.HasData(
                //    new Customer { CustomerID = 1, FirstName = "John", LastName = "Doe", DateCreated = new DateTime(2023, 1, 1) },
                //    new Customer { CustomerID = 2, FirstName = "Alice", LastName = "Smith", DateCreated = new DateTime(2023, 1, 2) },
                //    new Customer { CustomerID = 3, FirstName = "Bob", LastName = "Brown", DateCreated = new DateTime(2023, 1, 3) },
                //    new Customer { CustomerID = 4, FirstName = "Carol", LastName = "White", DateCreated = new DateTime(2023, 1, 4) },
                //    new Customer { CustomerID = 5, FirstName = "David", LastName = "Green", DateCreated = new DateTime(2023, 1, 5) }
                //);
            });

            // CustomerAddress
            modelBuilder.Entity<CustomerAddress>(entity =>
            {
                entity.HasKey(e => e.AddressID);
                entity.Property(e => e.Address).IsRequired();
                entity.Property(e => e.IsActive).HasDefaultValue(true);
                //entity.HasData(
                //    new CustomerAddress { AddressID = 1, CustomerID = 1, Address = "123 Main St", AddressTypeID = 1, IsActive = true, Customer = null!, AddressType = null! },
                //    new CustomerAddress { AddressID = 2, CustomerID = 2, Address = "456 Oak Ave", AddressTypeID = 2, IsActive = true, Customer = null!, AddressType = null! },
                //    new CustomerAddress { AddressID = 3, CustomerID = 3, Address = "789 Pine Rd", AddressTypeID = 1, IsActive = true, Customer = null!, AddressType = null! },
                //    new CustomerAddress { AddressID = 4, CustomerID = 4, Address = "321 Maple Ln", AddressTypeID = 1, IsActive = true, Customer = null!, AddressType = null! },
                //    new CustomerAddress { AddressID = 5, CustomerID = 5, Address = "654 Elm St", AddressTypeID = 2, IsActive = true, Customer = null!, AddressType = null! }
                //);
            });


            // CustomerPhone
            modelBuilder.Entity<CustomerPhone>(entity =>
            {
                entity.HasKey(e => e.PhoneID);
                entity.Property(e => e.PhoneNumber).IsRequired();
                entity.Property(e => e.IsActive).HasDefaultValue(true);
                //entity.HasData(
                //    new CustomerPhone { PhoneID = 1, CustomerID = 1, PhoneNumber = "555-1001", PhoneTypeID = 1, IsActive = true, Customer = null!, PhoneType = null! },
                //    new CustomerPhone { PhoneID = 2, CustomerID = 2, PhoneNumber = "555-1002", PhoneTypeID = 2, IsActive = true, Customer = null!, PhoneType = null! },
                //    new CustomerPhone { PhoneID = 3, CustomerID = 3, PhoneNumber = "555-1003", PhoneTypeID = 3, IsActive = true, Customer = null!, PhoneType = null! },
                //    new CustomerPhone { PhoneID = 4, CustomerID = 4, PhoneNumber = "555-1004", PhoneTypeID = 1, IsActive = true, Customer = null!, PhoneType = null! },
                //    new CustomerPhone { PhoneID = 5, CustomerID = 5, PhoneNumber = "555-1005", PhoneTypeID = 2, IsActive = true, Customer = null!, PhoneType = null! }
                //);
            });


            // CustomerEmail
            modelBuilder.Entity<CustomerEmail>(entity =>
            {
                entity.HasKey(e => e.EmailID);
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.IsActive).HasDefaultValue(true);
                entity.HasOne(e => e.EmailType)
                      .WithMany()  // No navigation collection on EmailType in this example
                      .HasForeignKey(e => e.EmailTypeID)
                      .OnDelete(DeleteBehavior.Restrict);
                //entity.HasData(
                //    new CustomerEmail { EmailID = 1, CustomerID = 1, Email = "john.doe@example.com", EmailTypeID = 1, IsActive = true, Customer = null!, EmailType = null! },
                //    new CustomerEmail { EmailID = 2, CustomerID = 2, Email = "alice.smith@example.com", EmailTypeID = 2, IsActive = true, Customer = null!, EmailType = null! },
                //    new CustomerEmail { EmailID = 3, CustomerID = 3, Email = "bob.brown@example.com", EmailTypeID = 1, IsActive = true, Customer = null!, EmailType = null! },
                //    new CustomerEmail { EmailID = 4, CustomerID = 4, Email = "carol.white@example.com", EmailTypeID = 2, IsActive = true, Customer = null!, EmailType = null! },
                //    new CustomerEmail { EmailID = 5, CustomerID = 5, Email = "david.green@example.com", EmailTypeID = 1, IsActive = true, Customer = null!, EmailType = null! }
                //);
            });


            // EmailType
            modelBuilder.Entity<EmailType>(entity =>
            {
                entity.HasKey(e => e.EmailTypeID);
                entity.Property(e => e.TypeName).IsRequired();
                entity.HasData(
                     new EmailType (1, "Personal"),
                     new EmailType (2, "Work"),
                     new EmailType (3, "School"),
                     new EmailType (4, "Other"),
                     new EmailType (5, "Family")
                );
            });


            // Employee
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeID);
                entity.Property(e => e.EmployeeName).IsRequired();
                entity.Property(e => e.HourlyRate).HasColumnType("decimal(10,2)");
                //entity.HasData(
                //    new Employee { EmployeeID = 1, UserID = 1, EmployeeName = "Employee One", EmployeePositionID = 1, HourlyRate = 15.50m, StartDate = new DateTime(2023, 2, 1), CodeID = "E001", User = null!, EmployeePosition = null! },
                //    new Employee { EmployeeID = 2, UserID = 2, EmployeeName = "Employee Two", EmployeePositionID = 2, HourlyRate = 16.00m, StartDate = new DateTime(2023, 2, 2), CodeID = "E002", User = null!, EmployeePosition = null! },
                //    new Employee { EmployeeID = 3, UserID = 3, EmployeeName = "Employee Three", EmployeePositionID = 3, HourlyRate = 17.00m, StartDate = new DateTime(2023, 2, 3), CodeID = "E003", User = null!, EmployeePosition = null! },
                //    new Employee { EmployeeID = 4, UserID = 4, EmployeeName = "Employee Four", EmployeePositionID = 4, HourlyRate = 18.00m, StartDate = new DateTime(2023, 2, 4), CodeID = "E004", User = null!, EmployeePosition = null! },
                //    new Employee { EmployeeID = 5, UserID = 5, EmployeeName = "Employee Five", EmployeePositionID = 5, HourlyRate = 19.00m, StartDate = new DateTime(2023, 2, 5), CodeID = "E005", User = null!, EmployeePosition = null! }
                //);
            });

            // EmployeePosition
            modelBuilder.Entity<EmployeePosition>(entity =>
            {
                entity.HasKey(e => e.EmployeePositionID);
                entity.Property(e => e.PositionName).IsRequired();
                entity.HasData(
                    new EmployeePosition (1, "Cook"),
                    new EmployeePosition (2, "Server"),
                    new EmployeePosition (3, "Manager"),
                    new EmployeePosition (4, "Chef"),
                    new EmployeePosition (5, "Delivery")
                );
            });

            // Equipment
            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.HasKey(e => e.EquipmentID);
                entity.Property(e => e.EquipmentName).IsRequired();
                entity.Property(e => e.ModelNumber).IsRequired();
                entity.Property(e => e.SerialNumber).IsRequired();
                entity.Property(e => e.CodeID).IsRequired();
                entity.HasOne(e => e.ScannableLabel)
                      .WithMany()
                      .HasForeignKey(e => e.ScannableLabelID)
                      .OnDelete(DeleteBehavior.Restrict);
                //entity.HasData(
                //    new Equipment { EquipmentID = 1, EquipmentName = "Oven", ModelNumber = "OM100", SerialNumber = "SN001", EquipmentStatusID = 1, LastMaintenanceDate = new DateTime(2023, 1, 15), NextMaintenanceDue = new DateTime(2023, 7, 15), CodeID = "EQ001", ScannableLabelID = 5, ScannableLabel = null! },
                //    new Equipment { EquipmentID = 2, EquipmentName = "Grill", ModelNumber = "GM200", SerialNumber = "SN002", EquipmentStatusID = 1, LastMaintenanceDate = new DateTime(2023, 1, 16), NextMaintenanceDue = new DateTime(2023, 7, 16), CodeID = "EQ002", ScannableLabelID = 5, ScannableLabel = null! },
                //    new Equipment { EquipmentID = 3, EquipmentName = "Mixer", ModelNumber = "MX300", SerialNumber = "SN003", EquipmentStatusID = 1, LastMaintenanceDate = new DateTime(2023, 1, 17), NextMaintenanceDue = new DateTime(2023, 7, 17), CodeID = "EQ003", ScannableLabelID = 5, ScannableLabel = null! },
                //    new Equipment { EquipmentID = 4, EquipmentName = "Blender", ModelNumber = "BL400", SerialNumber = "SN004", EquipmentStatusID = 1, LastMaintenanceDate = new DateTime(2023, 1, 18), NextMaintenanceDue = new DateTime(2023, 7, 18), CodeID = "EQ004", ScannableLabelID = 5, ScannableLabel = null! },
                //    new Equipment { EquipmentID = 5, EquipmentName = "Toaster", ModelNumber = "TS500", SerialNumber = "SN005", EquipmentStatusID = 1, LastMaintenanceDate = new DateTime(2023, 1, 19), NextMaintenanceDue = new DateTime(2023, 7, 19), CodeID = "EQ005", ScannableLabelID = 5, ScannableLabel = null! }
                //);
            });

            // EquipmentLog
            modelBuilder.Entity<EquipmentLog>(entity =>
            {
                entity.HasKey(e => e.LogID);
                entity.Property(e => e.Duration).HasColumnType("decimal(10,2)");
                entity.Property(e => e.Cost).HasColumnType("decimal(10,2)");
                entity.HasOne(el => el.Equipment)
                      .WithMany(e => e.EquipmentLogs)
                      .HasForeignKey(el => el.EquipmentID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(el => el.EquipmentLogType)
                      .WithMany(elt => elt.EquipmentLogs)
                      .HasForeignKey(el => el.EquipmentLogTypeID)
                      .OnDelete(DeleteBehavior.Restrict);
                //entity.HasData(
                //    new EquipmentLog { LogID = 1, EquipmentID = 1, EquipmentLogTypeID = 1, Duration = 1.5m, Cost = 10.00m, Notes = "Maintenance check", Equipment = null!, EquipmentLogType = null! },
                //    new EquipmentLog { LogID = 2, EquipmentID = 2, EquipmentLogTypeID = 2, Duration = 2.0m, Cost = 15.00m, Notes = "Repair performed", Equipment = null!, EquipmentLogType = null! },
                //    new EquipmentLog { LogID = 3, EquipmentID = 3, EquipmentLogTypeID = 1, Duration = 1.0m, Cost = 8.00m, Notes = "Routine check", Equipment = null!, EquipmentLogType = null! },
                //    new EquipmentLog { LogID = 4, EquipmentID = 4, EquipmentLogTypeID = 3, Duration = 1.2m, Cost = 12.00m, Notes = "Inspection", Equipment = null!, EquipmentLogType = null! },
                //    new EquipmentLog { LogID = 5, EquipmentID = 5, EquipmentLogTypeID = 1, Duration = 0.5m, Cost = 5.00m, Notes = "Quick maintenance", Equipment = null!, EquipmentLogType = null! }
                //);
            });

            // EquipmentLogType
            modelBuilder.Entity<EquipmentLogType>(entity =>
            {
                entity.HasKey(e => e.EquipmentLogTypeID);
                entity.Property(e => e.LogTypeName).IsRequired();
                entity.HasData(
                    new EquipmentLogType (2, "Repair"),
                    new EquipmentLogType (1, "Maintenance"),
                    new EquipmentLogType (3, "Inspection"),
                    new EquipmentLogType (4, "Calibration"),
                    new EquipmentLogType (5, "Upgrade")
                );
            });

            // EquipmentStatus
            modelBuilder.Entity<EquipmentStatus>(entity =>
            {
                entity.HasKey(e => e.EquipmentStatusID);
                entity.Property(e => e.StatusName).IsRequired();
                entity.HasData(
                    new EquipmentStatus (1, "In Service"),
                    new EquipmentStatus (2, "Under Repair"),
                    new EquipmentStatus (3, "Out of Service"),
                    new EquipmentStatus (4, "Maintenance Required"),
                    new EquipmentStatus (5, "Retired")
                );
            });

            // InventoryCategory
            modelBuilder.Entity<InventoryCategory>(entity =>
            {
                entity.HasKey(e => e.InventoryCategoryID);
                entity.Property(e => e.CategoryName).IsRequired();
                entity.HasData(
                    new InventoryCategory (1, "Meat", "Animal meat products"),
                    new InventoryCategory (2, "Dairy", "Milk, cheese, and related products"),
                    new InventoryCategory (3, "Vegetable", "Fresh vegetables"),
                    new InventoryCategory (4, "Grain", "Cereals and grain products"),
                    new InventoryCategory (5, "Fruit", "Fresh fruit")
                );
            });

            // Inventory
            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasKey(e => e.InventoryID);
                entity.Property(e => e.ItemName).IsRequired();
                entity.Property(e => e.CostPerUnit).HasColumnType("decimal(10,2)");
                entity.Property(e => e.LastUpdated).IsRequired();
                entity.HasOne(e => e.InventoryCategory)
                      .WithMany(ic => ic.Inventories)
                      .HasForeignKey(e => e.InventoryCategoryID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne<MeasurementUnit>()
                      .WithMany()
                      .HasForeignKey(e => e.MeasurementUnitID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne<User>()
                      .WithMany()
                      .HasForeignKey(e => e.UserID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasMany(e => e.InventoryBatches)
                      .WithOne(ib => ib.Inventory)
                      .HasForeignKey(ib => ib.InventoryID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.ScannableLabel)
                      .WithMany()
                      .HasForeignKey(e => e.ScannableLabelID)
                      .OnDelete(DeleteBehavior.Restrict);
                //entity.HasData(
                //    new Inventory { InventoryID = 1, ItemName = "Chicken Breast", InventoryCategoryID = 1, CostPerUnit = 5.00m, MeasurementUnitID = 1, LastUpdated = new DateTime(2023, 1, 1), UserID = 1, CodeID = "INV001", ScannableLabelID = null, InventoryCategory = null!, ScannableLabel = null! },
                //    new Inventory { InventoryID = 2, ItemName = "Cheddar Cheese", InventoryCategoryID = 2, CostPerUnit = 3.50m, MeasurementUnitID = 1, LastUpdated = new DateTime(2023, 1, 2), UserID = 2, CodeID = "INV002", ScannableLabelID = null, InventoryCategory = null!, ScannableLabel = null! },
                //    new Inventory { InventoryID = 3, ItemName = "Lettuce", InventoryCategoryID = 3, CostPerUnit = 1.50m, MeasurementUnitID = 2, LastUpdated = new DateTime(2023, 1, 3), UserID = 3, CodeID = "INV003", ScannableLabelID = null, InventoryCategory = null!, ScannableLabel = null! },
                //    new Inventory { InventoryID = 4, ItemName = "Rice", InventoryCategoryID = 4, CostPerUnit = 0.80m, MeasurementUnitID = 1, LastUpdated = new DateTime(2023, 1, 4), UserID = 4, CodeID = "INV004", ScannableLabelID = null, InventoryCategory = null!, ScannableLabel = null! },
                //    new Inventory { InventoryID = 5, ItemName = "Apple", InventoryCategoryID = 5, CostPerUnit = 0.60m, MeasurementUnitID = 2, LastUpdated = new DateTime(2023, 1, 5), UserID = 5, CodeID = "INV005", ScannableLabelID = null, InventoryCategory = null!, ScannableLabel = null! }
                //);
            });

            // InventoryBatch
            modelBuilder.Entity<InventoryBatch>(entity =>
            {
                entity.HasKey(e => e.InventoryBatchID);
                entity.Property(e => e.BatchNumber).IsRequired();
                entity.Property(e => e.Quantity).HasColumnType("decimal(10,2)");
                entity.Property(e => e.ReceivedDate).IsRequired();
                entity.HasOne(ib => ib.Inventory)
                      .WithMany(i => i.InventoryBatches)
                      .HasForeignKey(ib => ib.InventoryID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne<MeasurementUnit>()
                      .WithMany()
                      .HasForeignKey(ib => ib.MeasurementUnitID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(ib => ib.StorageLocation)
                      .WithMany(sl => sl.InventoryBatches)
                      .HasForeignKey(ib => ib.StorageLocationID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasMany(ib => ib.InventoryTransactions)
                      .WithOne(it => it.InventoryBatch)
                      .HasForeignKey(it => it.InventoryBatchID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(ib => ib.ScannableLabel)
                      .WithMany()
                      .HasForeignKey(ib => ib.ScannableLabelID)
                      .OnDelete(DeleteBehavior.Restrict);
                //entity.HasData(
                //    new InventoryBatch { InventoryBatchID = 1, InventoryID = 1, BatchNumber = "B001", Quantity = 100m, MeasurementUnitID = 1, ExpirationDate = new DateTime(2023, 12, 31), ReceivedDate = new DateTime(2023, 1, 10), StorageLocationID = 1, Inventory = null!, StorageLocation = null!, ScannableLabel = null! },
                //    new InventoryBatch { InventoryBatchID = 2, InventoryID = 2, BatchNumber = "B002", Quantity = 50m, MeasurementUnitID = 2, ExpirationDate = new DateTime(2023, 11, 30), ReceivedDate = new DateTime(2023, 2, 11), StorageLocationID = 2, Inventory = null!, StorageLocation = null!, ScannableLabel = null! },
                //    new InventoryBatch { InventoryBatchID = 3, InventoryID = 3, BatchNumber = "B003", Quantity = 200m, MeasurementUnitID = 2, ExpirationDate = new DateTime(2023, 10, 15), ReceivedDate = new DateTime(2023, 1, 12), StorageLocationID = 3, Inventory = null!, StorageLocation = null!, ScannableLabel = null! },
                //    new InventoryBatch { InventoryBatchID = 4, InventoryID = 4, BatchNumber = "B004", Quantity = 300m, MeasurementUnitID = 4, ExpirationDate = new DateTime(2024, 1, 1), ReceivedDate = new DateTime(2024, 4, 13), StorageLocationID = 4, Inventory = null!, StorageLocation = null!, ScannableLabel = null! },
                //    new InventoryBatch { InventoryBatchID = 5, InventoryID = 5, BatchNumber = "B005", Quantity = 150m, MeasurementUnitID = 2, ExpirationDate = new DateTime(2023, 9, 30), ReceivedDate = new DateTime(2023, 1, 14), StorageLocationID = 5, Inventory = null!, StorageLocation = null!, ScannableLabel = null! }
                //);
            });

            // InventoryTransaction
            modelBuilder.Entity<InventoryTransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionID);
                entity.Property(e => e.QuantityChange).HasColumnType("decimal(10,2)");
                entity.Property(e => e.TransactionDate).IsRequired();
                //entity.HasData(
                //    new InventoryTransaction { TransactionID = 1, InventoryBatchID = 1, InventoryTransactionTypeID = 1, QuantityChange = 100m, TransactionDate = new DateTime(2023, 1, 15), Notes = "Initial stock", InventoryBatch = null! },
                //    new InventoryTransaction { TransactionID = 2, InventoryBatchID = 2, InventoryTransactionTypeID = 1, QuantityChange = 50m, TransactionDate = new DateTime(2023, 1, 16), Notes = "Initial stock", InventoryBatch = null! },
                //    new InventoryTransaction { TransactionID = 3, InventoryBatchID = 3, InventoryTransactionTypeID = 1, QuantityChange = 200m, TransactionDate = new DateTime(2023, 1, 17), Notes = "Initial stock", InventoryBatch = null! },
                //    new InventoryTransaction { TransactionID = 4, InventoryBatchID = 4, InventoryTransactionTypeID = 1, QuantityChange = 300m, TransactionDate = new DateTime(2023, 1, 18), Notes = "Initial stock", InventoryBatch = null! },
                //    new InventoryTransaction { TransactionID = 5, InventoryBatchID = 5, InventoryTransactionTypeID = 1, QuantityChange = 150m, TransactionDate = new DateTime(2023, 1, 19), Notes = "Initial stock", InventoryBatch = null! }
                //);
            });

            // InventoryTransactionType
            modelBuilder.Entity<InventoryTransactionType>(entity =>
            {
                entity.HasKey(e => e.InventoryTransactionTypeID);
                entity.Property(e => e.TransactionTypeName).IsRequired();
                entity.HasData(
                    new InventoryTransactionType (1, "Add"),
                    new InventoryTransactionType (2, "Subtract"),
                    new InventoryTransactionType (3, "Adjustment"),
                    new InventoryTransactionType (4, "Transfer"),
                    new InventoryTransactionType (5, "Return")
                );
            });

            // Location
            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(e => e.LocationID);
                entity.Property(e => e.LocationName).IsRequired();
                entity.HasMany(l => l.StorageLocations)
                      .WithOne(sl => sl.Location)
                      .HasForeignKey(sl => sl.LocationID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(l => l.ScannableLabel)
                      .WithMany()
                      .HasForeignKey(l => l.ScannableLabelID)
                      .OnDelete(DeleteBehavior.Restrict);
                //entity.HasData(
                //    new Location { LocationID = 1, LocationName = "North Section", ScannableLabel = null! },
                //    new Location { LocationID = 2, LocationName = "South Section", ScannableLabel = null! },
                //    new Location { LocationID = 3, LocationName = "East Wing", ScannableLabel = null! },
                //    new Location { LocationID = 4, LocationName = "West Wing", ScannableLabel = null! },
                //    new Location { LocationID = 5, LocationName = "Central", ScannableLabel = null! }
                //);
            });


            // MeasurementUnit
            modelBuilder.Entity<MeasurementUnit>(entity =>
            {
                entity.HasKey(e => e.MeasurementUnitID);
                entity.Property(e => e.UnitName).IsRequired();
                entity.HasData(
                    new MeasurementUnit (1, "lb"),
                    new MeasurementUnit (2, "each"),
                    new MeasurementUnit (3, "kg"),
                    new MeasurementUnit (4, "liters"),
                    new MeasurementUnit (5, "gallon")
                );
            });

            // ModificationType
            modelBuilder.Entity<ModificationType>(entity =>
            {
                entity.HasKey(e => e.ModificationTypeID);
                entity.Property(e => e.ModificationName).IsRequired();
                entity.HasData(
                    new ModificationType (1, "Extra Sauce"),
                    new ModificationType (2, "No Salt"),
                    new ModificationType (3, "Gluten-Free"),
                    new ModificationType (4, "Extra Cheese"),
                    new ModificationType (5, "Spicy")
                );
            });

            // Order
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.OrderID);
                entity.Property(e => e.OrderDate).IsRequired();
                entity.Property(e => e.TotalCost).HasColumnType("decimal(10,2)");
                entity.HasOne(o => o.Customer)
                      .WithMany()
                      .HasForeignKey(o => o.CustomerID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(o => o.User)
                      .WithMany(u => u.Orders)
                      .HasForeignKey(o => o.UserID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(o => o.OrderType)
                      .WithMany()
                      .HasForeignKey(o => o.OrderTypeID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasMany(o => o.OrderItems)
                      .WithOne(oi => oi.Order)
                      .HasForeignKey(oi => oi.OrderID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasMany(o => o.OrderStatusHistories)
                      .WithOne(osh => osh.Order)
                      .HasForeignKey(osh => osh.OrderID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(o => o.ScannableLabel)
                      .WithMany()
                      .HasForeignKey(o => o.ScannableLabelID)
                      .OnDelete(DeleteBehavior.Restrict);
                //entity.HasData(
                //    new Order { OrderID = 1, CustomerID = 1, UserID = 1, OrderDate = new DateTime(2023, 2, 1), TotalCost = 25.00m, RequiresShipping = false, OrderTypeID = 1, CustomerComments = "No onions", DeliveryInstructions = "", CodeID = "ORD001", Customer = null!, User = null!, OrderType = null!, ScannableLabel = null! },
                //    new Order { OrderID = 2, CustomerID = 2, UserID = 2, OrderDate = new DateTime(2023, 2, 2), TotalCost = 30.00m, RequiresShipping = true, OrderTypeID = 3, CustomerComments = "Extra napkins", DeliveryInstructions = "Leave at door", CodeID = "ORD002", Customer = null!, User = null!, OrderType = null!, ScannableLabel = null! },
                //    new Order { OrderID = 3, CustomerID = 3, UserID = 3, OrderDate = new DateTime(2023, 2, 3), TotalCost = 15.00m, RequiresShipping = false, OrderTypeID = 2, CustomerComments = "Quick service", DeliveryInstructions = "", CodeID = "ORD003", Customer = null!, User = null!, OrderType = null!, ScannableLabel = null! },
                //    new Order { OrderID = 4, CustomerID = 4, UserID = 4, OrderDate = new DateTime(2023, 2, 4), TotalCost = 40.00m, RequiresShipping = true, OrderTypeID = 3, CustomerComments = "Call on arrival", DeliveryInstructions = "Hand to front desk", CodeID = "ORD004", Customer = null!, User = null!, OrderType = null!, ScannableLabel = null! },
                //    new Order { OrderID = 5, CustomerID = 5, UserID = 5, OrderDate = new DateTime(2023, 2, 5), TotalCost = 35.00m, RequiresShipping = false, OrderTypeID = 1, CustomerComments = "Allergic to nuts", DeliveryInstructions = "", CodeID = "ORD005", Customer = null!, User = null!, OrderType = null!, ScannableLabel = null! }
                //);
            });


            // OrderItem
            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasKey(e => e.OrderItemID);
                entity.Property(e => e.Quantity).IsRequired();
                entity.HasOne(oi => oi.Order)
                      .WithMany(o => o.OrderItems)
                      .HasForeignKey(oi => oi.OrderID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(oi => oi.Recipe)
                      .WithMany()
                      .HasForeignKey(oi => oi.RecipeID)
                      .OnDelete(DeleteBehavior.Restrict);
               // entity.HasData(
               //     new OrderItem { OrderItemID = 1, OrderID = 1, RecipeID = 1, Quantity = 2, CodeID = "OI001", Order = null!, Recipe = null! },
               //     new OrderItem { OrderItemID = 2, OrderID = 2, RecipeID = 2, Quantity = 1, CodeID = "OI002", Order = null!, Recipe = null! },
               //     new OrderItem { OrderItemID = 3, OrderID = 3, RecipeID = 3, Quantity = 3, CodeID = "OI003", Order = null!, Recipe = null! },
               //     new OrderItem { OrderItemID = 4, OrderID = 4, RecipeID = 4, Quantity = 1, CodeID = "OI004", Order = null!, Recipe = null! },
               //     new OrderItem { OrderItemID = 5, OrderID = 5, RecipeID = 5, Quantity = 2, CodeID = "OI005", Order = null!, Recipe = null! }
               // );
            });

            // OrderStatusHistory
            modelBuilder.Entity<OrderStatusHistory>(entity =>
            {
                entity.HasKey(e => e.OrderStatusHistoryID);
                entity.Property(e => e.UpdatedDateTime).IsRequired();
                entity.HasOne(osh => osh.StatusType)
                      .WithMany()
                      .HasForeignKey(osh => osh.StatusTypeID)
                      .OnDelete(DeleteBehavior.Restrict);
               // entity.HasData(
               //     new OrderStatusHistory { OrderStatusHistoryID = 1, OrderID = 1, StatusTypeID = 1, UpdatedDateTime = new DateTime(2023, 2, 1, 12, 0, 0), Notes = "Order placed", Order = null!, StatusType = null! },
               //     new OrderStatusHistory { OrderStatusHistoryID = 2, OrderID = 2, StatusTypeID = 1, UpdatedDateTime = new DateTime(2023, 2, 2, 12, 0, 0), Notes = "Order placed", Order = null!, StatusType = null! },
               //     new OrderStatusHistory { OrderStatusHistoryID = 3, OrderID = 3, StatusTypeID = 1, UpdatedDateTime = new DateTime(2023, 2, 3, 12, 0, 0), Notes = "Order placed", Order = null!, StatusType = null! },
               //     new OrderStatusHistory { OrderStatusHistoryID = 4, OrderID = 4, StatusTypeID = 1, UpdatedDateTime = new DateTime(2023, 2, 4, 12, 0, 0), Notes = "Order placed", Order = null!, StatusType = null! },
               //     new OrderStatusHistory { OrderStatusHistoryID = 5, OrderID = 5, StatusTypeID = 1, UpdatedDateTime = new DateTime(2023, 2, 5, 12, 0, 0), Notes = "Order placed", Order = null!, StatusType = null! }
               // );
            });

            // PackedItem
            modelBuilder.Entity<PackedItem>(entity =>
            {
                entity.HasKey(e => e.PackedItemID);
                entity.Property(e => e.QuantityPacked).IsRequired();
                entity.HasOne(pi => pi.PackingDetails)
                      .WithMany(pd => pd.PackedItems)
                      .HasForeignKey(pi => pi.PackingID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(pi => pi.OrderItem)
                      .WithMany()
                      .HasForeignKey(pi => pi.OrderItemID)
                      .OnDelete(DeleteBehavior.Restrict);
                // entity.HasData(
                //     new PackedItem { PackedItemID = 1, PackingID = 1, OrderItemID = 1, QuantityPacked = 2, Notes = "Packed", PackingDetails = null!, OrderItem = null! },
                //     new PackedItem { PackedItemID = 2, PackingID = 2, OrderItemID = 2, QuantityPacked = 1, Notes = "Packed", PackingDetails = null!, OrderItem = null! },
                //     new PackedItem { PackedItemID = 3, PackingID = 3, OrderItemID = 3, QuantityPacked = 3, Notes = "Packed", PackingDetails = null!, OrderItem = null! },
                //     new PackedItem { PackedItemID = 4, PackingID = 4, OrderItemID = 4, QuantityPacked = 1, Notes = "Packed", PackingDetails = null!, OrderItem = null! },
                //     new PackedItem { PackedItemID = 5, PackingID = 5, OrderItemID = 5, QuantityPacked = 2, Notes = "Packed", PackingDetails = null!, OrderItem = null! }
                // );
            });

            // PackingDetails
            modelBuilder.Entity<PackingDetails>(entity =>
            {
                entity.HasKey(e => e.PackingID);
                entity.HasOne(pd => pd.Order)
                      .WithMany()
                      .HasForeignKey(pd => pd.OrderID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(pd => pd.PackedByUser)
                      .WithMany()
                      .HasForeignKey(pd => pd.PackedByUserID)
                      .OnDelete(DeleteBehavior.Restrict);
              //  entity.HasData(
              //      new PackingDetails { PackingID = 1, OrderID = 1, PackedByUserID = 1, StartPackingTime = new DateTime(2023, 2, 1, 12, 30, 0), EndPackingTime = new DateTime(2023, 2, 1, 12, 45, 0), TotalPackedItems = 2, Order = null!, PackedByUser = null! },
              //      new PackingDetails { PackingID = 2, OrderID = 2, PackedByUserID = 2, StartPackingTime = new DateTime(2023, 2, 2, 13, 0, 0), EndPackingTime = new DateTime(2023, 2, 2, 13, 15, 0), TotalPackedItems = 1, Order = null!, PackedByUser = null! },
              //      new PackingDetails { PackingID = 3, OrderID = 3, PackedByUserID = 3, StartPackingTime = new DateTime(2023, 2, 3, 14, 0, 0), EndPackingTime = new DateTime(2023, 2, 3, 14, 20, 0), TotalPackedItems = 3, Order = null!, PackedByUser = null! },
              //      new PackingDetails { PackingID = 4, OrderID = 4, PackedByUserID = 4, StartPackingTime = new DateTime(2023, 2, 4, 15, 0, 0), EndPackingTime = new DateTime(2023, 2, 4, 15, 30, 0), TotalPackedItems = 1, Order = null!, PackedByUser = null! },
              //      new PackingDetails { PackingID = 5, OrderID = 5, PackedByUserID = 5, StartPackingTime = new DateTime(2023, 2, 5, 16, 0, 0), EndPackingTime = new DateTime(2023, 2, 5, 16, 25, 0), TotalPackedItems = 2, Order = null!, PackedByUser = null! }
              //  );
            });


            // PhoneType
            modelBuilder.Entity<PhoneType>(entity =>
            {
                entity.HasKey(e => e.PhoneTypeID);
                entity.Property(e => e.TypeName).IsRequired();
                entity.HasData(
                    new PhoneType (1, "Home"),
                    new PhoneType (2, "Mobile"),
                    new PhoneType (3, "Work"),
                    new PhoneType (4, "Fax"),
                    new PhoneType (5, "Other")
                );
            });

            // OrderType
            modelBuilder.Entity<OrderType>(entity =>
            {
                entity.HasKey(e => e.OrderTypeID);
                entity.Property(e => e.TypeName).IsRequired();
                entity.HasData(
                    new OrderType (1, "Dine-In"),
                    new OrderType (2, "Pickup"),
                    new OrderType (3, "Delivery"),
                    new OrderType (4, "Catering"),
                    new OrderType (5, "Online")
                );
            });

            // Recipe
            modelBuilder.Entity<Recipe>(entity =>
            {
                entity.HasKey(e => e.RecipeID);
                entity.Property(e => e.RecipeName).IsRequired();
                entity.Property(e => e.EstimatedPrepTimeMinutes).HasColumnType("decimal(10,2)");
                entity.Property(e => e.EstimatedCost).HasColumnType("decimal(10,2)");
                entity.Property(e => e.ServingSize).IsRequired();
                entity.Property(e => e.DateCreated).IsRequired();
                entity.HasOne(r => r.User)
                      .WithMany(u => u.Recipes)
                      .HasForeignKey(r => r.UserID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasMany(r => r.RecipeIngredients)
                      .WithOne(ri => ri.Recipe)
                      .HasForeignKey(ri => ri.RecipeID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasMany(r => r.RecipeEquipment)
                      .WithOne(re => re.Recipe)
                      .HasForeignKey(re => re.RecipeID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasMany(r => r.RecipeSteps)
                      .WithOne(rs => rs.Recipe)
                      .HasForeignKey(rs => rs.RecipeID)
                      .OnDelete(DeleteBehavior.Restrict);
                //entity.HasData(
                //    new Recipe { RecipeID = 1, RecipeName = "Grilled Chicken", Instructions = "Season and grill", EstimatedPrepTimeMinutes = 30m, EstimatedCost = 7.50m, ServingSize = 4, DateCreated = new DateTime(2023, 1, 20), UserID = 1, User = null! },
                //    new Recipe { RecipeID = 2, RecipeName = "Cheesy Pasta", Instructions = "Boil and mix", EstimatedPrepTimeMinutes = 25m, EstimatedCost = 5.00m, ServingSize = 3, DateCreated = new DateTime(2023, 1, 21), UserID = 2, User = null! },
                //    new Recipe { RecipeID = 3, RecipeName = "Veggie Salad", Instructions = "Chop and toss", EstimatedPrepTimeMinutes = 15m, EstimatedCost = 4.00m, ServingSize = 2, DateCreated = new DateTime(2023, 1, 22), UserID = 3, User = null! },
                //    new Recipe { RecipeID = 4, RecipeName = "Fried Rice", Instructions = "Stir-fry", EstimatedPrepTimeMinutes = 20m, EstimatedCost = 6.00m, ServingSize = 5, DateCreated = new DateTime(2023, 1, 23), UserID = 4, User = null! },
                //    new Recipe { RecipeID = 5, RecipeName = "Apple Pie", Instructions = "Bake the pie", EstimatedPrepTimeMinutes = 45m, EstimatedCost = 8.00m, ServingSize = 6, DateCreated = new DateTime(2023, 1, 24), UserID = 5, User = null! }
                //);
            });

            // RecipeEquipment
            modelBuilder.Entity<RecipeEquipment>(entity =>
            {
                entity.HasKey(e => e.RecipeEquipmentID);
                entity.HasOne(re => re.Recipe)
                      .WithMany(r => r.RecipeEquipment)
                      .HasForeignKey(re => re.RecipeID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(re => re.Equipment)
                      .WithMany(e => e.RecipeEquipment)
                      .HasForeignKey(re => re.EquipmentID)
                      .OnDelete(DeleteBehavior.Restrict);
                //entity.HasData(
                //    new RecipeEquipment { RecipeEquipmentID = 1, RecipeID = 1, EquipmentID = 1, Notes = "Use oven", Recipe = null!, Equipment = null! },
                //    new RecipeEquipment { RecipeEquipmentID = 2, RecipeID = 2, EquipmentID = 2, Notes = "Use grill", Recipe = null!, Equipment = null! },
                //    new RecipeEquipment { RecipeEquipmentID = 3, RecipeID = 3, EquipmentID = 3, Notes = "Use mixer", Recipe = null!, Equipment = null! },
                //    new RecipeEquipment { RecipeEquipmentID = 4, RecipeID = 4, EquipmentID = 4, Notes = "Use blender", Recipe = null!, Equipment = null! },
                //    new RecipeEquipment { RecipeEquipmentID = 5, RecipeID = 5, EquipmentID = 5, Notes = "Use toaster", Recipe = null!, Equipment = null! }
                //);
            });

            // RecipeIngredient
            modelBuilder.Entity<RecipeIngredient>(entity =>
            {
                entity.HasKey(e => e.RecipeIngredientID);
                entity.Property(e => e.QuantityRequired).HasColumnType("decimal(10,2)");
                entity.Property(e => e.NeedsReorder).HasDefaultValue(false);
                entity.HasOne(ri => ri.Recipe)
                      .WithMany(r => r.RecipeIngredients)
                      .HasForeignKey(ri => ri.RecipeID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne<Inventory>()
                      .WithMany()
                      .HasForeignKey(ri => ri.InventoryID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne<MeasurementUnit>()
                      .WithMany()
                      .HasForeignKey(ri => ri.MeasurementUnitID)
                      .OnDelete(DeleteBehavior.Restrict);
                //entity.HasData(
                //    new RecipeIngredient { RecipeIngredientID = 1, RecipeID = 1, InventoryID = 1, QuantityRequired = 2m, MeasurementUnitID = 1, CodeID = "RI001", NeedsReorder = false, Recipe = null! },
                //    new RecipeIngredient { RecipeIngredientID = 2, RecipeID = 2, InventoryID = 2, QuantityRequired = 1m, MeasurementUnitID = 2, CodeID = "RI002", NeedsReorder = false, Recipe = null! },
                //    new RecipeIngredient { RecipeIngredientID = 3, RecipeID = 3, InventoryID = 3, QuantityRequired = 1.5m, MeasurementUnitID = 3, CodeID = "RI003", NeedsReorder = false, Recipe = null! },
                //    new RecipeIngredient { RecipeIngredientID = 4, RecipeID = 4, InventoryID = 4, QuantityRequired = 2m, MeasurementUnitID = 4, CodeID = "RI004", NeedsReorder = false, Recipe = null! },
                //    new RecipeIngredient { RecipeIngredientID = 5, RecipeID = 5, InventoryID = 5, QuantityRequired = 3m, MeasurementUnitID = 5, CodeID = "RI005", NeedsReorder = false, Recipe = null! }
                //);
            });

            // RecipeStep
            modelBuilder.Entity<RecipeStep>(entity =>
            {
                entity.HasKey(e => e.RecipeStepID);
                entity.Property(e => e.Description).IsRequired();
                entity.Property(e => e.EstimatedTimeMinutes).HasColumnType("decimal(10,2)");
                entity.Property(e => e.EstimatedCost).HasColumnType("decimal(10,2)");
                entity.HasOne(rs => rs.Recipe)
                      .WithMany(r => r.RecipeSteps)
                      .HasForeignKey(rs => rs.RecipeID)
                      .OnDelete(DeleteBehavior.Restrict);
                //entity.HasData(
                //    new RecipeStep { RecipeStepID = 1, RecipeID = 1, StepNumber = 1, Description = "Preheat oven", EstimatedTimeMinutes = 5m, EstimatedCost = 0.50m, AdditionalNotes = "", Recipe = null! },
                //    new RecipeStep { RecipeStepID = 2, RecipeID = 1, StepNumber = 2, Description = "Season chicken", EstimatedTimeMinutes = 10m, EstimatedCost = 1.00m, AdditionalNotes = "", Recipe = null! },
                //    new RecipeStep { RecipeStepID = 3, RecipeID = 1, StepNumber = 3, Description = "Grill chicken", EstimatedTimeMinutes = 15m, EstimatedCost = 2.00m, AdditionalNotes = "", Recipe = null! },
                //    new RecipeStep { RecipeStepID = 4, RecipeID = 1, StepNumber = 4, Description = "Rest chicken", EstimatedTimeMinutes = 5m, EstimatedCost = 0.50m, AdditionalNotes = "", Recipe = null! },
                //    new RecipeStep { RecipeStepID = 5, RecipeID = 1, StepNumber = 5, Description = "Plate dish", EstimatedTimeMinutes = 5m, EstimatedCost = 0.50m, AdditionalNotes = "", Recipe = null! }
                //);
            });

            // RecipeStepLog
            modelBuilder.Entity<RecipeStepLog>(entity =>
            {
                entity.HasKey(e => e.RecipeStepLogID);
                entity.Property(e => e.ActualTimeMinutes).HasColumnType("decimal(10,2)");
                entity.Property(e => e.ActualCost).HasColumnType("decimal(10,2)");
                entity.HasOne(rsl => rsl.RecipeStep)
                      .WithMany()
                      .HasForeignKey(rsl => rsl.RecipeStepID)
                      .OnDelete(DeleteBehavior.Restrict);
                //entity.HasData(
                //    new RecipeStepLog { RecipeStepLogID = 1, RecipeStepID = 1, ExecutionDate = new DateTime(2023, 2, 1, 10, 0, 0), ActualTimeMinutes = 5m, ActualCost = 0.50m, ExecutedByUserID = 1, Comments = "On time", RecipeStep = null! },
                //    new RecipeStepLog { RecipeStepLogID = 2, RecipeStepID = 2, ExecutionDate = new DateTime(2023, 2, 1, 10, 10, 0), ActualTimeMinutes = 10m, ActualCost = 1.00m, ExecutedByUserID = 1, Comments = "Perfect", RecipeStep = null! },
                //    new RecipeStepLog { RecipeStepLogID = 3, RecipeStepID = 3, ExecutionDate = new DateTime(2023, 2, 1, 10, 20, 0), ActualTimeMinutes = 15m, ActualCost = 2.00m, ExecutedByUserID = 1, Comments = "Slight delay", RecipeStep = null! },
                //    new RecipeStepLog { RecipeStepLogID = 4, RecipeStepID = 4, ExecutionDate = new DateTime(2023, 2, 1, 10, 35, 0), ActualTimeMinutes = 5m, ActualCost = 0.50m, ExecutedByUserID = 1, Comments = "On time", RecipeStep = null! },
                //    new RecipeStepLog { RecipeStepLogID = 5, RecipeStepID = 5, ExecutionDate = new DateTime(2023, 2, 1, 10, 45, 0), ActualTimeMinutes = 5m, ActualCost = 0.50m, ExecutedByUserID = 1, Comments = "Smooth", RecipeStep = null! }
                //);
            });

            // Role
            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.RoleID);
                entity.Property(e => e.RoleName).IsRequired();
                entity.HasData(
                    new Role (1, "Admin"),
                    new Role (2, "Manager"),
                    new Role (3, "Employee"),
                    new Role (4, "Supervisor"),
                    new Role (5, "Guest")
                );
            });

            // Room
            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(e => e.RoomID);
                entity.Property(e => e.RoomName).IsRequired();
                entity.HasMany(r => r.StorageLocations)
                      .WithOne(sl => sl.Room)
                      .HasForeignKey(sl => sl.RoomID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(r => r.ScannableLabel)
                      .WithMany()
                      .HasForeignKey(r => r.ScannableLabelID)
                      .OnDelete(DeleteBehavior.Restrict);
                //entity.HasData(
                //    new Room { RoomID = 1, RoomName = "Main Dining", ScannableLabelID = 1, ScannableLabel = null! },
                //    new Room { RoomID = 2, RoomName = "Patio", ScannableLabelID = 2, ScannableLabel = null! },
                //    new Room { RoomID = 3, RoomName = "Private Dining", ScannableLabelID = 3, ScannableLabel = null! },
                //    new Room { RoomID = 4, RoomName = "Outdoor", ScannableLabelID = 4, ScannableLabel = null! },
                //    new Room { RoomID = 5, RoomName = "VIP Lounge", ScannableLabelID = 5, ScannableLabel = null! }
                //);
            });

            // ScannableLabel
            modelBuilder.Entity<ScannableLabel>(entity =>
            {
                entity.HasKey(e => e.LabelID);
                entity.Property(e => e.BarcodeValue).IsRequired();
                entity.Property(e => e.LabelType).IsRequired();
                //entity.HasData(
                //    new ScannableLabel { LabelID = 1, BarcodeValue = "LBL001", LabelType = "Room" },
                //    new ScannableLabel { LabelID = 2, BarcodeValue = "LBL002", LabelType = "Room" },
                //    new ScannableLabel { LabelID = 3, BarcodeValue = "LBL003", LabelType = "Room" },
                //    new ScannableLabel { LabelID = 4, BarcodeValue = "LBL004", LabelType = "Room" },
                //    new ScannableLabel { LabelID = 5, BarcodeValue = "LBL005", LabelType = "Room" }
                //);
            });

            // Shipping
            modelBuilder.Entity<Shipping>(entity =>
            {
                entity.HasKey(e => e.ShippingID);
                entity.Property(e => e.TrackingNumber).IsRequired();
                entity.Property(e => e.ShippingCost).HasColumnType("decimal(10,2)");
                entity.HasOne(s => s.Order)
                      .WithMany()
                      .HasForeignKey(s => s.OrderID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(s => s.ShippingMethodType)
                      .WithMany()
                      .HasForeignKey(s => s.ShippingMethodTypeID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(s => s.StatusType)
                      .WithMany()
                      .HasForeignKey(s => s.StatusTypeID)
                      .OnDelete(DeleteBehavior.Restrict);
                //entity.HasData(
                //    new Shipping { ShippingID = 1, OrderID = 2, ShippingMethodTypeID = 1, TrackingNumber = "TRK001", ShippingDate = new DateTime(2023, 2, 2, 14, 0, 0), ExpectedDeliveryDate = new DateTime(2023, 2, 3, 18, 0, 0), ShippingCost = 5.00m, StatusTypeID = 2, Order = null!, ShippingMethodType = null!, StatusType = null! },
                //    new Shipping { ShippingID = 2, OrderID = 4, ShippingMethodTypeID = 2, TrackingNumber = "TRK002", ShippingDate = new DateTime(2023, 2, 4, 15, 0, 0), ExpectedDeliveryDate = new DateTime(2023, 2, 5, 20, 0, 0), ShippingCost = 7.50m, StatusTypeID = 2, Order = null!, ShippingMethodType = null!, StatusType = null! },
                //    new Shipping { ShippingID = 3, OrderID = 2, ShippingMethodTypeID = 3, TrackingNumber = "TRK003", ShippingDate = new DateTime(2023, 2, 2, 16, 0, 0), ExpectedDeliveryDate = new DateTime(2023, 2, 2, 20, 0, 0), ShippingCost = 10.00m, StatusTypeID = 1, Order = null!, ShippingMethodType = null!, StatusType = null! },
                //    new Shipping { ShippingID = 4, OrderID = 4, ShippingMethodTypeID = 4, TrackingNumber = "TRK004", ShippingDate = new DateTime(2023, 2, 4, 16, 0, 0), ExpectedDeliveryDate = new DateTime(2023, 2, 5, 16, 0, 0), ShippingCost = 6.00m, StatusTypeID = 3, Order = null!, ShippingMethodType = null!, StatusType = null! },
                //    new Shipping { ShippingID = 5, OrderID = 2, ShippingMethodTypeID = 5, TrackingNumber = "TRK005", ShippingDate = new DateTime(2023, 2, 2, 17, 0, 0), ExpectedDeliveryDate = new DateTime(2023, 2, 3, 9, 0, 0), ShippingCost = 12.00m, StatusTypeID = 5, Order = null!, ShippingMethodType = null!, StatusType = null! }
                //);
            });

            // ShippingMethodType
            modelBuilder.Entity<ShippingMethodType>(entity =>
            {
                entity.HasKey(e => e.ShippingMethodTypeID);
                entity.Property(e => e.MethodName).IsRequired();
                entity.HasData(
                    new ShippingMethodType (1, "Air"),
                    new ShippingMethodType (2, "Ground"),
                    new ShippingMethodType (3, "Express"),
                    new ShippingMethodType (4, "Standard"),
                    new ShippingMethodType (5, "Overnight")
                );
            });

            // SpecialOrderDetail
            modelBuilder.Entity<SpecialOrderDetail>(entity =>
            {
                entity.HasKey(e => e.SpecialOrderDetailID);
                entity.Property(e => e.Quantity).HasColumnType("decimal(10,2)");
                entity.Property(e => e.ModificationCost).HasColumnType("decimal(10,2)");
                entity.HasOne(sod => sod.Order)
                      .WithMany()
                      .HasForeignKey(sod => sod.OrderID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(sod => sod.Inventory)
                      .WithMany()
                      .HasForeignKey(sod => sod.InventoryID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(sod => sod.ModificationType)
                      .WithMany()
                      .HasForeignKey(sod => sod.ModificationTypeID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne<MeasurementUnit>()
                      .WithMany()
                      .HasForeignKey(sod => sod.MeasurementUnitID)
                      .OnDelete(DeleteBehavior.Restrict);
                //entity.HasData(
                //    new SpecialOrderDetail { SpecialOrderDetailID = 1, OrderID = 1, InventoryID = 1, ModificationTypeID = 1, Quantity = 0.5m, MeasurementUnitID = 1, ModificationCost = 1.00m, Notes = "Extra sauce", Order = null!, Inventory = null!, ModificationType = null! },
                //    new SpecialOrderDetail { SpecialOrderDetailID = 2, OrderID = 2, InventoryID = 2, ModificationTypeID = 2, Quantity = 0.25m, MeasurementUnitID = 1, ModificationCost = 0.50m, Notes = "No salt", Order = null!, Inventory = null!, ModificationType = null! },
                //    new SpecialOrderDetail { SpecialOrderDetailID = 3, OrderID = 3, InventoryID = 3, ModificationTypeID = 3, Quantity = 1.0m, MeasurementUnitID = 2, ModificationCost = 0.75m, Notes = "Gluten-free", Order = null!, Inventory = null!, ModificationType = null! },
                //    new SpecialOrderDetail { SpecialOrderDetailID = 4, OrderID = 4, InventoryID = 4, ModificationTypeID = 4, Quantity = 0.5m, MeasurementUnitID = 1, ModificationCost = 1.25m, Notes = "Extra cheese", Order = null!, Inventory = null!, ModificationType = null! },
                //    new SpecialOrderDetail { SpecialOrderDetailID = 5, OrderID = 5, InventoryID = 5, ModificationTypeID = 5, Quantity = 2.0m, MeasurementUnitID = 2, ModificationCost = 1.50m, Notes = "Spicy", Order = null!, Inventory = null!, ModificationType = null! }
                //);
            });


            // StatusType
            modelBuilder.Entity<StatusType>(entity =>
            {
                entity.HasKey(e => e.StatusTypeID);
                entity.Property(e => e.StatusName).IsRequired();
                entity.HasData(
                    new StatusType (1, "Pending"),
                    new StatusType (2, "Processing"),
                    new StatusType (3, "Shipped"),
                    new StatusType (4, "Delivered"),
                    new StatusType (5, "Cancelled")
                );
            });

            // StorageLocation
            modelBuilder.Entity<StorageLocation>(entity =>
            {
                entity.HasKey(e => e.StorageLocationID);
                entity.HasOne(sl => sl.Room)
                      .WithMany(r => r.StorageLocations)
                      .HasForeignKey(sl => sl.RoomID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(sl => sl.Location)
                      .WithMany(l => l.StorageLocations)
                      .HasForeignKey(sl => sl.LocationID)
                      .OnDelete(DeleteBehavior.Restrict);
                //entity.HasData(
                //    new StorageLocation { StorageLocationID = 1, RoomID = 1, LocationID = 1, Room = null!, Location = null! },
                //    new StorageLocation { StorageLocationID = 2, RoomID = 2, LocationID = 2, Room = null!, Location = null! },
                //    new StorageLocation { StorageLocationID = 3, RoomID = 3, LocationID = 3, Room = null!, Location = null! },
                //    new StorageLocation { StorageLocationID = 4, RoomID = 4, LocationID = 4, Room = null!, Location = null! },
                //    new StorageLocation { StorageLocationID = 5, RoomID = 5, LocationID = 5, Room = null!, Location = null! }
                //);
            });

            // Table
            modelBuilder.Entity<Table>(entity =>
            {
                entity.HasKey(e => e.TableID);
                entity.Property(e => e.TableName).IsRequired();
                entity.Property(e => e.SeatCapacity).IsRequired();
                entity.Property(e => e.IsCombinable).HasDefaultValue(false);
                entity.Property(e => e.IsAvailable).HasDefaultValue(true);
                entity.HasMany(t => t.PrimaryTableCombinations)
                      .WithOne(tc => tc.Table)
                      .HasForeignKey(tc => tc.TableID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasMany(t => t.CombinedWithTableCombinations)
                      .WithOne(tc => tc.CombinedWithTable)
                      .HasForeignKey(tc => tc.CombinedWithTableID)
                      .OnDelete(DeleteBehavior.Restrict);
                //entity.HasData(
                //    new Table { TableID = 1, TableName = "Table 1", SeatCapacity = 4, IsCombinable = true, IsAvailable = true },
                //    new Table { TableID = 2, TableName = "Table 2", SeatCapacity = 2, IsCombinable = true, IsAvailable = true },
                //    new Table { TableID = 3, TableName = "Table 3", SeatCapacity = 6, IsCombinable = true, IsAvailable = true },
                //    new Table { TableID = 4, TableName = "Table 4", SeatCapacity = 4, IsCombinable = false, IsAvailable = true },
                //    new Table { TableID = 5, TableName = "Table 5", SeatCapacity = 8, IsCombinable = true, IsAvailable = true }
                //);
            });

            // TableCombination
            modelBuilder.Entity<TableCombination>(entity =>
            {
                entity.HasKey(e => e.TableComboID);
                entity.HasOne(tc => tc.Table)
                      .WithMany(t => t.PrimaryTableCombinations)
                      .HasForeignKey(tc => tc.TableID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(tc => tc.CombinedWithTable)
                      .WithMany(t => t.CombinedWithTableCombinations)
                      .HasForeignKey(tc => tc.CombinedWithTableID)
                      .OnDelete(DeleteBehavior.Restrict);
                //entity.HasData(
                //    new TableCombination { TableComboID = 1, TableID = 1, CombinedWithTableID = 2, Table = null!, CombinedWithTable = null! },
                //    new TableCombination { TableComboID = 2, TableID = 2, CombinedWithTableID = 3, Table = null!, CombinedWithTable = null! },
                //    new TableCombination { TableComboID = 3, TableID = 3, CombinedWithTableID = 4, Table = null!, CombinedWithTable = null! },
                //    new TableCombination { TableComboID = 4, TableID = 4, CombinedWithTableID = 5, Table = null!, CombinedWithTable = null! },
                //    new TableCombination { TableComboID = 5, TableID = 1, CombinedWithTableID = 3, Table = null!, CombinedWithTable = null! }
                //);
            });

            // User
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserID);
                entity.Property(e => e.Username).IsRequired();
                entity.Property(e => e.PasswordHash).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.DateCreated).IsRequired();
                entity.HasOne(u => u.Role)
                      .WithMany(r => r.Users)
                      .HasForeignKey(u => u.RoleID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasMany(u => u.Orders)
                      .WithOne(o => o.User)
                      .HasForeignKey(o => o.UserID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasMany(u => u.Recipes)
                      .WithOne(r => r.User)
                      .HasForeignKey(r => r.UserID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasMany(u => u.Employees)
                      .WithOne(e => e.User)
                      .HasForeignKey(e => e.UserID)
                      .OnDelete(DeleteBehavior.Restrict);
                //entity.HasData(
                //    new User { UserID = 1, Username = "user1", PasswordHash = "hash1", Email = "user1@example.com", DateCreated = new DateTime(2023, 1, 1), RoleID = 1, Role = null!, Orders = null!, Recipes = null!, Employees = null! },
                //    new User { UserID = 2, Username = "user2", PasswordHash = "hash2", Email = "user2@example.com", DateCreated = new DateTime(2023, 1, 2), RoleID = 2, Role = null!, Orders = null!, Recipes = null!, Employees = null! },
                //    new User { UserID = 3, Username = "user3", PasswordHash = "hash3", Email = "user3@example.com", DateCreated = new DateTime(2023, 1, 3), RoleID = 3, Role = null!, Orders = null!, Recipes = null!, Employees = null! },
                //    new User { UserID = 4, Username = "user4", PasswordHash = "hash4", Email = "user4@example.com", DateCreated = new DateTime(2023, 1, 4), RoleID = 4, Role = null!, Orders = null!, Recipes = null!, Employees = null! },
                //    new User { UserID = 5, Username = "user5", PasswordHash = "hash5", Email = "user5@example.com", DateCreated = new DateTime(2023, 1, 5), RoleID = 5, Role = null!, Orders = null!, Recipes = null!, Employees = null! }
                //);
            });

        }
    }
}
