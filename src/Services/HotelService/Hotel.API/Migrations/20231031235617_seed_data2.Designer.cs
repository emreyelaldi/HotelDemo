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
    [Migration("20231031235617_seed_data2")]
    partial class seed_data2
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
                            UUID = new Guid("d6ab6f21-32d7-4b09-8006-c6b984944f83"),
                            CreatedBy = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelUUID = new Guid("0482fb14-dd1a-407a-9f67-4598effb94b7"),
                            InfoContent = "0 555 4443322",
                            InfoType = 0,
                            ModifiedBy = 0,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UUID = new Guid("3c3c98b0-6990-429c-8800-cd375360e41d"),
                            CreatedBy = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelUUID = new Guid("0482fb14-dd1a-407a-9f67-4598effb94b7"),
                            InfoContent = "sunhotel@mail.com",
                            InfoType = 1,
                            ModifiedBy = 0,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UUID = new Guid("6d1b0a32-f4fb-4d09-8085-94174cf89759"),
                            CreatedBy = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelUUID = new Guid("0482fb14-dd1a-407a-9f67-4598effb94b7"),
                            InfoContent = "Antalya",
                            InfoType = 2,
                            ModifiedBy = 0,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UUID = new Guid("23d2018f-c15d-4705-afe3-c6700f29ef74"),
                            CreatedBy = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelUUID = new Guid("7b861151-195e-4311-86ed-a26063da8a1d"),
                            InfoContent = "0 533 5558899",
                            InfoType = 0,
                            ModifiedBy = 0,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UUID = new Guid("44c1d8c0-784f-4794-bcb9-d51ee2682450"),
                            CreatedBy = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelUUID = new Guid("7b861151-195e-4311-86ed-a26063da8a1d"),
                            InfoContent = "moonhotel@mail.com",
                            InfoType = 1,
                            ModifiedBy = 0,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UUID = new Guid("f8670bb2-daa2-47fa-89e6-f2a674c779c6"),
                            CreatedBy = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelUUID = new Guid("d13bd12b-2811-4275-b64f-b5057e2e8ec5"),
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
                            UUID = new Guid("0482fb14-dd1a-407a-9f67-4598effb94b7"),
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
                            UUID = new Guid("7b861151-195e-4311-86ed-a26063da8a1d"),
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
                            UUID = new Guid("d13bd12b-2811-4275-b64f-b5057e2e8ec5"),
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
