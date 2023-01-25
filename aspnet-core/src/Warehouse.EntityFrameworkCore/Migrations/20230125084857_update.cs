using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Warehouse.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Storehouses_City_CityId",
                table: "Storehouses");

            migrationBuilder.DropForeignKey(
                name: "FK_Storehouses_Country_CountryId",
                table: "Storehouses");

            migrationBuilder.DropForeignKey(
                name: "FK_Storehouses_StorehouseType_StorehouseTypeId",
                table: "Storehouses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StorehouseType",
                table: "StorehouseType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.RenameTable(
                name: "StorehouseType",
                newName: "StorehouseTypes");

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "Countries");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "Cities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StorehouseTypes",
                table: "StorehouseTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Storehouses_Cities_CityId",
                table: "Storehouses",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Storehouses_Countries_CountryId",
                table: "Storehouses",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Storehouses_StorehouseTypes_StorehouseTypeId",
                table: "Storehouses",
                column: "StorehouseTypeId",
                principalTable: "StorehouseTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Storehouses_Cities_CityId",
                table: "Storehouses");

            migrationBuilder.DropForeignKey(
                name: "FK_Storehouses_Countries_CountryId",
                table: "Storehouses");

            migrationBuilder.DropForeignKey(
                name: "FK_Storehouses_StorehouseTypes_StorehouseTypeId",
                table: "Storehouses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StorehouseTypes",
                table: "StorehouseTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.RenameTable(
                name: "StorehouseTypes",
                newName: "StorehouseType");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Country");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "City");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StorehouseType",
                table: "StorehouseType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Storehouses_City_CityId",
                table: "Storehouses",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Storehouses_Country_CountryId",
                table: "Storehouses",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Storehouses_StorehouseType_StorehouseTypeId",
                table: "Storehouses",
                column: "StorehouseTypeId",
                principalTable: "StorehouseType",
                principalColumn: "Id");
        }
    }
}
