using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class MigracionTablaHumanos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "HumanosItems");

            migrationBuilder.DropColumn(
                name: "age",
                table: "HumanosItems");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "HumanosItems");

            migrationBuilder.DropColumn(
                name: "high",
                table: "HumanosItems");

            migrationBuilder.DropColumn(
                name: "weight",
                table: "HumanosItems");

            migrationBuilder.AddColumn<double>(
                name: "Altura",
                table: "HumanosItems",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Edad",
                table: "HumanosItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "HumanosItems",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Peso",
                table: "HumanosItems",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Sexo",
                table: "HumanosItems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Altura",
                table: "HumanosItems");

            migrationBuilder.DropColumn(
                name: "Edad",
                table: "HumanosItems");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "HumanosItems");

            migrationBuilder.DropColumn(
                name: "Peso",
                table: "HumanosItems");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "HumanosItems");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "HumanosItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "HumanosItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "HumanosItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "high",
                table: "HumanosItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "weight",
                table: "HumanosItems",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
