using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SmartCafe.Postgres.Models
{
    public partial class SmartCafeContext : DbContext
    {
        public SmartCafeContext()
        {
        }

        public SmartCafeContext(DbContextOptions<SmartCafeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<OrderItems> OrderItems { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<ProductCategories> ProductCategories { get; set; }
        public virtual DbSet<ProductSubCategories> ProductSubCategories { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<SubCategories> SubCategories { get; set; }
        public virtual DbSet<Tables> Tables { get; set; }
        public virtual DbSet<UserGroupMembers> UserGroupMembers { get; set; }
        public virtual DbSet<UserGroups> UserGroups { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>(entity =>
            {
                entity.ToTable("categories");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OrderItems>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ProductId })
                    .HasName("order_items_pkey");

                entity.ToTable("order_items");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.IsDelivered).HasColumnName("is_delivered");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(1000);

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("order_items_order_id_fkey");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("order_items_product_id_fkey");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.ToTable("orders");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.IsClosed).HasColumnName("is_closed");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.TableId).HasColumnName("table_id");

                entity.HasOne(d => d.Table)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.TableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orders_table_id_fkey");
            });

            modelBuilder.Entity<ProductCategories>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.CategoryId })
                    .HasName("product_categories_pkey1");

                entity.ToTable("product_categories");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(1000);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ProductCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("product_categories_category_id_fkey");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCategories)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("product_categories_product_id_fkey");
            });

            modelBuilder.Entity<ProductSubCategories>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.SubCategoryId })
                    .HasName("product_sub_categories_pkey1");

                entity.ToTable("product_sub_categories");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.SubCategoryId).HasColumnName("sub_category_id");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(1000);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductSubCategories)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("product_sub_categories_product_id_fkey");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.ProductSubCategories)
                    .HasForeignKey(d => d.SubCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("product_sub_categories_sub_category_id_fkey");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.ToTable("products");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Allergens).HasColumnName("allergens");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.IsPromo).HasColumnName("is_promo");

                entity.Property(e => e.IsRecommended).HasColumnName("is_recommended");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.PriceWithVat)
                    .HasColumnName("price_with_vat")
                    .HasColumnType("numeric(15,2)");
            });

            modelBuilder.Entity<SubCategories>(entity =>
            {
                entity.ToTable("sub_categories");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SubCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("product_sub_categories_category_id_fkey");
            });

            modelBuilder.Entity<Tables>(entity =>
            {
                entity.ToTable("tables");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.IsInUse).HasColumnName("is_in_use");

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasColumnName("tag")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<UserGroupMembers>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.UserGroupId })
                    .HasName("pk_user_group_members");

                entity.ToTable("user_group_members");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserGroupId).HasColumnName("user_group_id");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(1000);

                entity.HasOne(d => d.UserGroup)
                    .WithMany(p => p.UserGroupMembers)
                    .HasForeignKey(d => d.UserGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_user_group_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserGroupMembers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_user_id");
            });

            modelBuilder.Entity<UserGroups>(entity =>
            {
                entity.ToTable("user_groups");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.FullName)
                    .HasColumnName("full_name")
                    .HasMaxLength(500);

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(2000);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(500);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(500);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
