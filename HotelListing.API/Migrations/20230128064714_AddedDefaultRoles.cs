using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d77b9855-7ccc-4881-98a6-3134dc16ad41", "dd7b667f-8456-4dca-ac6e-50e8b2c3f21e", "Administrater", "ADMINISTRATER" },
                    { "e833c677-6c51-477d-9736-df616185e2c0", "f5890b31-f812-46f9-a88f-ba0557581a83", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d77b9855-7ccc-4881-98a6-3134dc16ad41");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e833c677-6c51-477d-9736-df616185e2c0");
        }
    }
}
