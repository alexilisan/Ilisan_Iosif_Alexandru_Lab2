﻿// <auto-generated />
using System;
using Ilisan_Iosif_Alexandru_Lab2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ilisan_Iosif_Alexandru_Lab2.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20241122185812_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ilisan_Iosif_Alexandru_Lab2.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GenreID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("GenreID");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("Ilisan_Iosif_Alexandru_Lab2.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Ilisan_Iosif_Alexandru_Lab2.Models.Genre", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("Ilisan_Iosif_Alexandru_Lab2.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<int?>("BookID")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerID")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex("BookID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Ilisan_Iosif_Alexandru_Lab2.Models.Book", b =>
                {
                    b.HasOne("Ilisan_Iosif_Alexandru_Lab2.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreID");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Ilisan_Iosif_Alexandru_Lab2.Models.Order", b =>
                {
                    b.HasOne("Ilisan_Iosif_Alexandru_Lab2.Models.Book", "Book")
                        .WithMany("Orders")
                        .HasForeignKey("BookID");

                    b.HasOne("Ilisan_Iosif_Alexandru_Lab2.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID");

                    b.Navigation("Book");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Ilisan_Iosif_Alexandru_Lab2.Models.Book", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Ilisan_Iosif_Alexandru_Lab2.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
