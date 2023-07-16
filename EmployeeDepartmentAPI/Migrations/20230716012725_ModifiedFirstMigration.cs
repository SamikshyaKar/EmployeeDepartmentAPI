using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeDepartmentAPI.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedFirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1111,
                column: "DateofBirth",
                value: new DateTime(2023, 7, 16, 6, 57, 25, 187, DateTimeKind.Local).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1112,
                column: "DateofBirth",
                value: new DateTime(2023, 7, 16, 6, 57, 25, 187, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1113,
                column: "DateofBirth",
                value: new DateTime(2023, 7, 16, 6, 57, 25, 187, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.InsertData(
                table: "Employeesdb",
                columns: new[] { "EmployeeID", "DateofBirth", "DepartmentID", "Email", "FirstName", "Gender", "Lastname", "Photopath" },
                values: new object[,]
                {
                    { 1114, new DateTime(2023, 7, 16, 6, 57, 25, 187, DateTimeKind.Local).AddTicks(5177), 3, "Samikshya4@gmail.com", "samikshya3", 0, "Kar", "Img/Flower2.jpg" },
                    { 1115, new DateTime(2023, 7, 16, 6, 57, 25, 187, DateTimeKind.Local).AddTicks(5188), 4, "Samikshya5@gmail.com", "samikshya3", 0, "Kar", "Img/Flower2.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1115);

            migrationBuilder.UpdateData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1111,
                column: "DateofBirth",
                value: new DateTime(2023, 7, 16, 6, 45, 29, 64, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1112,
                column: "DateofBirth",
                value: new DateTime(2023, 7, 16, 6, 45, 29, 64, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1113,
                column: "DateofBirth",
                value: new DateTime(2023, 7, 16, 6, 45, 29, 64, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.InsertData(
                table: "Employeesdb",
                columns: new[] { "EmployeeID", "DateofBirth", "DepartmentID", "Email", "FirstName", "Gender", "Lastname", "Photopath" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 16, 6, 45, 29, 64, DateTimeKind.Local).AddTicks(3796), 3, "Samikshya4@gmail.com", "samikshya3", 0, "Kar", "Img/Flower2.jpg" },
                    { 5, new DateTime(2023, 7, 16, 6, 45, 29, 64, DateTimeKind.Local).AddTicks(3807), 4, "Samikshya5@gmail.com", "samikshya3", 0, "Kar", "Img/Flower2.jpg" }
                });
        }
    }
}
