using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dnd.API.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "Armas");

            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "Armaduras");

            migrationBuilder.AddColumn<int>(
                name: "Peso",
                table: "Armas",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "categoria",
                table: "Armas",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "critico",
                table: "Armas",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "daño",
                table: "Armas",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tipo-daño",
                table: "Armas",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "bono-des",
                table: "Armaduras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ca",
                table: "Armaduras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "categoria",
                table: "Armaduras",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "fallo-arcano",
                table: "Armaduras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "peso",
                table: "Armaduras",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Peso",
                table: "Armas");

            migrationBuilder.DropColumn(
                name: "categoria",
                table: "Armas");

            migrationBuilder.DropColumn(
                name: "critico",
                table: "Armas");

            migrationBuilder.DropColumn(
                name: "daño",
                table: "Armas");

            migrationBuilder.DropColumn(
                name: "tipo-daño",
                table: "Armas");

            migrationBuilder.DropColumn(
                name: "bono-des",
                table: "Armaduras");

            migrationBuilder.DropColumn(
                name: "ca",
                table: "Armaduras");

            migrationBuilder.DropColumn(
                name: "categoria",
                table: "Armaduras");

            migrationBuilder.DropColumn(
                name: "fallo-arcano",
                table: "Armaduras");

            migrationBuilder.DropColumn(
                name: "peso",
                table: "Armaduras");

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "Armas",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "Armaduras",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "");
        }
    }
}
