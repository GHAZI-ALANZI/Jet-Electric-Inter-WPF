using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jet_Electric_DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "ISO", "ISO90001" },
                    { 2, "MSO", "MSO800" },
                    { 3, "ICD", "ICD785" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "FDGH" },
                    { 2, "HWQ " },
                    { 3, "MSSD" }
                });

            migrationBuilder.InsertData(
                table: "SizeTypes",
                columns: new[] { "ID", "Description" },
                values: new object[,]
                {
                    { 1, "KM" },
                    { 2, "M" },
                    { 3, "IC" }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "ID", "Description" },
                values: new object[,]
                {
                    { 1, "ST2100" },
                    { 2, "SK3000 " },
                    { 3, "SU1400" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SizeTypes",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SizeTypes",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SizeTypes",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
