using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Myproject01.Migrations
{
    public partial class Update_Warehouse_Brand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "WareHouse");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "WareHouse");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Products",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Brands",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Brands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Brands",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Brands");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "WareHouse",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Quantity",
                table: "WareHouse",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
