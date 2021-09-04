using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 1, 22, 35, 6, 626, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("d330221b-8576-46eb-a5e4-94c7aa8002e9"),
                column: "ConcurrencyStamp",
                value: "dee7e59b-1240-49e1-b05e-e032c5782241");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("373198e4-a32b-40ac-8505-bf2d07e23b1b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ed368f1d-1398-4ee0-9a7f-c0287a005b6b", "AQAAAAEAACcQAAAAEAVF6srRG4S44e5DLPVxa4UZU4VA6YyQWibYYBpRdHcPiKNUu2zJkWgF+nUpY1GCVg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 4, 17, 51, 22, 52, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 1, 22, 35, 6, 626, DateTimeKind.Local).AddTicks(3770),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("d330221b-8576-46eb-a5e4-94c7aa8002e9"),
                column: "ConcurrencyStamp",
                value: "8a708fea-c997-4a6f-9e7a-2d8fcb2d9346");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("373198e4-a32b-40ac-8505-bf2d07e23b1b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "991c2751-6274-474c-9365-2b6c74e69d64", "AQAAAAEAACcQAAAAEKdYWAABSG3BUEY2MuwY1cVHQadEuuK1Fcp0x+ow8dqDCDfU31SDb2G0sLxNpS7j3w==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 1, 22, 35, 6, 643, DateTimeKind.Local).AddTicks(3618));
        }
    }
}
