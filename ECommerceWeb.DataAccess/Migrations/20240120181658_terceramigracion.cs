using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerceWeb.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class TerceraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Comentarios", "Estado", "Nombre" },
                values: new object[,]
                {
                    { 1, null, true, "Celulares" },
                    { 2, null, true, "Televisores" },
                    { 3, null, true, "Computadoras" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
