using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "CMS", "Camisetas" },
                    { "CHQ", "Chaquetas" },
                    { "PNL", "Pantalonetas" },
                    { "TEN", "Tennis" }
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "CHQ");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "CMS");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "PNL");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "TEN");

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
        }
    }
}
