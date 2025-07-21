using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobTaskByMofijul.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "Name", "Status" },
                values: new object[,]
                {
                    { 1, 25, "alice@example.com", "Alice", "Active" },
                    { 2, 30, "bob@example.com", "Bob", "Inactive" },
                    { 3, 22, "charlie@example.com", "Charlie", "Active" },
                    { 4, 27, "david@example.com", "David", "Active" },
                    { 5, 29, "eve@example.com", "Eve", "Inactive" },
                    { 6, 31, "frank@example.com", "Frank", "Active" },
                    { 7, 26, "grace@example.com", "Grace", "Inactive" },
                    { 8, 28, "hank@example.com", "Hank", "Active" },
                    { 9, 24, "ivy@example.com", "Ivy", "Inactive" },
                    { 10, 35, "jack@example.com", "Jack", "Active" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
