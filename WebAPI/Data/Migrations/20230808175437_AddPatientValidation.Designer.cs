﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230808175437_AddPatientValidation")]
    partial class AddPatientValidation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Model.DbEntities.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Address2")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CitizenId")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ContactPhone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("ContactRelation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FileNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("FirstVisitDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("RecordCreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("674a2e8e-a19b-4f99-bdee-c75538fe2c1e"),
                            Address1 = "Apartment 4A",
                            Address2 = "Building XYZ",
                            Birthdate = new DateTime(1985, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CitizenId = "123456789",
                            City = "New York",
                            ContactPerson = "Jane Smith",
                            ContactPhone = "987-654-3210",
                            ContactRelation = "Spouse",
                            Country = "United States",
                            Email = "john.doe@example.com",
                            FileNo = 1001,
                            FirstVisitDate = new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = 0,
                            Name = "John Doe",
                            Nationality = "USA",
                            PhoneNumber = "123-456-7890",
                            RecordCreationDate = new DateTime(2023, 8, 8, 20, 54, 37, 188, DateTimeKind.Local).AddTicks(128),
                            Street = "123 Main Street"
                        },
                        new
                        {
                            Id = new Guid("fb8483ec-6049-4318-92c6-b1006d47f851"),
                            Address1 = "Suite 8B",
                            Address2 = "Tower ABC",
                            Birthdate = new DateTime(1990, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CitizenId = "987654321",
                            City = "Toronto",
                            ContactPerson = "John Doe",
                            ContactPhone = "444-789-1234",
                            ContactRelation = "Sibling",
                            Country = "Canada",
                            Email = "jane.smith@example.com",
                            FileNo = 1002,
                            FirstVisitDate = new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = 1,
                            Name = "Jane Smith",
                            Nationality = "Canada",
                            PhoneNumber = "555-123-4567",
                            RecordCreationDate = new DateTime(2023, 8, 8, 20, 54, 37, 188, DateTimeKind.Local).AddTicks(175),
                            Street = "456 Elm Street"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
