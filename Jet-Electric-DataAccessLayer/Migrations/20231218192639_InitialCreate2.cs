using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jet_Electric_DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Designations",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Director" },
                    { 2, "Manager" },
                    { 3, "HR-Manager" },
                    { 4, "Sales-Manager" },
                    { 5, "Finance Manager" },
                    { 6, "Receptionistr" },
                    { 7, "IT-Support-Specialist" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeStatus",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "worker" },
                    { 2, "Employee" },
                    { 3, "Self-employed" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EmployeeStatus",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeStatus",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmployeeStatus",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
