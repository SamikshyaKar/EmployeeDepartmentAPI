﻿// <auto-generated />
using System;
using EmployeeDepartmentAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeDepartmentAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230716011529_ModifiedDataMigration")]
    partial class ModifiedDataMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeDepartmentAPI.Models.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentID"));

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("DepartmentID");

                    b.ToTable("Departmentsdb");

                    b.HasData(
                        new
                        {
                            DepartmentID = 1,
                            DepartmentName = "IT"
                        },
                        new
                        {
                            DepartmentID = 2,
                            DepartmentName = "HR"
                        },
                        new
                        {
                            DepartmentID = 3,
                            DepartmentName = "Security"
                        },
                        new
                        {
                            DepartmentID = 4,
                            DepartmentName = "Finance"
                        });
                });

            modelBuilder.Entity("EmployeeDepartmentAPI.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"));

                    b.Property<DateTime>("DateofBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Photopath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Employeesdb");

                    b.HasData(
                        new
                        {
                            EmployeeID = 1111,
                            DateofBirth = new DateTime(2023, 7, 16, 6, 45, 29, 64, DateTimeKind.Local).AddTicks(3721),
                            DepartmentID = 1,
                            Email = "samikshya1@gmail.com",
                            FirstName = "samikshya1",
                            Gender = 1,
                            Lastname = "Kar",
                            Photopath = "Img/Flower1.jpg"
                        },
                        new
                        {
                            EmployeeID = 1112,
                            DateofBirth = new DateTime(2023, 7, 16, 6, 45, 29, 64, DateTimeKind.Local).AddTicks(3741),
                            DepartmentID = 1,
                            Email = "Samikshya2@gmail.com",
                            FirstName = "samikshya2",
                            Gender = 1,
                            Lastname = "Kar",
                            Photopath = "Img/Flower1.jpg"
                        },
                        new
                        {
                            EmployeeID = 1113,
                            DateofBirth = new DateTime(2023, 7, 16, 6, 45, 29, 64, DateTimeKind.Local).AddTicks(3782),
                            DepartmentID = 2,
                            Email = "Samikshya3@gmail.com",
                            FirstName = "samikshya3",
                            Gender = 0,
                            Lastname = "Kar",
                            Photopath = "Img/Flower2.jpg"
                        },
                        new
                        {
                            EmployeeID = 1,
                            DateofBirth = new DateTime(2023, 7, 16, 6, 45, 29, 64, DateTimeKind.Local).AddTicks(3796),
                            DepartmentID = 3,
                            Email = "Samikshya4@gmail.com",
                            FirstName = "samikshya3",
                            Gender = 0,
                            Lastname = "Kar",
                            Photopath = "Img/Flower2.jpg"
                        },
                        new
                        {
                            EmployeeID = 5,
                            DateofBirth = new DateTime(2023, 7, 16, 6, 45, 29, 64, DateTimeKind.Local).AddTicks(3807),
                            DepartmentID = 4,
                            Email = "Samikshya5@gmail.com",
                            FirstName = "samikshya3",
                            Gender = 0,
                            Lastname = "Kar",
                            Photopath = "Img/Flower2.jpg"
                        });
                });

            modelBuilder.Entity("EmployeeDepartmentAPI.Models.Employee", b =>
                {
                    b.HasOne("EmployeeDepartmentAPI.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}
