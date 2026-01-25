using ERP_Anass_backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace ERP_Anass_backend
{
    public class DbContextERP : DbContext
    {
        public DbContextERP(DbContextOptions<DbContextERP> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>(entity =>
            {
                entity.HasKey(e => e.idArticle);
                entity.HasMany(e => e.PurchaseDetails);
                entity.HasMany(e => e.SaleDetails);

                entity.HasOne(e => e.Familly)
                    .WithMany(e => e.Article)
                    .HasForeignKey(e => e.FamilyID)
                    .HasConstraintName("FK_Article_Familly_FamilyID")
                    .OnDelete(DeleteBehavior.SetNull);

                entity.HasOne(e => e.Brand)
                    .WithMany(e => e.Article)
                    .HasForeignKey(e => e.BrandID)
                    .HasConstraintName("FK_Article_Brand_BrandID")
                    .OnDelete(DeleteBehavior.SetNull);

                entity.HasOne(e => e.IncomeAccount)
                    .WithMany()
                    .HasForeignKey(e => e.idIncomeAccount)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.InventoryAccount)
                    .WithMany()
                    .HasForeignKey(e => e.idInventoryAccount)
                    .OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.Entity<Familly>(entity =>
            {
                entity.HasKey(e => e.idFamilly);
                entity.HasMany(e => e.Article);
                entity.HasMany(e => e.Brand);
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.HasKey(e => e.idWarehouse);
                entity.HasMany(e => e.StockMovements)
                    .WithOne(e => e.Warehouse)
                    .HasForeignKey(e => e.WarehouseID)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<StockMovement>(entity =>
            {
                entity.HasKey(e => e.idStockMovement);

                entity.HasOne(e => e.Article)
                    .WithMany()
                    .HasForeignKey(e => e.ArticleID)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.Warehouse)
                    .WithMany(w => w.StockMovements)
                    .HasForeignKey(e => e.WarehouseID)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.idAccount);
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.idPayment);

                entity.HasOne(e => e.Sale)
                    .WithMany()
                    .HasForeignKey(e => e.SaleId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.Purchase)
                    .WithMany()
                    .HasForeignKey(e => e.PurchaseId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.CashAccount)
                    .WithMany()
                    .HasForeignKey(e => e.idCashAccount)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Tenant>(entity =>
            {
                entity.HasKey(e => e.idTenant);
            });

            modelBuilder.Entity<ModuleLicense>(entity =>
            {
                entity.HasKey(e => e.idModuleLicense);
            });

             modelBuilder.Entity<AppConfiguration>(entity =>
            {
                entity.HasKey(e => e.idAppConfiguration);
            });

            modelBuilder.Entity<UnitOfMeasure>(entity =>
            {
                entity.HasKey(e => e.idUom);
            });

            modelBuilder.Entity<BillOfMaterials>(entity =>
            {
                entity.HasKey(e => e.idBOM);

                entity.HasOne(e => e.ParentArticle)
                    .WithMany()
                    .HasForeignKey(e => e.ParentArticleId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.ChildArticle)
                    .WithMany()
                    .HasForeignKey(e => e.ChildArticleId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<JournalEntry>(entity =>
            {
                entity.HasKey(e => e.idJournalEntry);
                entity.HasMany(e => e.JournalDetails)
                    .WithOne(d => d.JournalEntry)
                    .HasForeignKey(d => d.JournalEntryID)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<JournalDetails>(entity =>
            {
                entity.HasKey(e => e.idJournalDetails);
                
                entity.HasOne(e => e.Account)
                    .WithMany()
                    .HasForeignKey(e => e.AccountID)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Permission Configuration
            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasKey(e => e.IdPermission);

                entity.HasOne(e => e.User)
                    .WithMany(e => e.Permission)
                    .HasForeignKey(e => e.UserId)
                    .OnDelete(DeleteBehavior.SetNull);

                entity.HasOne(e => e.Modules)
                    .WithMany(e => e.Permission)
                    .HasForeignKey(e => e.IdModule)
                    .OnDelete(DeleteBehavior.SetNull);
            });

            // User Configuration
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserID);
                entity.HasMany(e => e.Permission);
            });

            // Modules Configuration
            modelBuilder.Entity<Modules>(entity =>
            {
                entity.HasKey(e => e.IdModule);
                entity.HasMany(e => e.Permission);
            });
            modelBuilder.Entity<City>(entity =>
            {
                entity.HasKey(c => c.CityID);
                entity.HasMany(c => c.Employees);
                entity.HasMany(c => c.Supplier);
                entity.HasMany(c => c.Customer);
                entity.HasOne(c => c.Country)
                .WithMany(c => c.City)
                .HasForeignKey(c => c.CountryId)
                .OnDelete(DeleteBehavior.SetNull);
            });
            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(c => c.CountryId);
                entity.HasMany(c => c.City);
                entity.HasMany(c => c.Supplier);
                entity.HasMany(c => c.Customer);
                entity.HasMany(c => c.Employees);
            });
            modelBuilder.Entity<Works>(entity =>
            {
                entity.HasKey(c => c.WorkstID);

                // Relation Many-to-One entre Works et Department
                entity.HasOne(c => c.Department)
                      .WithMany(c => c.Work) // Un département a plusieurs works
                      .HasForeignKey(c => c.DepartmentID)
                      .OnDelete(DeleteBehavior.SetNull);

                // Relation One-to-Many entre Works et Employees
                entity.HasMany(c => c.Employees)
                      .WithOne(e => e.Works) // Un employé appartient à un work
                      .HasForeignKey(e => e.WorksID)
                      .OnDelete(DeleteBehavior.SetNull);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(c => c.DepartmentID);
                entity.HasMany(c => c.Employees);
                entity.HasMany(c => c.Work);

            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(c => c.EmployeeID);

                // Relation Many-to-One entre Employee et Department
                entity.HasOne(c => c.Department)
                      .WithMany(d => d.Employees) // Un département a plusieurs employés
                      .HasForeignKey(c => c.DepartmentID)
                      .OnDelete(DeleteBehavior.SetNull);

                // Relation Many-to-One entre Employee et Works
                entity.HasOne(c => c.Works)
                      .WithMany(w => w.Employees) // Un work a plusieurs employés
                      .HasForeignKey(c => c.WorksID)
                      .OnDelete(DeleteBehavior.SetNull);

                // Relation Many-to-One entre Employee et Works
                entity.HasOne(c => c.City)
                      .WithMany(w => w.Employees) // Un city a plusieurs employés
                      .HasForeignKey(c => c.CityID)
                      .OnDelete(DeleteBehavior.SetNull);
                // Relation Many-to-One entre Employee et Works
                entity.HasOne(c => c.Country)
                      .WithMany(w => w.Employees) // Un city a plusieurs employés
                      .HasForeignKey(c => c.CountryId)
                      .OnDelete(DeleteBehavior.SetNull);

                entity.HasOne(c => c.ExpenseAccount)
                      .WithMany()
                      .HasForeignKey(c => c.idExpenseAccount)
                      .OnDelete(DeleteBehavior.Restrict);

            });
            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasKey(c => c.idSupplier);
                entity.HasOne(c => c.Country)
                .WithMany(c => c.Supplier)
                .HasForeignKey(c => c.CountryId)
                .OnDelete(DeleteBehavior.SetNull);

                entity.HasOne(c => c.City)
                .WithMany(c => c.Supplier)
                .HasForeignKey(c => c.CityID)
                .OnDelete(DeleteBehavior.SetNull);

                entity.HasOne(c => c.ControlAccount)
                .WithMany()
                .HasForeignKey(c => c.idControlAccount)
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(c => c.idCustomer);
                entity.HasMany(c => c.Sales);
                entity.HasOne(c => c.Country)
                .WithMany(c => c.Customer)
                .HasForeignKey(c => c.CountryId)
                .OnDelete(DeleteBehavior.SetNull);

                entity.HasOne(c => c.City)
                .WithMany(c => c.Customer)
                .HasForeignKey(c => c.CityID)
                .OnDelete(DeleteBehavior.SetNull);

                entity.HasOne(c => c.ControlAccount)
                .WithMany()
                .HasForeignKey(c => c.idControlAccount)
                .OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.HasKey(c => c.IdPurchase);
                entity.Property(c => c.IdPurchase).ValueGeneratedOnAdd();
                entity.HasMany(c => c.PurchaseDetails);
                
                entity.HasOne(c => c.Supplier)
                    .WithMany(c => c.Purchase)
                    .HasForeignKey(c => c.idSupplier)
                    .OnDelete(DeleteBehavior.SetNull);

                entity.HasOne(c => c.Currencyobj)
                    .WithMany(c => c.Purchases)
                    .HasForeignKey(c => c.IdCurrency)
                    .OnDelete(DeleteBehavior.SetNull);

                // Logistics
                entity.HasOne(c => c.Warehouse)
                    .WithMany()
                    .HasForeignKey(c => c.idWarehouse)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(c => c.Employee)
                    .WithMany()
                    .HasForeignKey(c => c.idEmployee)
                    .OnDelete(DeleteBehavior.Restrict);

                // Finance
                entity.HasOne(c => c.Invoice)
                    .WithMany()
                    .HasForeignKey(c => c.idInvoice)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(c => c.Account)
                    .WithMany()
                    .HasForeignKey(c => c.idAccount)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<PurchaseDetails>(entity =>
            {
                entity.HasKey(c => c.IdPurchaseDetails);
                
                entity.HasOne(c => c.Purchase)
                    .WithMany(c => c.PurchaseDetails)
                    .HasForeignKey(c => c.IdPurchase)
                    .OnDelete(DeleteBehavior.SetNull);
                    
                entity.HasOne(c => c.Article)
                    .WithMany(c => c.PurchaseDetails)
                    .HasForeignKey(c => c.idArticle)
                    .OnDelete(DeleteBehavior.SetNull);

                entity.HasOne(c => c.TaxConfig)
                    .WithMany()
                    .HasForeignKey(c => c.idTaxConfig)
                    .OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.Entity<Sale>(entity =>
                      {
                          entity.HasKey(c => c.IdSale);
                          entity.HasMany(c => c.SaleDetails);


                          entity.HasOne(c => c.Currencyobj)
                          .WithMany(c => c.Sales)
                          .HasForeignKey(c => c.IdCurrency)

                  .OnDelete(DeleteBehavior.SetNull);

                          entity.HasOne(c => c.Customerobj)
                          .WithMany(c => c.Sales)
                          .HasForeignKey(c => c.IdCustomer)

                  .OnDelete(DeleteBehavior.SetNull);
                      });

            modelBuilder.Entity<SaleDetails>(entity =>
            {
                entity.HasKey(c => c.IdSaleDetails);
                entity.HasOne(c => c.Sale)
                .WithMany(c => c.SaleDetails)
                .HasForeignKey(c => c.IdSale)

        .OnDelete(DeleteBehavior.SetNull);
                entity.HasOne(c => c.Article)
                .WithMany(c => c.SaleDetails)
                .HasForeignKey(c => c.idArticle)

                .OnDelete(DeleteBehavior.SetNull);
            });

            // Finance Module Configurations
            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasKey(e => e.idInvoice);

                entity.HasOne(e => e.Sale)
                    .WithMany()
                    .HasForeignKey(e => e.SaleId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.Customer)
                    .WithMany()
                    .HasForeignKey(e => e.CustomerId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.Purchase)
                    .WithMany()
                    .HasForeignKey(e => e.PurchaseId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.Supplier)
                    .WithMany()
                    .HasForeignKey(e => e.SupplierId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(e => e.InvoiceDetails)
                   .WithOne(d => d.Invoice)
                   .HasForeignKey(d => d.InvoiceId)
                   .OnDelete(DeleteBehavior.Cascade); 
            });

            modelBuilder.Entity<InvoiceDetails>(entity =>
            {
                entity.HasKey(e => e.idInvoiceDetail);

                entity.HasOne(e => e.Article)
                    .WithMany()
                    .HasForeignKey(e => e.ArticleId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<BankAccount>(entity =>
            {
                entity.HasKey(e => e.idBankAccount);
            });

        }

        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseDetails> PurchaseDetails { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<SaleDetails> SaleDetails { get; set; }
        public DbSet<Article> Article { get; set; }
        public DbSet<Familly> Familly { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Modules> Modules { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Works> Works { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<StockMovement> StockMovements { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<ModuleLicense> ModuleLicenses { get; set; }
        public DbSet<AppConfiguration> AppConfigurations { get; set; }
        public DbSet<UnitOfMeasure> UnitOfMeasures { get; set; }
        public DbSet<BillOfMaterials> BillOfMaterials { get; set; }
        public DbSet<JournalEntry> JournalEntries { get; set; }
        public DbSet<JournalDetails> JournalDetails { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetails> InvoiceDetails { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<TaxConfiguration> TaxConfigurations { get; set; }



    }
}
