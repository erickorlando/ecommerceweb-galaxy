using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerceWeb.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DataParaMarcas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "Id", "Estado", "Nombre" },
                values: new object[,]
                {
                    { 1, true, "Samsung" },
                    { 2, true, "Apple" },
                    { 3, true, "Xiaomi" },
                    { 4, true, "LG" },
                    { 5, true, "Sony" },
                    { 6, true, "Oster" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
