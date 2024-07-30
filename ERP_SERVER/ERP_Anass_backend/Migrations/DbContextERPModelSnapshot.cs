﻿// <auto-generated />
using ERP_Anass_backend;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ERP_Anass_backend.Migrations
{
    [DbContext(typeof(DbContextERP))]
    partial class DbContextERPModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ERP_Anass_backend.Models.Article", b =>
                {
                    b.Property<int>("idArticle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("idArticle"));

                    b.Property<string>("ArticleName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ArticleRef")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DescriptionArticle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("FamilyID")
                        .HasColumnType("int");

                    b.Property<float>("PurchasePrice")
                        .HasColumnType("float");

                    b.Property<float>("SellingPrice")
                        .HasColumnType("float");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.HasKey("idArticle");

                    b.HasIndex("FamilyID");

                    b.ToTable("Article");
                });

            modelBuilder.Entity("ERP_Anass_backend.Models.Familly", b =>
                {
                    b.Property<int>("idFamilly")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("idFamilly"));

                    b.Property<string>("familyDesc")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("familyName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("familyRef")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("idFamilly");

                    b.ToTable("Familly");
                });

            modelBuilder.Entity("ERP_Anass_backend.Models.Article", b =>
                {
                    b.HasOne("ERP_Anass_backend.Models.Familly", "Familly")
                        .WithMany("Article")
                        .HasForeignKey("FamilyID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Familly");
                });

            modelBuilder.Entity("ERP_Anass_backend.Models.Familly", b =>
                {
                    b.Navigation("Article");
                });
#pragma warning restore 612, 618
        }
    }
}
