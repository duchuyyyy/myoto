﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyOToVer1._2.Data;

#nullable disable

namespace MyOToVer1._2.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20230412120940_UpdateOwner")]
    partial class UpdateOwner
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyOToVer1._2.Models.Car", b =>
                {
                    b.Property<int>("car_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("car_id"));

                    b.Property<string>("car_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("car_brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("car_capacity")
                        .HasColumnType("int");

                    b.Property<int>("car_consume_fuel")
                        .HasColumnType("int");

                    b.Property<string>("car_description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("car_fuel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("car_model_year")
                        .HasColumnType("int");

                    b.Property<string>("car_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("car_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("car_number_rented")
                        .HasColumnType("int");

                    b.Property<int>("car_price")
                        .HasColumnType("int");

                    b.Property<string>("car_rule")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("car_status")
                        .HasColumnType("bit");

                    b.Property<string>("car_tranmission")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("owner_id")
                        .HasColumnType("int");

                    b.HasKey("car_id");

                    b.HasIndex("owner_id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("MyOToVer1._2.Models.CarImg", b =>
                {
                    b.Property<int>("id_img")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_img"));

                    b.Property<int>("car_id")
                        .HasColumnType("int");

                    b.Property<string>("name_img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_img");

                    b.HasIndex("car_id");

                    b.ToTable("CarImgs");
                });

            modelBuilder.Entity("MyOToVer1._2.Models.CarRental", b =>
                {
                    b.Property<int>("rental_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("rental_id"));

                    b.Property<int>("car_id")
                        .HasColumnType("int");

                    b.Property<int>("customer_id")
                        .HasColumnType("int");

                    b.Property<int>("deposit_status")
                        .HasColumnType("int");

                    b.Property<DateTime>("rental_datetime")
                        .HasColumnType("datetime2");

                    b.Property<int>("rental_status")
                        .HasColumnType("int");

                    b.Property<DateTime>("return_datetime")
                        .HasColumnType("datetime2");

                    b.Property<double>("total_price")
                        .HasColumnType("float");

                    b.HasKey("rental_id");

                    b.HasIndex("car_id");

                    b.HasIndex("customer_id");

                    b.ToTable("CarRentals");
                });

            modelBuilder.Entity("MyOToVer1._2.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("MyOToVer1._2.Models.Owner", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("owner_name_banking")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("owner_number_account")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("owner_revenue")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("MyOToVer1._2.Models.TransferEvidencePhoto", b =>
                {
                    b.Property<int>("rental_id")
                        .HasColumnType("int");

                    b.Property<string>("name_img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("rental_id");

                    b.ToTable("TransferEvidencePhotos");
                });

            modelBuilder.Entity("MyOToVer1._2.Models.Car", b =>
                {
                    b.HasOne("MyOToVer1._2.Models.Owner", "Owner")
                        .WithMany("Cars")
                        .HasForeignKey("owner_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("MyOToVer1._2.Models.CarImg", b =>
                {
                    b.HasOne("MyOToVer1._2.Models.Car", "Car")
                        .WithMany("CarImgs")
                        .HasForeignKey("car_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("MyOToVer1._2.Models.CarRental", b =>
                {
                    b.HasOne("MyOToVer1._2.Models.Car", "Car")
                        .WithMany("CarRentals")
                        .HasForeignKey("car_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MyOToVer1._2.Models.Customer", "customer")
                        .WithMany("CarRentals")
                        .HasForeignKey("customer_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("customer");
                });

            modelBuilder.Entity("MyOToVer1._2.Models.Owner", b =>
                {
                    b.HasOne("MyOToVer1._2.Models.Customer", "Customer")
                        .WithOne("Owner")
                        .HasForeignKey("MyOToVer1._2.Models.Owner", "Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("MyOToVer1._2.Models.TransferEvidencePhoto", b =>
                {
                    b.HasOne("MyOToVer1._2.Models.CarRental", "CarRental")
                        .WithOne("TransferEvidencePhoto")
                        .HasForeignKey("MyOToVer1._2.Models.TransferEvidencePhoto", "rental_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CarRental");
                });

            modelBuilder.Entity("MyOToVer1._2.Models.Car", b =>
                {
                    b.Navigation("CarImgs");

                    b.Navigation("CarRentals");
                });

            modelBuilder.Entity("MyOToVer1._2.Models.CarRental", b =>
                {
                    b.Navigation("TransferEvidencePhoto")
                        .IsRequired();
                });

            modelBuilder.Entity("MyOToVer1._2.Models.Customer", b =>
                {
                    b.Navigation("CarRentals");

                    b.Navigation("Owner")
                        .IsRequired();
                });

            modelBuilder.Entity("MyOToVer1._2.Models.Owner", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
