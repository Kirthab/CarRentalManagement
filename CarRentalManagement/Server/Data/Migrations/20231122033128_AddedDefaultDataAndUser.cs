using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "a6c5dff1-4d7b-4dad-a5be-4e09944b32f2", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAELuG7ocqK4c5VfH15ginL6MOKjT8Kc9TL5Gd9zNK8OJvZ2d3hD7OOV3J5UXQpVpmmg==", null, false, "a2c8bfd6-774c-49a9-b2c5-e0e791a1e8bb", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 11, 31, 28, 634, DateTimeKind.Local).AddTicks(3150), new DateTime(2023, 11, 22, 11, 31, 28, 634, DateTimeKind.Local).AddTicks(3160), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 11, 31, 28, 634, DateTimeKind.Local).AddTicks(3163), new DateTime(2023, 11, 22, 11, 31, 28, 634, DateTimeKind.Local).AddTicks(3164), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 11, 31, 28, 634, DateTimeKind.Local).AddTicks(3565), new DateTime(2023, 11, 22, 11, 31, 28, 634, DateTimeKind.Local).AddTicks(3568), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 11, 31, 28, 634, DateTimeKind.Local).AddTicks(3570), new DateTime(2023, 11, 22, 11, 31, 28, 634, DateTimeKind.Local).AddTicks(3571), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 11, 31, 28, 634, DateTimeKind.Local).AddTicks(3838), new DateTime(2023, 11, 22, 11, 31, 28, 634, DateTimeKind.Local).AddTicks(3839), "3 series", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 11, 31, 28, 634, DateTimeKind.Local).AddTicks(3841), new DateTime(2023, 11, 22, 11, 31, 28, 634, DateTimeKind.Local).AddTicks(3842), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 22, 11, 31, 28, 634, DateTimeKind.Local).AddTicks(3843), new DateTime(2023, 11, 22, 11, 31, 28, 634, DateTimeKind.Local).AddTicks(3843), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 22, 11, 31, 28, 634, DateTimeKind.Local).AddTicks(3845), new DateTime(2023, 11, 22, 11, 31, 28, 634, DateTimeKind.Local).AddTicks(3845), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
