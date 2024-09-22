using ERP_Anass_backend.Models;
using Microsoft.EntityFrameworkCore;

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
                entity.HasOne(e => e.Familly)
                    .WithMany(e => e.Article)
                    .HasForeignKey(e => e.FamilyID)
                    .OnDelete(DeleteBehavior.ClientCascade);
            });

            // Familly Configuration
            modelBuilder.Entity<Familly>(entity =>
            {
                entity.HasKey(e => e.idFamilly);
                entity.HasMany(e => e.Article);
            });

            // Permission Configuration
            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasKey(e => e.IdPermission);

                entity.HasOne(e => e.User)
                    .WithMany(e => e.Permission)
                    .HasForeignKey(e => e.UserId)  // ForeignKey is Guid now
                    .OnDelete(DeleteBehavior.ClientCascade);

                entity.HasOne(e => e.Modules)
                    .WithMany(e => e.Permission)
                    .HasForeignKey(e => e.IdModule)
                    .OnDelete(DeleteBehavior.ClientCascade);
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
                entity.HasOne(c => c.Country)
                .WithMany(c=>c.City)
                .HasForeignKey(c=>c.CountryId)
                .OnDelete(DeleteBehavior.ClientCascade);
            });
            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(c => c.CountryId);
                entity.HasMany(c => c.City);
            });
   

        }

        public DbSet<Article> Article { get; set; }
        public DbSet<Familly> Familly { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Modules> Modules { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<City> City { get; set; }
    }
}
