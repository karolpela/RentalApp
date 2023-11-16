﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentalApp.Server.Data;

#nullable disable

namespace RentalApp.Server.Migrations
{
    [DbContext(typeof(RentalAppContext))]
    [Migration("20231114153025_SeedRental")]
    partial class SeedRental
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("ProtectiveGearRental", b =>
                {
                    b.Property<int>("ProtectiveGearId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RentalsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProtectiveGearId", "RentalsId");

                    b.HasIndex("RentalsId");

                    b.ToTable("ProtectiveGearRental");
                });

            modelBuilder.Entity("RentalApp.Shared.Models.Equipment.SportsEquipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("HourlyFee")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsFunctional")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Size")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Equipment");

                    b.HasDiscriminator<string>("Discriminator").HasValue("SportsEquipment");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("RentalApp.Shared.Models.Insurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Cost")
                        .HasColumnType("TEXT");

                    b.Property<int>("RentalId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RentalId")
                        .IsUnique();

                    b.ToTable("Insurances");
                });

            modelBuilder.Entity("RentalApp.Shared.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("DismissalDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("EmploymentDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Pesel")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SupervisorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId")
                        .IsUnique()
                        .HasFilter("[Role] & 2 = 2 OR [Role] & 4 = 4 OR [Role] & 8 = 8");

                    b.HasIndex("PhoneNumber")
                        .IsUnique()
                        .HasFilter("[Role] & 1 = 1");

                    b.HasIndex("SupervisorId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Aubrey",
                            LastName = "Hurworth",
                            Pesel = "34556468065",
                            PhoneNumber = "190684116",
                            Role = 1
                        },
                        new
                        {
                            Id = 2,
                            EmployeeId = "e1",
                            FirstName = "Duncan",
                            LastName = "Agius",
                            PhoneNumber = "456100995",
                            Role = 3
                        },
                        new
                        {
                            Id = 3,
                            EmployeeId = "e2",
                            FirstName = "Colby",
                            LastName = "Lisciandro",
                            Pesel = "66100957666",
                            PhoneNumber = "391899786",
                            Role = 1
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Sherilyn",
                            LastName = "Cornewall",
                            PhoneNumber = "198315600",
                            Role = 1
                        },
                        new
                        {
                            Id = 5,
                            EmployeeId = "e3",
                            FirstName = "Isadora",
                            LastName = "Casel",
                            Role = 4
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "Hermina",
                            LastName = "Edgley",
                            Pesel = "84576111796",
                            PhoneNumber = "882627905",
                            Role = 1
                        },
                        new
                        {
                            Id = 7,
                            EmployeeId = "e4",
                            FirstName = "Beckie",
                            LastName = "Fann",
                            Role = 4
                        },
                        new
                        {
                            Id = 8,
                            EmployeeId = "e5",
                            FirstName = "Shelley",
                            LastName = "Molyneaux",
                            Role = 2
                        },
                        new
                        {
                            Id = 9,
                            EmployeeId = "e6",
                            FirstName = "Yasmin",
                            LastName = "Beecker",
                            Pesel = "98155940198",
                            PhoneNumber = "362667890",
                            Role = 3
                        },
                        new
                        {
                            Id = 10,
                            EmployeeId = "e7",
                            FirstName = "Nollie",
                            LastName = "Anglish",
                            Role = 4
                        },
                        new
                        {
                            Id = 11,
                            EmployeeId = "e8",
                            FirstName = "Carmencita",
                            LastName = "Tattam",
                            PhoneNumber = "800838101",
                            Role = 5
                        },
                        new
                        {
                            Id = 12,
                            EmployeeId = "e9",
                            FirstName = "Lucas",
                            LastName = "Faughny",
                            Role = 2
                        });
                });

            modelBuilder.Entity("RentalApp.Shared.Models.ProtectiveGear", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ProtectiveGear");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Size = "M",
                            Type = "KneePads"
                        },
                        new
                        {
                            Id = 2,
                            Size = "XXL",
                            Type = "KneePads"
                        },
                        new
                        {
                            Id = 3,
                            Size = "L",
                            Type = "Helmet"
                        },
                        new
                        {
                            Id = 4,
                            Size = "XL",
                            Type = "Helmet"
                        },
                        new
                        {
                            Id = 5,
                            Size = "M",
                            Type = "Helmet"
                        },
                        new
                        {
                            Id = 6,
                            Size = "XXL",
                            Type = "Gloves"
                        },
                        new
                        {
                            Id = 7,
                            Size = "S",
                            Type = "KneePads"
                        },
                        new
                        {
                            Id = 8,
                            Size = "L",
                            Type = "Gloves"
                        },
                        new
                        {
                            Id = 9,
                            Size = "XXL",
                            Type = "Gloves"
                        },
                        new
                        {
                            Id = 10,
                            Size = "XL",
                            Type = "KneePads"
                        },
                        new
                        {
                            Id = 11,
                            Size = "L",
                            Type = "Gloves"
                        },
                        new
                        {
                            Id = 12,
                            Size = "XL",
                            Type = "Gloves"
                        },
                        new
                        {
                            Id = 13,
                            Size = "M",
                            Type = "Gloves"
                        },
                        new
                        {
                            Id = 14,
                            Size = "M",
                            Type = "KneePads"
                        },
                        new
                        {
                            Id = 15,
                            Size = "XXL",
                            Type = "Helmet"
                        },
                        new
                        {
                            Id = 16,
                            Size = "XXL",
                            Type = "KneePads"
                        },
                        new
                        {
                            Id = 17,
                            Size = "M",
                            Type = "Helmet"
                        },
                        new
                        {
                            Id = 18,
                            Size = "M",
                            Type = "KneePads"
                        },
                        new
                        {
                            Id = 19,
                            Size = "M",
                            Type = "Helmet"
                        },
                        new
                        {
                            Id = 20,
                            Size = "L",
                            Type = "Gloves"
                        },
                        new
                        {
                            Id = 21,
                            Size = "XXL",
                            Type = "Gloves"
                        },
                        new
                        {
                            Id = 22,
                            Size = "XXL",
                            Type = "KneePads"
                        },
                        new
                        {
                            Id = 23,
                            Size = "M",
                            Type = "Helmet"
                        },
                        new
                        {
                            Id = 24,
                            Size = "M",
                            Type = "Gloves"
                        },
                        new
                        {
                            Id = 25,
                            Size = "L",
                            Type = "Gloves"
                        },
                        new
                        {
                            Id = 26,
                            Size = "XXL",
                            Type = "Helmet"
                        },
                        new
                        {
                            Id = 27,
                            Size = "XXL",
                            Type = "Gloves"
                        },
                        new
                        {
                            Id = 28,
                            Size = "XL",
                            Type = "Helmet"
                        },
                        new
                        {
                            Id = 29,
                            Size = "S",
                            Type = "Gloves"
                        },
                        new
                        {
                            Id = 30,
                            Size = "S",
                            Type = "Gloves"
                        });
                });

            modelBuilder.Entity("RentalApp.Shared.Models.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EquipmentDamaged")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("ScheduledEndDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("EquipmentId");

                    b.ToTable("Rentals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientId = 4,
                            EquipmentDamaged = false,
                            EquipmentId = 11,
                            ScheduledEndDate = new DateTimeOffset(new DateTime(2022, 6, 19, 12, 12, 33, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            StartDate = new DateTimeOffset(new DateTime(2022, 6, 13, 12, 12, 33, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 2,
                            ClientId = 1,
                            EndDate = new DateTimeOffset(new DateTime(2022, 3, 30, 9, 11, 40, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            EquipmentDamaged = true,
                            EquipmentId = 2,
                            ScheduledEndDate = new DateTimeOffset(new DateTime(2022, 3, 30, 9, 11, 40, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            StartDate = new DateTimeOffset(new DateTime(2022, 3, 27, 9, 11, 40, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 3,
                            ClientId = 1,
                            EndDate = new DateTimeOffset(new DateTime(2022, 9, 10, 10, 43, 38, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            EquipmentDamaged = false,
                            EquipmentId = 1,
                            ScheduledEndDate = new DateTimeOffset(new DateTime(2022, 9, 10, 10, 43, 38, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            StartDate = new DateTimeOffset(new DateTime(2022, 9, 10, 10, 43, 38, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 4,
                            ClientId = 6,
                            EndDate = new DateTimeOffset(new DateTime(2022, 5, 28, 23, 33, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            EquipmentDamaged = true,
                            EquipmentId = 10,
                            ScheduledEndDate = new DateTimeOffset(new DateTime(2022, 5, 27, 23, 33, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            StartDate = new DateTimeOffset(new DateTime(2022, 5, 25, 23, 33, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 5,
                            ClientId = 1,
                            EndDate = new DateTimeOffset(new DateTime(2023, 3, 26, 5, 0, 34, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            EquipmentDamaged = false,
                            EquipmentId = 1,
                            ScheduledEndDate = new DateTimeOffset(new DateTime(2023, 3, 25, 5, 0, 34, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            StartDate = new DateTimeOffset(new DateTime(2023, 3, 25, 5, 0, 34, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 6,
                            ClientId = 11,
                            EndDate = new DateTimeOffset(new DateTime(2023, 6, 3, 7, 55, 37, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            EquipmentDamaged = false,
                            EquipmentId = 4,
                            ScheduledEndDate = new DateTimeOffset(new DateTime(2023, 6, 3, 7, 55, 37, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            StartDate = new DateTimeOffset(new DateTime(2023, 6, 2, 7, 55, 37, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 7,
                            ClientId = 1,
                            EndDate = new DateTimeOffset(new DateTime(2022, 2, 4, 7, 42, 18, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            EquipmentDamaged = true,
                            EquipmentId = 12,
                            ScheduledEndDate = new DateTimeOffset(new DateTime(2022, 2, 4, 7, 42, 18, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            StartDate = new DateTimeOffset(new DateTime(2022, 1, 28, 7, 42, 18, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 8,
                            ClientId = 2,
                            EndDate = new DateTimeOffset(new DateTime(2022, 10, 13, 0, 53, 3, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            EquipmentDamaged = true,
                            EquipmentId = 1,
                            ScheduledEndDate = new DateTimeOffset(new DateTime(2022, 10, 12, 0, 53, 3, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            StartDate = new DateTimeOffset(new DateTime(2022, 10, 10, 0, 53, 3, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 9,
                            ClientId = 6,
                            EndDate = new DateTimeOffset(new DateTime(2022, 6, 14, 18, 53, 37, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            EquipmentDamaged = false,
                            EquipmentId = 10,
                            ScheduledEndDate = new DateTimeOffset(new DateTime(2022, 6, 14, 18, 53, 37, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            StartDate = new DateTimeOffset(new DateTime(2022, 6, 10, 18, 53, 37, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 10,
                            ClientId = 1,
                            EquipmentDamaged = false,
                            EquipmentId = 9,
                            ScheduledEndDate = new DateTimeOffset(new DateTime(2022, 8, 16, 0, 7, 38, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            StartDate = new DateTimeOffset(new DateTime(2022, 8, 10, 0, 7, 38, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 11,
                            ClientId = 4,
                            EquipmentDamaged = false,
                            EquipmentId = 6,
                            ScheduledEndDate = new DateTimeOffset(new DateTime(2022, 1, 24, 21, 2, 29, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            StartDate = new DateTimeOffset(new DateTime(2022, 1, 23, 21, 2, 29, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("RentalApp.Shared.Models.Equipment.Skates.IceSkates", b =>
                {
                    b.HasBaseType("RentalApp.Shared.Models.Equipment.SportsEquipment");

                    b.Property<string>("BladeMaterial")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("HasToePick")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("IceSkates");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            HourlyFee = 3m,
                            IsFunctional = true,
                            Purpose = "Performance",
                            Size = 38m,
                            BladeMaterial = "Steel",
                            HasToePick = true
                        },
                        new
                        {
                            Id = 7,
                            HourlyFee = 4m,
                            IsFunctional = false,
                            Purpose = "Figure",
                            Size = 47m,
                            BladeMaterial = "Carbon Fiber",
                            HasToePick = true
                        },
                        new
                        {
                            Id = 9,
                            HourlyFee = 2m,
                            IsFunctional = true,
                            Purpose = "Performance",
                            Size = 38m,
                            BladeMaterial = "Steel",
                            HasToePick = true
                        },
                        new
                        {
                            Id = 10,
                            HourlyFee = 5m,
                            IsFunctional = false,
                            Purpose = "Hockey",
                            Size = 43m,
                            BladeMaterial = "Carbon Fiber",
                            HasToePick = true
                        },
                        new
                        {
                            Id = 11,
                            HourlyFee = 4m,
                            IsFunctional = false,
                            Purpose = "Hockey",
                            Size = 47m,
                            BladeMaterial = "Steel",
                            HasToePick = false
                        },
                        new
                        {
                            Id = 13,
                            HourlyFee = 2m,
                            IsFunctional = true,
                            Purpose = "Figure",
                            Size = 42m,
                            BladeMaterial = "Steel",
                            HasToePick = false
                        },
                        new
                        {
                            Id = 15,
                            HourlyFee = 3m,
                            IsFunctional = false,
                            Purpose = "Performance",
                            Size = 37m,
                            BladeMaterial = "Aluminum",
                            HasToePick = false
                        },
                        new
                        {
                            Id = 16,
                            HourlyFee = 5m,
                            IsFunctional = true,
                            Purpose = "Hockey",
                            Size = 45m,
                            BladeMaterial = "Steel",
                            HasToePick = false
                        },
                        new
                        {
                            Id = 19,
                            HourlyFee = 3m,
                            IsFunctional = true,
                            Purpose = "Figure",
                            Size = 42m,
                            BladeMaterial = "Plastic",
                            HasToePick = true
                        });
                });

            modelBuilder.Entity("RentalApp.Shared.Models.Equipment.Skates.InlineSkates", b =>
                {
                    b.HasBaseType("RentalApp.Shared.Models.Equipment.SportsEquipment");

                    b.Property<string>("BearingType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("WheelDiameter")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("InlineSkates");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            HourlyFee = 5m,
                            IsFunctional = true,
                            Purpose = "Figure",
                            Size = 47m,
                            BearingType = "ABEC-5",
                            WheelDiameter = 15m
                        },
                        new
                        {
                            Id = 6,
                            HourlyFee = 3m,
                            IsFunctional = true,
                            Purpose = "Hockey",
                            Size = 47m,
                            BearingType = "ABEC-9",
                            WheelDiameter = 88m
                        },
                        new
                        {
                            Id = 8,
                            HourlyFee = 4m,
                            IsFunctional = true,
                            Purpose = "Performance",
                            Size = 42m,
                            BearingType = "ABEC-9",
                            WheelDiameter = 30m
                        },
                        new
                        {
                            Id = 12,
                            HourlyFee = 2m,
                            IsFunctional = true,
                            Purpose = "Performance",
                            Size = 41m,
                            BearingType = "ABEC-7",
                            WheelDiameter = 38m
                        },
                        new
                        {
                            Id = 18,
                            HourlyFee = 2m,
                            IsFunctional = false,
                            Purpose = "Hockey",
                            Size = 45m,
                            BearingType = "ABEC-3",
                            WheelDiameter = 22m
                        });
                });

            modelBuilder.Entity("RentalApp.Shared.Models.Equipment.Skates.RollerSkates", b =>
                {
                    b.HasBaseType("RentalApp.Shared.Models.Equipment.SportsEquipment");

                    b.Property<int>("WheelHardness")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("RollerSkates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HourlyFee = 3m,
                            IsFunctional = true,
                            Purpose = "Performance",
                            Size = 44m,
                            WheelHardness = 36
                        },
                        new
                        {
                            Id = 2,
                            HourlyFee = 2m,
                            IsFunctional = false,
                            Purpose = "Figure",
                            Size = 46m,
                            WheelHardness = 75
                        },
                        new
                        {
                            Id = 3,
                            HourlyFee = 4m,
                            IsFunctional = true,
                            Purpose = "Figure",
                            Size = 47m,
                            WheelHardness = 10
                        },
                        new
                        {
                            Id = 14,
                            HourlyFee = 5m,
                            IsFunctional = false,
                            Purpose = "Figure",
                            Size = 42m,
                            WheelHardness = 91
                        },
                        new
                        {
                            Id = 20,
                            HourlyFee = 2m,
                            IsFunctional = true,
                            Purpose = "Hockey",
                            Size = 43m,
                            WheelHardness = 89
                        });
                });

            modelBuilder.Entity("ProtectiveGearRental", b =>
                {
                    b.HasOne("RentalApp.Shared.Models.ProtectiveGear", null)
                        .WithMany()
                        .HasForeignKey("ProtectiveGearId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentalApp.Shared.Models.Rental", null)
                        .WithMany()
                        .HasForeignKey("RentalsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RentalApp.Shared.Models.Insurance", b =>
                {
                    b.HasOne("RentalApp.Shared.Models.Rental", "Rental")
                        .WithOne("Insurance")
                        .HasForeignKey("RentalApp.Shared.Models.Insurance", "RentalId");

                    b.Navigation("Rental");
                });

            modelBuilder.Entity("RentalApp.Shared.Models.Person", b =>
                {
                    b.HasOne("RentalApp.Shared.Models.Person", "Supervisor")
                        .WithMany("Subordinates")
                        .HasForeignKey("SupervisorId");

                    b.Navigation("Supervisor");
                });

            modelBuilder.Entity("RentalApp.Shared.Models.Rental", b =>
                {
                    b.HasOne("RentalApp.Shared.Models.Person", "Client")
                        .WithMany("Rentals")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentalApp.Shared.Models.Equipment.SportsEquipment", "Equipment")
                        .WithMany("Rentals")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("RentalApp.Shared.Models.Equipment.SportsEquipment", b =>
                {
                    b.Navigation("Rentals");
                });

            modelBuilder.Entity("RentalApp.Shared.Models.Person", b =>
                {
                    b.Navigation("Rentals");

                    b.Navigation("Subordinates");
                });

            modelBuilder.Entity("RentalApp.Shared.Models.Rental", b =>
                {
                    b.Navigation("Insurance");
                });
#pragma warning restore 612, 618
        }
    }
}