﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SmartCafe.Postgres.Models;

namespace SmartCafe.Postgres.Migrations
{
    [DbContext(typeof(SmartCafeContext))]
    [Migration("20191013210815_initial-seed-categories")]
    partial class initialseedcategories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SmartCafe.Postgres.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Piće"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Hrana"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Cigarete"
                        });
                });

            modelBuilder.Entity("SmartCafe.Postgres.Models.OrderItems", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnName("order_id")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnName("product_id")
                        .HasColumnType("integer");

                    b.Property<string>("Note")
                        .HasColumnName("note")
                        .HasColumnType("character varying(1000)")
                        .HasMaxLength(1000);

                    b.HasKey("OrderId", "ProductId")
                        .HasName("order_items_pkey");

                    b.HasIndex("ProductId");

                    b.ToTable("order_items");
                });

            modelBuilder.Entity("SmartCafe.Postgres.Models.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("IsClosed")
                        .HasColumnName("is_closed")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnName("order_date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("TableId")
                        .HasColumnName("table_id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TableId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("SmartCafe.Postgres.Models.ProductCategories", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnName("product_id")
                        .HasColumnType("integer");

                    b.Property<int>("CategoryId")
                        .HasColumnName("category_id")
                        .HasColumnType("integer");

                    b.Property<string>("Note")
                        .HasColumnName("note")
                        .HasColumnType("character varying(1000)")
                        .HasMaxLength(1000);

                    b.HasKey("ProductId", "CategoryId")
                        .HasName("product_categories_pkey1");

                    b.HasIndex("CategoryId");

                    b.ToTable("product_categories");
                });

            modelBuilder.Entity("SmartCafe.Postgres.Models.ProductSubCategories", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnName("product_id")
                        .HasColumnType("integer");

                    b.Property<int>("SubCategoryId")
                        .HasColumnName("sub_category_id")
                        .HasColumnType("integer");

                    b.Property<string>("Note")
                        .HasColumnName("note")
                        .HasColumnType("character varying(1000)")
                        .HasMaxLength(1000);

                    b.HasKey("ProductId", "SubCategoryId")
                        .HasName("product_sub_categories_pkey1");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("product_sub_categories");
                });

            modelBuilder.Entity("SmartCafe.Postgres.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string[]>("Allergens")
                        .HasColumnName("allergens")
                        .HasColumnType("text[]");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("character varying(1000)")
                        .HasMaxLength(1000);

                    b.Property<bool>("IsPromo")
                        .HasColumnName("is_promo")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsRecommended")
                        .HasColumnName("is_recommended")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<decimal?>("PriceWithVat")
                        .HasColumnName("price_with_vat")
                        .HasColumnType("numeric(15,2)");

                    b.HasKey("Id");

                    b.ToTable("products");
                });

            modelBuilder.Entity("SmartCafe.Postgres.Models.SubCategories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnName("category_id")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("sub_categories");
                });

            modelBuilder.Entity("SmartCafe.Postgres.Models.Tables", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("character varying(1000)")
                        .HasMaxLength(1000);

                    b.Property<bool>("IsInUse")
                        .HasColumnName("is_in_use")
                        .HasColumnType("boolean");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnName("tag")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("tables");
                });

            modelBuilder.Entity("SmartCafe.Postgres.Models.UserGroupMembers", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("integer");

                    b.Property<int>("UserGroupId")
                        .HasColumnName("user_group_id")
                        .HasColumnType("integer");

                    b.Property<string>("Note")
                        .HasColumnName("note")
                        .HasColumnType("character varying(1000)")
                        .HasMaxLength(1000);

                    b.HasKey("UserId", "UserGroupId")
                        .HasName("pk_user_group_members");

                    b.HasIndex("UserGroupId");

                    b.ToTable("user_group_members");
                });

            modelBuilder.Entity("SmartCafe.Postgres.Models.UserGroups", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("user_groups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2019, 10, 13, 23, 8, 15, 367, DateTimeKind.Local).AddTicks(9646),
                            Name = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2019, 10, 13, 23, 8, 15, 371, DateTimeKind.Local).AddTicks(5705),
                            Name = "MENADZER"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2019, 10, 13, 23, 8, 15, 371, DateTimeKind.Local).AddTicks(5773),
                            Name = "KONOBAR"
                        });
                });

            modelBuilder.Entity("SmartCafe.Postgres.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FullName")
                        .HasColumnName("full_name")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Note")
                        .HasColumnName("note")
                        .HasColumnType("character varying(2000)")
                        .HasMaxLength(2000);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Phone")
                        .HasColumnName("phone")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnName("username")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "dmilutinovic@gmail.com",
                            FullName = "Darko Milutinović",
                            Password = "$2a$10$yHj0aEM1PSZSGYfkQ3QvYe6REKDlnofPnfbUiVbfLIYnDj52WYiP6",
                            Username = "mdarco"
                        });
                });

            modelBuilder.Entity("SmartCafe.Postgres.Models.OrderItems", b =>
                {
                    b.HasOne("SmartCafe.Postgres.Models.Orders", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("order_items_order_id_fkey")
                        .IsRequired();

                    b.HasOne("SmartCafe.Postgres.Models.Products", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("order_items_product_id_fkey")
                        .IsRequired();
                });

            modelBuilder.Entity("SmartCafe.Postgres.Models.Orders", b =>
                {
                    b.HasOne("SmartCafe.Postgres.Models.Tables", "Table")
                        .WithMany("Orders")
                        .HasForeignKey("TableId")
                        .HasConstraintName("orders_table_id_fkey")
                        .IsRequired();
                });

            modelBuilder.Entity("SmartCafe.Postgres.Models.ProductCategories", b =>
                {
                    b.HasOne("SmartCafe.Postgres.Models.Categories", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("product_categories_category_id_fkey")
                        .IsRequired();

                    b.HasOne("SmartCafe.Postgres.Models.Products", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("product_categories_product_id_fkey")
                        .IsRequired();
                });

            modelBuilder.Entity("SmartCafe.Postgres.Models.ProductSubCategories", b =>
                {
                    b.HasOne("SmartCafe.Postgres.Models.Products", "Product")
                        .WithMany("ProductSubCategories")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("product_sub_categories_product_id_fkey")
                        .IsRequired();

                    b.HasOne("SmartCafe.Postgres.Models.SubCategories", "SubCategory")
                        .WithMany("ProductSubCategories")
                        .HasForeignKey("SubCategoryId")
                        .HasConstraintName("product_sub_categories_sub_category_id_fkey")
                        .IsRequired();
                });

            modelBuilder.Entity("SmartCafe.Postgres.Models.SubCategories", b =>
                {
                    b.HasOne("SmartCafe.Postgres.Models.Categories", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("product_sub_categories_category_id_fkey")
                        .IsRequired();
                });

            modelBuilder.Entity("SmartCafe.Postgres.Models.UserGroupMembers", b =>
                {
                    b.HasOne("SmartCafe.Postgres.Models.UserGroups", "UserGroup")
                        .WithMany("UserGroupMembers")
                        .HasForeignKey("UserGroupId")
                        .HasConstraintName("fk_user_group_id")
                        .IsRequired();

                    b.HasOne("SmartCafe.Postgres.Models.Users", "User")
                        .WithMany("UserGroupMembers")
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_user_id")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
