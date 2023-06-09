﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using padaria.Context;

#nullable disable

namespace padaria.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230609211321_MigracaoInicial")]
    partial class MigracaoInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("padaria.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("padaria.Models.Padaria", b =>
                {
                    b.Property<int>("PadariaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PadariaId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("Estoque")
                        .HasColumnType("bit");

                    b.Property<string>("ImageThumbUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("LancheFavorite")
                        .HasColumnType("bit");

                    b.Property<string>("NameProduct")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("PadariaDesc")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PadariaLongDesc")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("PadariaId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Padaria");
                });

            modelBuilder.Entity("padaria.Models.Padaria", b =>
                {
                    b.HasOne("padaria.Models.Category", "Category")
                        .WithMany("Padarias")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("padaria.Models.Category", b =>
                {
                    b.Navigation("Padarias");
                });
#pragma warning restore 612, 618
        }
    }
}
