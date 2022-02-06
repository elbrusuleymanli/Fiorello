using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello.Migrations
{
    public partial class editOwl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LeftIcon",
                table: "ExpertsOwl",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "ExpertsOwl",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RightIcon",
                table: "ExpertsOwl",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LeftIcon",
                table: "ExpertsOwl");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "ExpertsOwl");

            migrationBuilder.DropColumn(
                name: "RightIcon",
                table: "ExpertsOwl");
        }
    }
}
