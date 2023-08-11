using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dnd.API.Migrations
{
    /// <inheritdoc />
    public partial class CreateUsersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Armaduras",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armaduras", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Armas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Caracteristicas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fue = table.Column<int>(type: "int", nullable: false),
                    des = table.Column<int>(type: "int", nullable: false),
                    con = table.Column<int>(type: "int", nullable: false),
                    sab = table.Column<int>(type: "int", nullable: false),
                    @int = table.Column<int>(name: "int", type: "int", nullable: false),
                    car = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caracteristicas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Clases",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    nivel_maximo = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    rasgos = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    pathImage = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clases", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Conjuros",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    escuela = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    nivel = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conjuros", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Dotes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    categoria = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    prerequisito = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dotes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Habilidades",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    abrir_cerraduras = table.Column<int>(type: "int", nullable: false),
                    alquimia = table.Column<int>(type: "int", nullable: false),
                    arte = table.Column<int>(type: "int", nullable: false),
                    averiguar_intenciones = table.Column<int>(type: "int", nullable: false),
                    avistar = table.Column<int>(type: "int", nullable: false),
                    buscar = table.Column<int>(type: "int", nullable: false),
                    concentracion = table.Column<int>(type: "int", nullable: false),
                    conocimiento_de_conjuros = table.Column<int>(type: "int", nullable: false),
                    descifrar_escritura = table.Column<int>(type: "int", nullable: false),
                    diplomacia = table.Column<int>(type: "int", nullable: false),
                    disfrazarse = table.Column<int>(type: "int", nullable: false),
                    engañar = table.Column<int>(type: "int", nullable: false),
                    equilibrio = table.Column<int>(type: "int", nullable: false),
                    escapismo = table.Column<int>(type: "int", nullable: false),
                    esconderse = table.Column<int>(type: "int", nullable: false),
                    escuchar = table.Column<int>(type: "int", nullable: false),
                    falsificar = table.Column<int>(type: "int", nullable: false),
                    interpretar = table.Column<int>(type: "int", nullable: false),
                    intimidar = table.Column<int>(type: "int", nullable: false),
                    inutilizar_mecanismo = table.Column<int>(type: "int", nullable: false),
                    montar = table.Column<int>(type: "int", nullable: false),
                    moverse_sigilosamente = table.Column<int>(type: "int", nullable: false),
                    nadar = table.Column<int>(type: "int", nullable: false),
                    oficio = table.Column<int>(type: "int", nullable: false),
                    piruetas = table.Column<int>(type: "int", nullable: false),
                    reunir_informacion = table.Column<int>(type: "int", nullable: false),
                    saber_arcano = table.Column<int>(type: "int", nullable: false),
                    saber_aei = table.Column<int>(type: "int", nullable: false),
                    saber_geografia = table.Column<int>(type: "int", nullable: false),
                    saber_historia = table.Column<int>(type: "int", nullable: false),
                    saber_local = table.Column<int>(type: "int", nullable: false),
                    saber_planos = table.Column<int>(type: "int", nullable: false),
                    saber_naturaleza = table.Column<int>(type: "int", nullable: false),
                    saber_nyr = table.Column<int>(type: "int", nullable: false),
                    saber_religion = table.Column<int>(type: "int", nullable: false),
                    saltar = table.Column<int>(type: "int", nullable: false),
                    sanar = table.Column<int>(type: "int", nullable: false),
                    supervivencia = table.Column<int>(type: "int", nullable: false),
                    tasacion = table.Column<int>(type: "int", nullable: false),
                    trato_con_animales = table.Column<int>(type: "int", nullable: false),
                    trepar = table.Column<int>(type: "int", nullable: false),
                    usar_objeto_magico = table.Column<int>(type: "int", nullable: false),
                    uso_de_cuerdas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidades", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ObjetosMagicos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjetosMagicos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Personajes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuario_id = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    jugador = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    clase = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    raza = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    alineamiento = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    nivel = table.Column<int>(type: "int", nullable: false),
                    deidad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    sexo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    pg = table.Column<int>(type: "int", nullable: false),
                    ca = table.Column<int>(type: "int", nullable: false),
                    iniciativa = table.Column<int>(type: "int", nullable: false),
                    ataque_base = table.Column<int>(type: "int", nullable: false),
                    caracteristicas_id = table.Column<int>(type: "int", nullable: false),
                    habilidades_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personajes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Razas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    rasgos = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    pathImage = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Razas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TablasClases",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nivel = table.Column<int>(type: "int", nullable: false),
                    ataque_base = table.Column<double>(type: "float", nullable: false),
                    s_fortaleza = table.Column<double>(type: "float", nullable: false),
                    s_reflejos = table.Column<double>(type: "float", nullable: false),
                    s_voluntad = table.Column<double>(type: "float", nullable: false),
                    especial = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    clase_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablasClases", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuario = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    correo_electronico = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    contraseña = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    pathImage = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Armaduras");

            migrationBuilder.DropTable(
                name: "Armas");

            migrationBuilder.DropTable(
                name: "Caracteristicas");

            migrationBuilder.DropTable(
                name: "Clases");

            migrationBuilder.DropTable(
                name: "Conjuros");

            migrationBuilder.DropTable(
                name: "Dotes");

            migrationBuilder.DropTable(
                name: "Habilidades");

            migrationBuilder.DropTable(
                name: "ObjetosMagicos");

            migrationBuilder.DropTable(
                name: "Personajes");

            migrationBuilder.DropTable(
                name: "Razas");

            migrationBuilder.DropTable(
                name: "TablasClases");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
