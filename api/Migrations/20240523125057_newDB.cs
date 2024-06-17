using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class newDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c0aff6d-ecd2-438b-98fc-4bda4ebc0427");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9ca5e46-656c-4da6-916a-a011b87dbeae");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "58557af8-233f-4ca0-bb4a-35669ff0be26", null, "User", "USER" },
                    { "58952569-fed8-45e2-8d10-0ae2fdd401f7", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58557af8-233f-4ca0-bb4a-35669ff0be26");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58952569-fed8-45e2-8d10-0ae2fdd401f7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1c0aff6d-ecd2-438b-98fc-4bda4ebc0427", null, "Admin", "ADMIN" },
                    { "a9ca5e46-656c-4da6-916a-a011b87dbeae", null, "User", "USER" }
                });
        }
    }
}
