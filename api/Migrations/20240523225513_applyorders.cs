using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class applyorders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40704682-7600-4cb2-8675-2043942230f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd7c9411-507c-4f42-8ef7-7b30d06c3d0a");

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "62915484-df62-4cc7-aaf7-82f753c34cfa", null, "Admin", "ADMIN" },
                    { "fc094892-fe80-456f-a771-2f81cff9c882", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62915484-df62-4cc7-aaf7-82f753c34cfa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc094892-fe80-456f-a771-2f81cff9c882");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "40704682-7600-4cb2-8675-2043942230f8", null, "User", "USER" },
                    { "dd7c9411-507c-4f42-8ef7-7b30d06c3d0a", null, "Admin", "ADMIN" }
                });
        }
    }
}
