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
            // Article Configuration
            modelBuilder.Entity<Article>(entity =>
            {
                entity.HasKey(e => e.idArticle);
                entity.HasMany(e => e.PurchaseDetails);

                entity.HasOne(e => e.Familly)
                    .WithMany(e => e.Article)
                    .HasForeignKey(e => e.FamilyID)
                    .OnDelete(DeleteBehavior.SetNull);



                entity.HasOne(e => e.Brand)
                    .WithMany(e => e.Article)
                    .HasForeignKey(e => e.BrandID)
                    .OnDelete(DeleteBehavior.SetNull);
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasKey(e => e.BrandID);
                entity.HasMany(e => e.Article);

                entity.HasOne(e => e.Familly)
                    .WithMany(e => e.Brand)
                    .HasForeignKey(e => e.idFamilly)
                    .OnDelete(DeleteBehavior.SetNull);
            });
            modelBuilder.Entity<Familly>(entity =>
            {
                entity.HasKey(e => e.idFamilly);
                entity.HasMany(e => e.Article);
                entity.HasMany(e => e.Brand);
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

            });
            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasKey(c => c.idSupplier);
                entity.HasOne(c => c.Country)
                .WithMany(c => c.Supplier)
                .HasForeignKey(c => c.CountryId)

        .OnDelete(DeleteBehavior.SetNull);
            });

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.HasKey(c => c.IdPurchase);
                entity.HasMany(c => c.PurchaseDetails);
                entity.HasOne(c => c.Supplier)
                .WithMany(c => c.Purchase)
                .HasForeignKey(c => c.idSupplier)

        .OnDelete(DeleteBehavior.SetNull);

                entity.HasOne(c => c.Currencyobj)
                .WithMany(c => c.Purchases)
                .HasForeignKey(c => c.IdCurrency)

        .OnDelete(DeleteBehavior.SetNull);
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
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasKey(c => c.IdCurrency);
                entity.HasMany(c => c.Purchases);
            });

        }

        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseDetails> PurchaseDetails { get; set; }
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
    }
}
