﻿// <auto-generated />
using System;
using EmployeeDepartmentAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeDepartmentAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeDepartmentAPI.Models.Departments", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentID"));

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                            DateofBirth = new DateTime(2023, 5, 23, 16, 30, 33, 181, DateTimeKind.Local).AddTicks(4151),
                            DepartmentID = 1,
                            FirstName = "samikshya1",
                            Gender = 1,
                            Lastname = "Kar",
                            Photopath = "Img/Flower1.jpg"
                        },
                        new
                        {
                            EmployeeID = 1112,
                            DateofBirth = new DateTime(2023, 5, 23, 16, 30, 33, 181, DateTimeKind.Local).AddTicks(4182),
                            DepartmentID = 1,
                            FirstName = "samikshya2",
                            Gender = 1,
                            Lastname = "Kar",
                            Photopath = "Img/Flower1.jpg"
                        },
                        new
                        {
                            EmployeeID = 1113,
                            DateofBirth = new DateTime(2023, 5, 23, 16, 30, 33, 181, DateTimeKind.Local).AddTicks(4194),
                            DepartmentID = 2,
                            FirstName = "samikshya3",
                            Gender = 0,
                            Lastname = "Kar",
                            Photopath = "Img/Flower2.jpg"
                        });
                });

            modelBuilder.Entity("EmployeeDepartmentAPI.Models.Employee", b =>
                {
                    b.HasOne("EmployeeDepartmentAPI.Models.Departments", "Department")
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
