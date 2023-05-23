using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeDepartmentAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departmentsdb",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmentsdb", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "Employeesdb",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Photopath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateofBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employeesdb", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employeesdb_Departmentsdb_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departmentsdb",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departmentsdb",
                columns: new[] { "DepartmentID", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "HR" },
                    { 3, "Security" },
                    { 4, "Finance" }
                });

            migrationBuilder.InsertData(
                table: "Employeesdb",
                columns: new[] { "EmployeeID", "DateofBirth", "DepartmentID", "FirstName", "Gender", "Lastname", "Photopath" },
                values: new object[,]
                {
                    { 1111, new DateTime(2023, 5, 23, 16, 30, 33, 181, DateTimeKind.Local).AddTicks(4151), 1, "samikshya1", 1, "Kar", "Img/Flower1.jpg" },
                    { 1112, new DateTime(2023, 5, 23, 16, 30, 33, 181, DateTimeKind.Local).AddTicks(4182), 1, "samikshya2", 1, "Kar", "Img/Flower1.jpg" },
                    { 1113, new DateTime(2023, 5, 23, 16, 30, 33, 181, DateTimeKind.Local).AddTicks(4194), 2, "samikshya3", 0, "Kar", "Img/Flower2.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employeesdb_DepartmentID",
                table: "Employeesdb",
                column: "DepartmentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employeesdb");

            migrationBuilder.DropTable(
                name: "Departmentsdb");
        }
    }
}
