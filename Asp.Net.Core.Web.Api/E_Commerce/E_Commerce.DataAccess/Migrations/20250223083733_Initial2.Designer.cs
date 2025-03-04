﻿// <auto-generated />
using System;
using E_Commerce.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_Commerce.DataAccess.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20250223083733_Initial2")]
    partial class Initial2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("E_Commerce.DataAccess.Model.Basket", b =>
                {
                    b.Property<int>("basketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("basketId"));

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("basketId");

                    b.HasIndex("userId");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Model.BasketDetail", b =>
                {
                    b.Property<int>("basketDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("basketDetailId"));

                    b.Property<int>("basketId")
                        .HasColumnType("int");

                    b.Property<int>("basket_quantity")
                        .HasColumnType("int");

                    b.Property<int>("productId")
                        .HasColumnType("int");

                    b.HasKey("basketDetailId");

                    b.HasIndex("basketId");

                    b.HasIndex("productId");

                    b.ToTable("BasketDetails");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Model.Category", b =>
                {
                    b.Property<int>("categoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("categoryId"));

                    b.Property<string>("categoryDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("categoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("categoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Model.Order", b =>
                {
                    b.Property<int>("orderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("orderId"));

                    b.Property<int>("basketId")
                        .HasColumnType("int");

                    b.Property<DateTime>("orderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("totalAmount")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("orderId");

                    b.HasIndex("basketId")
                        .IsUnique();

                    b.HasIndex("userId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Model.OrderDetail", b =>
                {
                    b.Property<int>("orderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("orderDetailId"));

                    b.Property<int>("orderId")
                        .HasColumnType("int");

                    b.Property<int>("order_product_quantity")
                        .HasColumnType("int");

                    b.Property<int>("order_product_totalPrice")
                        .HasColumnType("int");

                    b.Property<int>("productId")
                        .HasColumnType("int");

                    b.HasKey("orderDetailId");

                    b.HasIndex("orderId");

                    b.HasIndex("productId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Model.Product", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("productId"));

                    b.Property<string>("productDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("productUnitPrice")
                        .HasColumnType("int");

                    b.Property<int>("subCategoryId")
                        .HasColumnType("int");

                    b.HasKey("productId");

                    b.HasIndex("subCategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Model.Role", b =>
                {
                    b.Property<int>("roleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("roleId"));

                    b.Property<string>("roleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("roleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Model.SubCategory", b =>
                {
                    b.Property<int>("subCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("subCategoryId"));

                    b.Property<int>("categoryId")
                        .HasColumnType("int");

                    b.Property<string>("subCategoryDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("subCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("subCategoryId");

                    b.HasIndex("categoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Model.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userId"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Model.UserRole", b =>
                {
                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.Property<int>("roleId")
                        .HasColumnType("int");

                    b.HasKey("userId", "roleId");

                    b.HasIndex("roleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Model.Basket", b =>
                {
                    b.HasOne("E_Commerce.DataAccess.Model.User", "User")
                        .WithMany("baskets")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Model.BasketDetail", b =>
                {
                    b.HasOne("E_Commerce.DataAccess.Model.Basket", "Basket")
                        .WithMany("BasketDetails")
                        .HasForeignKey("basketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce.DataAccess.Model.Product", "Product")
                        .WithMany("BasketDetails")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Basket");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Model.Order", b =>
                {
                    b.HasOne("E_Commerce.DataAccess.Model.Basket", "Basket")
                        .WithOne("Order")
                        .HasForeignKey("E_Commerce.DataAccess.Model.Order", "basketId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("E_Commerce.DataAccess.Model.User", "User")
                        .WithMany("orders")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Basket");

                    b.Navigation("User");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Model.OrderDetail", b =>
                {
                    b.HasOne("E_Commerce.DataAccess.Model.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("orderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce.DataAccess.Model.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Model.Product", b =>
                {
                    b.HasOne("E_Commerce.DataAccess.Model.SubCategory", "SubCategory")
                        .WithMany("Products")
                        .HasForeignKey("subCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Model.SubCategory", b =>
                {
                    b.HasOne("E_Commerce.DataAccess.Model.Category", "Category")
                        .WithMany("subCategories")
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Model.UserRole", b =>
                {
                    b.HasOne("E_Commerce.DataAccess.Model.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("roleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce.DataAccess.Model.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Model.Basket", b =>
                {
                    b.Navigation("BasketDetails");

                    b.Navigation("Order")
                        .IsRequired();
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Model.Category", b =>
                {
                    b.Navigation("subCategories");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Model.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Model.Product", b =>
                {
                    b.Navigation("BasketDetails");

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Model.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Model.SubCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Model.User", b =>
                {
                    b.Navigation("UserRoles");

                    b.Navigation("baskets");

                    b.Navigation("orders");
                });
#pragma warning restore 612, 618
        }
    }
}
