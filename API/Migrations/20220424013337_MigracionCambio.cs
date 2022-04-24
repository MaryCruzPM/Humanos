using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class MigracionCambio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "color",
                table: "HumanosItems");

            migrationBuilder.AddColumn<string>(
                name: "high",
                table: "HumanosItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "weight",
                table: "HumanosItems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "high",
                table: "HumanosItems");

            migrationBuilder.DropColumn(
                name: "weight",
                table: "HumanosItems");

            migrationBuilder.AddColumn<string>(
                name: "color",
                table: "HumanosItems",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
