using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dnd.API.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "tipo-daño",
                table: "Armas",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "daño",
                table: "Armas",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "alcance",
                table: "Armas",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Partidas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    dm_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partidas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Vendedores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartidaId = table.Column<int>(type: "int", nullable: false),
                    usuario_id = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    categoria = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    tamaño = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    zona_local = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    cant_items = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "VendedorProducto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendedorId = table.Column<int>(type: "int", nullable: false),
                    ArmaduraId = table.Column<int>(type: "int", nullable: false),
                    ArmaId = table.Column<int>(type: "int", nullable: true),
                    ObjetoMagicoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendedorProducto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VendedorProducto_Armaduras_ArmaduraId",
                        column: x => x.ArmaduraId,
                        principalTable: "Armaduras",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VendedorProducto_Armas_ArmaId",
                        column: x => x.ArmaId,
                        principalTable: "Armas",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_VendedorProducto_ObjetosMagicos_ObjetoMagicoId",
                        column: x => x.ObjetoMagicoId,
                        principalTable: "ObjetosMagicos",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_VendedorProducto_Vendedores_VendedorId",
                        column: x => x.VendedorId,
                        principalTable: "Vendedores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VendedorProducto_ArmaduraId",
                table: "VendedorProducto",
                column: "ArmaduraId");

            migrationBuilder.CreateIndex(
                name: "IX_VendedorProducto_ArmaId",
                table: "VendedorProducto",
                column: "ArmaId");

            migrationBuilder.CreateIndex(
                name: "IX_VendedorProducto_ObjetoMagicoId",
                table: "VendedorProducto",
                column: "ObjetoMagicoId");

            migrationBuilder.CreateIndex(
                name: "IX_VendedorProducto_VendedorId",
                table: "VendedorProducto",
                column: "VendedorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Partidas");

            migrationBuilder.DropTable(
                name: "VendedorProducto");

            migrationBuilder.DropTable(
                name: "Vendedores");

            migrationBuilder.DropColumn(
                name: "alcance",
                table: "Armas");

            migrationBuilder.AlterColumn<string>(
                name: "tipo-daño",
                table: "Armas",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "daño",
                table: "Armas",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);
        }
    }
}
