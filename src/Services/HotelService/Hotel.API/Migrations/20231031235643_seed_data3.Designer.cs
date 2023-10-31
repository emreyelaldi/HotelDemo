﻿// <auto-generated />
using System;
using Hotel.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hotel.API.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20231031235643_seed_data3")]
    partial class seed_data3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hotel.API.Entities.ContactInfo", b =>
                {
                    b.Property<Guid>("UUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("HotelUUID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("InfoContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InfoType")
                        .HasColumnType("int");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("UUID");

                    b.HasIndex("HotelUUID");

                    b.ToTable("ContactInfos");

                    b.HasData(
                        new
                        {
                            UUID = new Guid("94ac9ba1-95b3-4897-a916-8fe73f62338f"),
                            CreatedBy = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelUUID = new Guid("420ec3c7-d391-427b-a552-51ce4b10566d"),
                            InfoContent = "0 555 4443322",
                            InfoType = 0,
                            ModifiedBy = 0,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UUID = new Guid("ec68cf17-c934-4197-a0b5-4cc570f0dbbd"),
                            CreatedBy = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelUUID = new Guid("420ec3c7-d391-427b-a552-51ce4b10566d"),
                            InfoContent = "sunhotel@mail.com",
                            InfoType = 1,
                            ModifiedBy = 0,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UUID = new Guid("7daf6641-6296-48b9-9ed7-64f2201cd8dd"),
                            CreatedBy = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelUUID = new Guid("420ec3c7-d391-427b-a552-51ce4b10566d"),
                            InfoContent = "Antalya",
                            InfoType = 2,
                            ModifiedBy = 0,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UUID = new Guid("b6b00304-0f18-425f-954d-3b49b038d1a5"),
                            CreatedBy = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelUUID = new Guid("88aafd58-de2c-4a72-968b-0c6d19aff73a"),
                            InfoContent = "0 533 5558899",
                            InfoType = 0,
                            ModifiedBy = 0,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UUID = new Guid("8791bc29-3131-49fe-8402-def6f70d6073"),
                            CreatedBy = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelUUID = new Guid("88aafd58-de2c-4a72-968b-0c6d19aff73a"),
                            InfoContent = "moonhotel@mail.com",
                            InfoType = 1,
                            ModifiedBy = 0,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UUID = new Guid("b3d0cb13-7431-4d83-af33-29d47e2ecc9a"),
                            CreatedBy = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelUUID = new Guid("8523d2e4-4f63-4524-953e-df3bb596681b"),
                            InfoContent = "royalhotel@mail.com",
                            InfoType = 1,
                            ModifiedBy = 0,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Hotel.API.Entities.Hotel", b =>
                {
                    b.Property<Guid>("UUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AuthorizedFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorizedLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("UUID");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            UUID = new Guid("420ec3c7-d391-427b-a552-51ce4b10566d"),
                            AuthorizedFirstName = "Ali",
                            AuthorizedLastName = "Demir",
                            CompanyTitle = "Sun Hotel",
                            CreatedBy = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedBy = 0,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UUID = new Guid("88aafd58-de2c-4a72-968b-0c6d19aff73a"),
                            AuthorizedFirstName = "Veli",
                            AuthorizedLastName = "Öz",
                            CompanyTitle = "Moon Hotel",
                            CreatedBy = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedBy = 0,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UUID = new Guid("8523d2e4-4f63-4524-953e-df3bb596681b"),
                            AuthorizedFirstName = "Ahmet",
                            AuthorizedLastName = "Duman",
                            CompanyTitle = "Royal Hotel",
                            CreatedBy = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedBy = 0,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Hotel.API.Entities.ContactInfo", b =>
                {
                    b.HasOne("Hotel.API.Entities.Hotel", null)
                        .WithMany("ContactInfos")
                        .HasForeignKey("HotelUUID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hotel.API.Entities.Hotel", b =>
                {
                    b.Navigation("ContactInfos");
                });
#pragma warning restore 612, 618
        }
    }
}