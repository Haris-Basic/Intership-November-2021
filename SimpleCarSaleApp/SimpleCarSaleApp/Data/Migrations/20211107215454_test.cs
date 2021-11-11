using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleCarSaleApp.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NazivModela",
                table: "CarModel");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CarModel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "CarModel");

            migrationBuilder.AddColumn<string>(
                name: "NazivModela",
                table: "CarModel",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
