﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TECH.Data.DatabaseEntity;

#nullable disable

namespace TECH.Migrations
{
    [DbContext(typeof(DataBaseEntityContext))]
    [Migration("20230105141042_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TECH.Data.DatabaseEntity.Advertisement", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("image")
                        .HasColumnType("varchar(500)");

                    b.HasKey("id");

                    b.ToTable("advertisement");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.Carts", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("color")
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("price")
                        .HasColumnType("int");

                    b.Property<int?>("product_id")
                        .HasColumnType("int");

                    b.Property<int?>("quantity")
                        .HasColumnType("int");

                    b.Property<int?>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("product_id");

                    b.ToTable("carts");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("slug")
                        .HasColumnType("varchar(200)");

                    b.Property<int?>("status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.City", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("type")
                        .HasColumnType("varchar(500)");

                    b.HasKey("id");

                    b.ToTable("cities");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.Colors", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("code")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("color");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.Contracts", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime?>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("full_name")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("note")
                        .HasColumnType("text");

                    b.Property<string>("phone_number")
                        .HasColumnType("varchar(11)");

                    b.Property<int?>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("contacts");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.Districts", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("city_id")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .HasColumnType("varchar(500)");

                    b.HasKey("id");

                    b.HasIndex("city_id");

                    b.ToTable("districts");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.Fees", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("city_id")
                        .HasColumnType("int");

                    b.Property<int?>("district_id")
                        .HasColumnType("int");

                    b.Property<int?>("fee")
                        .HasColumnType("int");

                    b.Property<int?>("ward_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("city_id");

                    b.HasIndex("district_id");

                    b.HasIndex("ward_id");

                    b.ToTable("fees");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.Images", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("alt")
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("name")
                        .HasColumnType("varchar(200)");

                    b.Property<int?>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("images");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.Orders", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("code")
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<int?>("fee_ship")
                        .HasColumnType("int");

                    b.Property<string>("full_name")
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("note")
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("payment")
                        .HasColumnType("int");

                    b.Property<string>("phone_number")
                        .HasColumnType("varchar(150)");

                    b.Property<int?>("review")
                        .HasColumnType("int");

                    b.Property<int?>("status")
                        .HasColumnType("int");

                    b.Property<int?>("total")
                        .HasColumnType("int");

                    b.Property<int?>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("user_id");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.OrdersDetails", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("color")
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("order_id")
                        .HasColumnType("int");

                    b.Property<decimal?>("price")
                        .HasColumnType("decimal(18,0)");

                    b.Property<int?>("product_id")
                        .HasColumnType("int");

                    b.Property<int?>("quantity")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("order_id");

                    b.HasIndex("product_id");

                    b.ToTable("order_details");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.Posts", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("author")
                        .HasColumnType("int");

                    b.Property<string>("avatar")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("short_content")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("slug")
                        .HasColumnType("varchar(500)");

                    b.Property<int?>("status")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("posts");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.ProductImages", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("image_id")
                        .HasColumnType("int");

                    b.Property<int?>("product_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("image_id");

                    b.HasIndex("product_id");

                    b.ToTable("product_images");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.ProductQuantity", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("color_id")
                        .HasColumnType("int");

                    b.Property<int?>("product_id")
                        .HasColumnType("int");

                    b.Property<int?>("size_id")
                        .HasColumnType("int");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<int?>("totalimport")
                        .HasColumnType("int");

                    b.Property<int?>("totalinventory")
                        .HasColumnType("int");

                    b.Property<int?>("totalsell")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("color_id");

                    b.HasIndex("product_id");

                    b.HasIndex("size_id");

                    b.ToTable("product_quantity");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.Products", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("category_id")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(250)");

                    b.Property<decimal?>("price_import")
                        .HasColumnType("decimal(18,0)");

                    b.Property<decimal?>("price_reduced")
                        .HasColumnType("decimal(18,0)");

                    b.Property<decimal?>("price_sell")
                        .HasColumnType("decimal(18,0)");

                    b.Property<int?>("status")
                        .HasColumnType("int");

                    b.Property<string>("trademark")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("category_id");

                    b.ToTable("products");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.Reviews", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<int?>("order_id")
                        .HasColumnType("int");

                    b.Property<int?>("product_id")
                        .HasColumnType("int");

                    b.Property<int?>("star")
                        .HasColumnType("int");

                    b.Property<int?>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("order_id");

                    b.HasIndex("product_id");

                    b.ToTable("reviews");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.Siders", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime?>("create_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("image")
                        .HasColumnType("varchar(500)");

                    b.Property<int?>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("siders");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.Size", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("size");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.Users", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("avatar")
                        .HasColumnType("varchar(500)");

                    b.Property<string>("code")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("email")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("full_name")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("password")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("phone_number")
                        .HasColumnType("varchar(11)");

                    b.Property<DateTime?>("register_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("role")
                        .HasColumnType("int");

                    b.Property<int?>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.Wards", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("district_id")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .HasColumnType("varchar(500)");

                    b.HasKey("id");

                    b.HasIndex("district_id");

                    b.ToTable("wards");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.Carts", b =>
                {
                    b.HasOne("TECH.Data.DatabaseEntity.Products", "Products")
                        .WithMany()
                        .HasForeignKey("product_id");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.Districts", b =>
                {
                    b.HasOne("TECH.Data.DatabaseEntity.City", "City")
                        .WithMany()
                        .HasForeignKey("city_id");

                    b.Navigation("City");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.Fees", b =>
                {
                    b.HasOne("TECH.Data.DatabaseEntity.City", "City")
                        .WithMany()
                        .HasForeignKey("city_id");

                    b.HasOne("TECH.Data.DatabaseEntity.Districts", "Districts")
                        .WithMany()
                        .HasForeignKey("district_id");

                    b.HasOne("TECH.Data.DatabaseEntity.Wards", "Wards")
                        .WithMany()
                        .HasForeignKey("ward_id");

                    b.Navigation("City");

                    b.Navigation("Districts");

                    b.Navigation("Wards");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.Orders", b =>
                {
                    b.HasOne("TECH.Data.DatabaseEntity.Users", "Users")
                        .WithMany()
                        .HasForeignKey("user_id");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.OrdersDetails", b =>
                {
                    b.HasOne("TECH.Data.DatabaseEntity.Orders", "Orders")
                        .WithMany()
                        .HasForeignKey("order_id");

                    b.HasOne("TECH.Data.DatabaseEntity.Products", "Products")
                        .WithMany()
                        .HasForeignKey("product_id");

                    b.Navigation("Orders");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.ProductImages", b =>
                {
                    b.HasOne("TECH.Data.DatabaseEntity.Images", "Images")
                        .WithMany()
                        .HasForeignKey("image_id");

                    b.HasOne("TECH.Data.DatabaseEntity.Products", "Products")
                        .WithMany()
                        .HasForeignKey("product_id");

                    b.Navigation("Images");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.ProductQuantity", b =>
                {
                    b.HasOne("TECH.Data.DatabaseEntity.Colors", "Colors")
                        .WithMany()
                        .HasForeignKey("color_id");

                    b.HasOne("TECH.Data.DatabaseEntity.Products", "Products")
                        .WithMany()
                        .HasForeignKey("product_id");

                    b.HasOne("TECH.Data.DatabaseEntity.Size", "size")
                        .WithMany()
                        .HasForeignKey("size_id");

                    b.Navigation("Colors");

                    b.Navigation("Products");

                    b.Navigation("size");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.Products", b =>
                {
                    b.HasOne("TECH.Data.DatabaseEntity.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("category_id");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.Reviews", b =>
                {
                    b.HasOne("TECH.Data.DatabaseEntity.Orders", "Orders")
                        .WithMany()
                        .HasForeignKey("order_id");

                    b.HasOne("TECH.Data.DatabaseEntity.Products", "Products")
                        .WithMany()
                        .HasForeignKey("product_id");

                    b.Navigation("Orders");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.Wards", b =>
                {
                    b.HasOne("TECH.Data.DatabaseEntity.Districts", "Districts")
                        .WithMany()
                        .HasForeignKey("district_id");

                    b.Navigation("Districts");
                });

            modelBuilder.Entity("TECH.Data.DatabaseEntity.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}