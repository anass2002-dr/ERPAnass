using ERP_Anass_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend
{
    public class DbContextERP : DbContext
    {
        public DbContextERP(DbContextOptions<DbContextERP> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define your model creation logic here
            modelBuilder.Entity<Article>(entity =>
            {
                entity.HasKey(e => e.idArticle);
                entity.HasOne(e => e.Familly)
                .WithMany(e => e.Article)
                .HasForeignKey(e => e.FamilyID)
                .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<Familly>(entity =>
            {
                entity.HasKey(e => e.idFamilly);
                entity.HasMany(e => e.Article);
            });
        }
        public DbSet<Article> Article { get; set; }
        public DbSet<Familly> Familly { get; set; }
        public DbSet<User> Users { get; set; }
    }

}