using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class ChangeColumnType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId1",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WarehouseId",
                keyValue: "5263a176-85ee-4e07-9225-1350a5a42157");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WarehouseId",
                keyValue: "59d70fa4-c7ba-4782-a5eb-2cd91fea6a1b");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WarehouseId",
                keyValue: "5a414234-5f6c-4130-9492-6b6da11a9f88");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WarehouseId",
                keyValue: "694280c6-b721-4d73-9de7-98ee17583b0b");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryId",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "25a86018-ec20-4460-a688-576ac24a138d", "Calle 1 # 2 - 3", "Bodega Central (Centro)" },
                    { "24a1fb3d-dbba-46d7-ba8e-b3ebfe825e2e", "Calle 1 # 2 - 3", "Bodega Milán" },
                    { "8f6227c7-e90c-4a70-ba52-b1116d3718b7", "Calle 1 # 2 - 3", "Bodega Maltería" },
                    { "2bf1bbc0-b1a4-4dcd-bb54-d4b961d49ae8", "Calle 1 # 2 - 3", "Bodega Estadio" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WarehouseId",
                keyValue: "24a1fb3d-dbba-46d7-ba8e-b3ebfe825e2e");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WarehouseId",
                keyValue: "25a86018-ec20-4460-a688-576ac24a138d");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WarehouseId",
                keyValue: "2bf1bbc0-b1a4-4dcd-bb54-d4b961d49ae8");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WarehouseId",
                keyValue: "8f6227c7-e90c-4a70-ba52-b1116d3718b7");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryId1",
                table: "Products",
                type: "nvarchar(10)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "5263a176-85ee-4e07-9225-1350a5a42157", "Calle 1 # 2 - 3", "Bodega Central (Centro)" },
                    { "5a414234-5f6c-4130-9492-6b6da11a9f88", "Calle 1 # 2 - 3", "Bodega Milán" },
                    { "694280c6-b721-4d73-9de7-98ee17583b0b", "Calle 1 # 2 - 3", "Bodega Maltería" },
                    { "59d70fa4-c7ba-4782-a5eb-2cd91fea6a1b", "Calle 1 # 2 - 3", "Bodega Estadio" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId1",
                table: "Products",
                column: "CategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId1",
                table: "Products",
                column: "CategoryId1",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
