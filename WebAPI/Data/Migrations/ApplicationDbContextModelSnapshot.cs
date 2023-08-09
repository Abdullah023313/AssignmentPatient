﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.DbEntities.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CitizenId")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ContactPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("ContactRelation")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

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
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<DateTime>("RecordCreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("510d7d93-5bd6-41ff-9c57-7abffa1c924a"),
                            Address1 = "Apartment 4A",
                            Address2 = "Building XYZ",
                            BirthDate = new DateTime(1985, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
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
                            RecordCreationDate = new DateTime(2023, 8, 9, 22, 16, 31, 366, DateTimeKind.Local).AddTicks(9696),
                            Street = "123 Main Street"
                        },
                        new
                        {
                            Id = new Guid("f6798e76-ca73-4f07-acf4-0ea08f4ace2a"),
                            Address1 = "Suite 8B",
                            Address2 = "Tower ABC",
                            BirthDate = new DateTime(1990, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
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
                            RecordCreationDate = new DateTime(2023, 8, 9, 22, 16, 31, 369, DateTimeKind.Local).AddTicks(513),
                            Street = "456 Elm Street"
                        },
                        new
                        {
                            Id = new Guid("10bde430-4346-4c40-a537-e0e039cf0a12"),
                            Address1 = "Flat 3C",
                            Address2 = "Manor Gardens",
                            BirthDate = new DateTime(1998, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CitizenId = "789123456",
                            City = "London",
                            ContactPerson = "Sophie Brown",
                            ContactPhone = "333-666-9999",
                            ContactRelation = "Friend",
                            Country = "United Kingdom",
                            Email = "emily.johnson@example.com",
                            FileNo = 1003,
                            FirstVisitDate = new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = 1,
                            Name = "Emily Johnson",
                            Nationality = "United Kingdom",
                            PhoneNumber = "222-555-8888",
                            RecordCreationDate = new DateTime(2023, 8, 9, 22, 16, 31, 369, DateTimeKind.Local).AddTicks(550),
                            Street = "789 Park Lane"
                        },
                        new
                        {
                            Id = new Guid("1780a0b5-6b5e-46cf-9835-aede258c7880"),
                            Address1 = "Unit 12",
                            Address2 = "Coastal Towers",
                            BirthDate = new DateTime(1973, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CitizenId = "555777888",
                            City = "Sydney",
                            ContactPerson = "David Smith",
                            ContactPhone = "888-444-5555",
                            ContactRelation = "Colleague",
                            Country = "Australia",
                            Email = "michael.anderson@example.com",
                            FileNo = 1004,
                            FirstVisitDate = new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = 0,
                            Name = "Michael Anderson",
                            Nationality = "Australia",
                            PhoneNumber = "777-222-3333",
                            RecordCreationDate = new DateTime(2023, 8, 9, 22, 16, 31, 369, DateTimeKind.Local).AddTicks(558),
                            Street = "321 Beach Road"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
