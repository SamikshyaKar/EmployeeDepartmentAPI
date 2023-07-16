using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeDepartmentAPI.Migrations
{
    /// <inheritdoc />
    public partial class ExpInitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1111,
                column: "DateofBirth",
                value: new DateTime(2023, 7, 16, 7, 2, 29, 55, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1112,
                column: "DateofBirth",
                value: new DateTime(2023, 7, 16, 7, 2, 29, 55, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1113,
                column: "DateofBirth",
                value: new DateTime(2023, 7, 16, 7, 2, 29, 55, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1114,
                column: "DateofBirth",
                value: new DateTime(2023, 7, 16, 7, 2, 29, 55, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1115,
                column: "DateofBirth",
                value: new DateTime(2023, 7, 16, 7, 2, 29, 55, DateTimeKind.Local).AddTicks(2191));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1114,
                column: "DateofBirth",
                value: new DateTime(2023, 7, 16, 6, 57, 25, 187, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1115,
                column: "DateofBirth",
                value: new DateTime(2023, 7, 16, 6, 57, 25, 187, DateTimeKind.Local).AddTicks(5188));
        }
    }
}
