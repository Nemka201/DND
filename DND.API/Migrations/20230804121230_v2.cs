using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dnd.API.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "gp",
                table: "Personajes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "precio",
                table: "ObjetosMagicos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "precio",
                table: "Armas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "precio",
                table: "Armaduras",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gp",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "precio",
                table: "ObjetosMagicos");

            migrationBuilder.DropColumn(
                name: "precio",
                table: "Armas");

            migrationBuilder.DropColumn(
                name: "precio",
                table: "Armaduras");
        }
    }
}
