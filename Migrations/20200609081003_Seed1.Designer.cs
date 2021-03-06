﻿// <auto-generated />
using System;
using MedicationOrders.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MedicationOrders.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200609081003_Seed1")]
    partial class Seed1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MedicationOrders.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 12345,
                            Date = new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 23986,
                            Date = new DateTime(2020, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 76543,
                            Date = new DateTime(2020, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 81276,
                            Date = new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 99088,
                            Date = new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MedicationOrders.Models.Order", b =>
                {
                    b.OwnsMany("MedicationOrders.Models.OrderItem", "Items", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("DaysSupply")
                                .HasColumnType("int");

                            b1.Property<string>("Frequency")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("OrderId")
                                .HasColumnType("int");

                            b1.Property<int>("Quantity")
                                .HasColumnType("int");

                            b1.HasKey("Id");

                            b1.HasIndex("OrderId");

                            b1.ToTable("OrderItem");

                            b1.WithOwner()
                                .HasForeignKey("OrderId");

                            b1.HasData(
                                new
                                {
                                    Id = 1,
                                    DaysSupply = 30,
                                    Frequency = "Every Day",
                                    Name = "Collagen Dressing",
                                    OrderId = 12345,
                                    Quantity = 30
                                },
                                new
                                {
                                    Id = 2,
                                    DaysSupply = 30,
                                    Frequency = "Every Day",
                                    Name = "Collagen Powder",
                                    OrderId = 12345,
                                    Quantity = 30
                                },
                                new
                                {
                                    Id = 3,
                                    DaysSupply = 30,
                                    Frequency = "Every Day",
                                    Name = "WaterProof Tape",
                                    OrderId = 12345,
                                    Quantity = 1
                                },
                                new
                                {
                                    Id = 10,
                                    DaysSupply = 30,
                                    Frequency = "Every Day",
                                    Name = "Collagen Dressing",
                                    OrderId = 23986,
                                    Quantity = 30
                                },
                                new
                                {
                                    Id = 11,
                                    DaysSupply = 30,
                                    Frequency = "Once A Week",
                                    Name = "Botox",
                                    OrderId = 23986,
                                    Quantity = 4
                                },
                                new
                                {
                                    Id = 20,
                                    DaysSupply = 30,
                                    Frequency = "Every Day",
                                    Name = "Collagen Dressing",
                                    OrderId = 76543,
                                    Quantity = 30
                                },
                                new
                                {
                                    Id = 21,
                                    DaysSupply = 60,
                                    Frequency = "Once A Day",
                                    Name = "Essential Oils",
                                    OrderId = 76543,
                                    Quantity = 2
                                },
                                new
                                {
                                    Id = 30,
                                    DaysSupply = 30,
                                    Frequency = "Every Day",
                                    Name = "Collagen Mask",
                                    OrderId = 81276,
                                    Quantity = 1
                                },
                                new
                                {
                                    Id = 31,
                                    DaysSupply = 30,
                                    Frequency = "Once A Day",
                                    Name = "Essential Oils",
                                    OrderId = 81276,
                                    Quantity = 2
                                },
                                new
                                {
                                    Id = 40,
                                    DaysSupply = 30,
                                    Frequency = "Every Day",
                                    Name = "Collagen Mask",
                                    OrderId = 99088,
                                    Quantity = 1
                                },
                                new
                                {
                                    Id = 41,
                                    DaysSupply = 30,
                                    Frequency = "Once A Day",
                                    Name = "Essential Oils",
                                    OrderId = 99088,
                                    Quantity = 2
                                });
                        });

                    b.OwnsOne("MedicationOrders.Models.Patient", "Patient", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("OrderId")
                                .HasColumnType("int");

                            b1.Property<string>("State")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("StreetAddress")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("Id");

                            b1.HasIndex("OrderId")
                                .IsUnique();

                            b1.ToTable("Orders1");

                            b1.WithOwner()
                                .HasForeignKey("OrderId");

                            b1.HasData(
                                new
                                {
                                    Id = 1,
                                    City = "Tampa",
                                    FirstName = "Kim",
                                    LastName = "Wise",
                                    OrderId = 12345,
                                    State = "FL",
                                    StreetAddress = "1234 8th St.",
                                    ZipCode = "33606"
                                },
                                new
                                {
                                    Id = 2,
                                    City = "Tampa",
                                    FirstName = "Elvin",
                                    LastName = "Sharvill",
                                    OrderId = 23986,
                                    State = "FL",
                                    StreetAddress = "567 Gulf Ave.",
                                    ZipCode = "33609"
                                },
                                new
                                {
                                    Id = 3,
                                    City = "Chicago",
                                    FirstName = "Roman",
                                    LastName = "Kutepov",
                                    OrderId = 76543,
                                    State = "IL",
                                    StreetAddress = "123 North Ave.",
                                    ZipCode = "60606"
                                },
                                new
                                {
                                    Id = 4,
                                    City = "Sanny Isles",
                                    FirstName = "Ariana",
                                    LastName = "Barros",
                                    OrderId = 81276,
                                    State = "FL",
                                    StreetAddress = "9865 Collins Blvd.",
                                    ZipCode = "34566"
                                },
                                new
                                {
                                    Id = 5,
                                    City = "Miami Beach",
                                    FirstName = "Hans",
                                    LastName = "Hedman",
                                    OrderId = 99088,
                                    State = "FL",
                                    StreetAddress = "12 Collins Blvd.",
                                    ZipCode = "34567"
                                });
                        });

                    b.OwnsOne("MedicationOrders.Models.Provider", "Provider", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("OrderId")
                                .HasColumnType("int");

                            b1.HasKey("Id");

                            b1.HasIndex("OrderId")
                                .IsUnique();

                            b1.ToTable("Orders2");

                            b1.WithOwner()
                                .HasForeignKey("OrderId");

                            b1.HasData(
                                new
                                {
                                    Id = 1,
                                    Name = "Dr. Collins",
                                    OrderId = 12345
                                },
                                new
                                {
                                    Id = 2,
                                    Name = "Dr. Williams",
                                    OrderId = 23986
                                },
                                new
                                {
                                    Id = 3,
                                    Name = "Dr. Schwarz",
                                    OrderId = 76543
                                },
                                new
                                {
                                    Id = 4,
                                    Name = "Dr. Brown",
                                    OrderId = 81276
                                },
                                new
                                {
                                    Id = 5,
                                    Name = "Dr. Green",
                                    OrderId = 99088
                                });
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
