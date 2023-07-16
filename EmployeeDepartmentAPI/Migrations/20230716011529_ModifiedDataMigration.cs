using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeDepartmentAPI.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedDataMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employeesdb",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1111,
                columns: new[] { "DateofBirth", "Email" },
                values: new object[] { new DateTime(2023, 7, 16, 6, 45, 29, 64, DateTimeKind.Local).AddTicks(3721), "samikshya1@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1112,
                columns: new[] { "DateofBirth", "Email" },
                values: new object[] { new DateTime(2023, 7, 16, 6, 45, 29, 64, DateTimeKind.Local).AddTicks(3741), "Samikshya2@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1113,
                columns: new[] { "DateofBirth", "Email" },
                values: new object[] { new DateTime(2023, 7, 16, 6, 45, 29, 64, DateTimeKind.Local).AddTicks(3782), "Samikshya3@gmail.com" });

            migrationBuilder.InsertData(
                table: "Employeesdb",
                columns: new[] { "EmployeeID", "DateofBirth", "DepartmentID", "Email", "FirstName", "Gender", "Lastname", "Photopath" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 16, 6, 45, 29, 64, DateTimeKind.Local).AddTicks(3796), 3, "Samikshya4@gmail.com", "samikshya3", 0, "Kar", "Img/Flower2.jpg" },
                    { 5, new DateTime(2023, 7, 16, 6, 45, 29, 64, DateTimeKind.Local).AddTicks(3807), 4, "Samikshya5@gmail.com", "samikshya3", 0, "Kar", "Img/Flower2.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employeesdb",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1111,
                columns: new[] { "DateofBirth", "Email" },
                values: new object[] { new DateTime(2023, 7, 16, 6, 26, 35, 350, DateTimeKind.Local).AddTicks(8328), "" });

            migrationBuilder.UpdateData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1112,
                columns: new[] { "DateofBirth", "Email" },
                values: new object[] { new DateTime(2023, 7, 16, 6, 26, 35, 350, DateTimeKind.Local).AddTicks(8348), "" });

            migrationBuilder.UpdateData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1113,
                columns: new[] { "DateofBirth", "Email" },
                values: new object[] { new DateTime(2023, 7, 16, 6, 26, 35, 350, DateTimeKind.Local).AddTicks(8355), "" });
        }
    }
}
