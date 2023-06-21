using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Myproject01.Migrations
{
    public partial class update_database_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Brands");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "WareHouse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Quantity",
                table: "WareHouse",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "WareHouse");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "WareHouse");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Brands",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
