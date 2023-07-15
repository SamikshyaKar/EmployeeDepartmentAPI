using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeDepartmentAPI.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "Employeesdb",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employeesdb",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DepartmentName",
                table: "Departmentsdb",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "Employeesdb",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employeesdb",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18);

            migrationBuilder.AlterColumn<string>(
                name: "DepartmentName",
                table: "Departmentsdb",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.UpdateData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1111,
                column: "DateofBirth",
                value: new DateTime(2023, 5, 23, 16, 30, 33, 181, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1112,
                column: "DateofBirth",
                value: new DateTime(2023, 5, 23, 16, 30, 33, 181, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Employeesdb",
                keyColumn: "EmployeeID",
                keyValue: 1113,
                column: "DateofBirth",
                value: new DateTime(2023, 5, 23, 16, 30, 33, 181, DateTimeKind.Local).AddTicks(4194));
        }
    }
}
