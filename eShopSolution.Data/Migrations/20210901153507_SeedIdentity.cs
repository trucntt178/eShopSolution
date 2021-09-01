using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 1, 22, 35, 6, 626, DateTimeKind.Local).AddTicks(3770),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 1, 22, 1, 45, 498, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("d330221b-8576-46eb-a5e4-94c7aa8002e9"), "8a708fea-c997-4a6f-9e7a-2d8fcb2d9346", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("d330221b-8576-46eb-a5e4-94c7aa8002e9"), new Guid("373198e4-a32b-40ac-8505-bf2d07e23b1b") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("373198e4-a32b-40ac-8505-bf2d07e23b1b"), 0, "991c2751-6274-474c-9365-2b6c74e69d64", new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "trucntt178@gmail.com", true, "Truc", "Nguyen", false, null, "trucntt178@gmail.com", "admin", "AQAAAAEAACcQAAAAEKdYWAABSG3BUEY2MuwY1cVHQadEuuK1Fcp0x+ow8dqDCDfU31SDb2G0sLxNpS7j3w==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 1, 22, 35, 6, 643, DateTimeKind.Local).AddTicks(3618));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("d330221b-8576-46eb-a5e4-94c7aa8002e9"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d330221b-8576-46eb-a5e4-94c7aa8002e9"), new Guid("373198e4-a32b-40ac-8505-bf2d07e23b1b") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("373198e4-a32b-40ac-8505-bf2d07e23b1b"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 1, 22, 1, 45, 498, DateTimeKind.Local).AddTicks(9662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 1, 22, 35, 6, 626, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 1, 22, 1, 45, 514, DateTimeKind.Local).AddTicks(8583));
        }
    }
}
