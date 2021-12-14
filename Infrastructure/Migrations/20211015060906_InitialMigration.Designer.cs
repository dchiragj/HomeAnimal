﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(HomeAnimalsDbContext))]
    [Migration("20211015060906_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.Cat", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CatchingMouses")
                        .HasColumnType("bit");

                    b.Property<string>("Characteristics")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Colour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("NoOfFeeding")
                        .HasColumnType("float");

                    b.Property<string>("OwnerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Vaccination")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Cat");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Age = 368,
                            Breed = "2",
                            CatchingMouses = true,
                            Characteristics = "brown-big",
                            Colour = "black",
                            DOB = new DateTime(2021, 10, 15, 11, 39, 5, 692, DateTimeKind.Local).AddTicks(6802),
                            Gender = "Male",
                            MedicalCondition = "xyz",
                            Name = "Cat1",
                            NoOfFeeding = 1.0,
                            OwnerId = "1",
                            Vaccination = false
                        },
                        new
                        {
                            Id = "2",
                            Age = 455,
                            Breed = "2",
                            CatchingMouses = true,
                            Characteristics = "brown-big",
                            Colour = "black",
                            DOB = new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(506),
                            Gender = "Male",
                            MedicalCondition = "xyz",
                            Name = "Cat2",
                            NoOfFeeding = 1.0,
                            OwnerId = "1",
                            Vaccination = true
                        },
                        new
                        {
                            Id = "3",
                            Age = 455,
                            Breed = "2",
                            CatchingMouses = true,
                            Characteristics = "brown-big",
                            Colour = "black",
                            DOB = new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(654),
                            Gender = "Male",
                            MedicalCondition = "xyz",
                            Name = "Cat3",
                            NoOfFeeding = 1.0,
                            OwnerId = "2",
                            Vaccination = true
                        },
                        new
                        {
                            Id = "4",
                            Age = 455,
                            Breed = "2",
                            CatchingMouses = true,
                            Characteristics = "brown-big",
                            Colour = "black",
                            DOB = new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(685),
                            Gender = "Male",
                            MedicalCondition = "xyz",
                            Name = "Cat4",
                            NoOfFeeding = 1.0,
                            OwnerId = "3",
                            Vaccination = true
                        },
                        new
                        {
                            Id = "5",
                            Age = 455,
                            Breed = "2",
                            CatchingMouses = true,
                            Characteristics = "brown-big",
                            Colour = "black",
                            DOB = new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(709),
                            Gender = "Male",
                            MedicalCondition = "xyz",
                            Name = "Cat5",
                            NoOfFeeding = 1.0,
                            OwnerId = "3",
                            Vaccination = true
                        },
                        new
                        {
                            Id = "6",
                            Age = 455,
                            Breed = "2",
                            CatchingMouses = true,
                            Characteristics = "brown-big",
                            Colour = "black",
                            DOB = new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(736),
                            Gender = "Male",
                            MedicalCondition = "xyz",
                            Name = "Cat6",
                            NoOfFeeding = 1.0,
                            OwnerId = "3",
                            Vaccination = true
                        },
                        new
                        {
                            Id = "7",
                            Age = 455,
                            Breed = "2",
                            CatchingMouses = true,
                            Characteristics = "brown-big",
                            Colour = "black",
                            DOB = new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(761),
                            Gender = "Male",
                            MedicalCondition = "xyz",
                            Name = "Cat7",
                            NoOfFeeding = 1.0,
                            OwnerId = "4",
                            Vaccination = true
                        },
                        new
                        {
                            Id = "8",
                            Age = 455,
                            Breed = "2",
                            CatchingMouses = true,
                            Characteristics = "brown-big",
                            Colour = "black",
                            DOB = new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(785),
                            Gender = "Male",
                            MedicalCondition = "xyz",
                            Name = "Cat8",
                            NoOfFeeding = 1.0,
                            OwnerId = "4",
                            Vaccination = true
                        },
                        new
                        {
                            Id = "9",
                            Age = 455,
                            Breed = "2",
                            CatchingMouses = true,
                            Characteristics = "brown-big",
                            Colour = "black",
                            DOB = new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(808),
                            Gender = "Male",
                            MedicalCondition = "xyz",
                            Name = "Cat9",
                            NoOfFeeding = 1.0,
                            OwnerId = "5",
                            Vaccination = true
                        },
                        new
                        {
                            Id = "10",
                            Age = 455,
                            Breed = "2",
                            CatchingMouses = true,
                            Characteristics = "brown-big",
                            Colour = "black",
                            DOB = new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(839),
                            Gender = "Male",
                            MedicalCondition = "xyz",
                            Name = "Cat10",
                            NoOfFeeding = 1.0,
                            OwnerId = "5",
                            Vaccination = true
                        });
                });

            modelBuilder.Entity("Models.Dog", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Characteristics")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Colour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LevelOfTraining")
                        .HasColumnType("int");

                    b.Property<string>("MedicalCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("NoOfFeeding")
                        .HasColumnType("float");

                    b.Property<string>("OwnerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SupposedHeight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Vaccination")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Dog");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Age = 422,
                            Breed = "xyz",
                            Characteristics = "brown-big",
                            Colour = "black",
                            DOB = new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(1817),
                            Gender = "Male",
                            LevelOfTraining = 5,
                            MedicalCondition = "xyz",
                            Name = "Dog1",
                            NoOfFeeding = 1.0,
                            OwnerId = "1",
                            SupposedHeight = "20cm",
                            Vaccination = true
                        },
                        new
                        {
                            Id = "2",
                            Age = 422,
                            Breed = "xyz",
                            Characteristics = "brown-big",
                            Colour = "black",
                            DOB = new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5193),
                            Gender = "Male",
                            LevelOfTraining = 5,
                            MedicalCondition = "xyz",
                            Name = "Dog2",
                            NoOfFeeding = 1.0,
                            OwnerId = "1",
                            SupposedHeight = "20cm",
                            Vaccination = true
                        },
                        new
                        {
                            Id = "3",
                            Age = 422,
                            Breed = "xyz",
                            Characteristics = "brown-big",
                            Colour = "black",
                            DOB = new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5345),
                            Gender = "Male",
                            LevelOfTraining = 5,
                            MedicalCondition = "xyz",
                            Name = "Dog3",
                            NoOfFeeding = 1.0,
                            OwnerId = "2",
                            SupposedHeight = "20cm",
                            Vaccination = true
                        },
                        new
                        {
                            Id = "4",
                            Age = 422,
                            Breed = "xyz",
                            Characteristics = "brown-big",
                            Colour = "black",
                            DOB = new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5376),
                            Gender = "Male",
                            LevelOfTraining = 5,
                            MedicalCondition = "xyz",
                            Name = "Dog4",
                            NoOfFeeding = 1.0,
                            OwnerId = "3",
                            SupposedHeight = "20cm",
                            Vaccination = true
                        },
                        new
                        {
                            Id = "5",
                            Age = 422,
                            Breed = "xyz",
                            Characteristics = "brown-big",
                            Colour = "black",
                            DOB = new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5400),
                            Gender = "Male",
                            LevelOfTraining = 5,
                            MedicalCondition = "xyz",
                            Name = "Dog5",
                            NoOfFeeding = 1.0,
                            OwnerId = "3",
                            SupposedHeight = "20cm",
                            Vaccination = true
                        },
                        new
                        {
                            Id = "6",
                            Age = 422,
                            Breed = "xyz",
                            Characteristics = "brown-big",
                            Colour = "black",
                            DOB = new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5428),
                            Gender = "Male",
                            LevelOfTraining = 5,
                            MedicalCondition = "xyz",
                            Name = "Dog6",
                            NoOfFeeding = 1.0,
                            OwnerId = "3",
                            SupposedHeight = "20cm",
                            Vaccination = true
                        },
                        new
                        {
                            Id = "7",
                            Age = 422,
                            Breed = "xyz",
                            Characteristics = "brown-big",
                            Colour = "black",
                            DOB = new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5453),
                            Gender = "Male",
                            LevelOfTraining = 5,
                            MedicalCondition = "xyz",
                            Name = "Dog7",
                            NoOfFeeding = 1.0,
                            OwnerId = "4",
                            SupposedHeight = "20cm",
                            Vaccination = true
                        },
                        new
                        {
                            Id = "8",
                            Age = 422,
                            Breed = "xyz",
                            Characteristics = "brown-big",
                            Colour = "black",
                            DOB = new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5534),
                            Gender = "Male",
                            LevelOfTraining = 5,
                            MedicalCondition = "xyz",
                            Name = "Dog8",
                            NoOfFeeding = 1.0,
                            OwnerId = "4",
                            SupposedHeight = "20cm",
                            Vaccination = true
                        },
                        new
                        {
                            Id = "9",
                            Age = 422,
                            Breed = "xyz",
                            Characteristics = "brown-big",
                            Colour = "black",
                            DOB = new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5563),
                            Gender = "Male",
                            LevelOfTraining = 5,
                            MedicalCondition = "xyz",
                            Name = "Dog9",
                            NoOfFeeding = 1.0,
                            OwnerId = "5",
                            SupposedHeight = "20cm",
                            Vaccination = true
                        },
                        new
                        {
                            Id = "10",
                            Age = 422,
                            Breed = "xyz",
                            Characteristics = "brown-big",
                            Colour = "black",
                            DOB = new DateTime(2021, 10, 15, 11, 39, 5, 693, DateTimeKind.Local).AddTicks(5591),
                            Gender = "Male",
                            LevelOfTraining = 5,
                            MedicalCondition = "xyz",
                            Name = "Dog10",
                            NoOfFeeding = 1.0,
                            OwnerId = "5",
                            SupposedHeight = "20cm",
                            Vaccination = true
                        });
                });

            modelBuilder.Entity("Models.Owner", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoOfPets")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Owner");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Address = "New York",
                            Age = 366,
                            Dob = new DateTime(2021, 10, 15, 11, 39, 5, 690, DateTimeKind.Local).AddTicks(2419),
                            Gender = "Male",
                            Name = "John",
                            NoOfPets = 4,
                            Phone = "00000"
                        },
                        new
                        {
                            Id = "2",
                            Address = "New York",
                            Age = 560,
                            Dob = new DateTime(2021, 10, 15, 11, 39, 5, 692, DateTimeKind.Local).AddTicks(5222),
                            Gender = "Male",
                            Name = "Ryan",
                            NoOfPets = 2,
                            Phone = "00000"
                        },
                        new
                        {
                            Id = "3",
                            Address = "New York",
                            Age = 560,
                            Dob = new DateTime(2021, 10, 15, 11, 39, 5, 692, DateTimeKind.Local).AddTicks(5443),
                            Gender = "Male",
                            Name = "Smith",
                            NoOfPets = 6,
                            Phone = "00000"
                        },
                        new
                        {
                            Id = "4",
                            Address = "New York",
                            Age = 560,
                            Dob = new DateTime(2021, 10, 15, 11, 39, 5, 692, DateTimeKind.Local).AddTicks(5476),
                            Gender = "Female",
                            Name = "Riya",
                            NoOfPets = 4,
                            Phone = "00000"
                        },
                        new
                        {
                            Id = "5",
                            Address = "New York",
                            Age = 560,
                            Dob = new DateTime(2021, 10, 15, 11, 39, 5, 692, DateTimeKind.Local).AddTicks(5502),
                            Gender = "Female",
                            Name = "Kriva",
                            NoOfPets = 4,
                            Phone = "00000"
                        });
                });

            modelBuilder.Entity("Models.Cat", b =>
                {
                    b.HasOne("Models.Owner", "Owner")
                        .WithMany("Cat")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Models.Dog", b =>
                {
                    b.HasOne("Models.Owner", "Owner")
                        .WithMany("Dog")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Models.Owner", b =>
                {
                    b.Navigation("Cat");

                    b.Navigation("Dog");
                });
#pragma warning restore 612, 618
        }
    }
}