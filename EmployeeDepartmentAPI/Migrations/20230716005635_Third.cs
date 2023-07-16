using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeDepartmentAPI.Migrations
{
    /// <inheritdoc />
    public partial class Third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employeesdb",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employeesdb");

            migrationBuilder.UpdateData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1111,
                column: "DateofBirth",
                value: new DateTime(2023, 7, 15, 22, 48, 30, 64, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1112,
                column: "DateofBirth",
                value: new DateTime(2023, 7, 15, 22, 48, 30, 64, DateTimeKind.Local).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1113,
                column: "DateofBirth",
                value: new DateTime(2023, 7, 15, 22, 48, 30, 64, DateTimeKind.Local).AddTicks(4958));
        }
    }
}
