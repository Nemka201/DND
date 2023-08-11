﻿// <auto-generated />
using DND.API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dnd.API.Migrations
{
    [DbContext(typeof(DndContext))]
    [Migration("20230805213826_v4")]
    partial class v4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DND.Shared.Models.Entities.Arma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("categoria");

                    b.Property<string>("Critico")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("critico");

                    b.Property<string>("Daño")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("daño");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nombre");

                    b.Property<int>("Peso")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("precio");

                    b.Property<string>("TipoDaño")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("tipo-daño");

                    b.HasKey("Id");

                    b.ToTable("Armas");
                });

            modelBuilder.Entity("DND.Shared.Models.Entities.Armadura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BonDes")
                        .HasColumnType("int")
                        .HasColumnName("bono-des");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("categoria");

                    b.Property<int>("ClaseDeArmadura")
                        .HasColumnType("int")
                        .HasColumnName("ca");

                    b.Property<int>("FalloArcano")
                        .HasColumnType("int")
                        .HasColumnName("fallo-arcano");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nombre");

                    b.Property<int>("Peso")
                        .HasColumnType("int")
                        .HasColumnName("peso");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("precio");

                    b.HasKey("Id");

                    b.ToTable("Armaduras");
                });

            modelBuilder.Entity("DND.Shared.Models.Entities.Caracteristicas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CAR")
                        .HasColumnType("int")
                        .HasColumnName("car");

                    b.Property<int>("CON")
                        .HasColumnType("int")
                        .HasColumnName("con");

                    b.Property<int>("DES")
                        .HasColumnType("int")
                        .HasColumnName("des");

                    b.Property<int>("FUE")
                        .HasColumnType("int")
                        .HasColumnName("fue");

                    b.Property<int>("INT")
                        .HasColumnType("int")
                        .HasColumnName("int");

                    b.Property<int>("SAB")
                        .HasColumnType("int")
                        .HasColumnName("sab");

                    b.HasKey("Id");

                    b.ToTable("Caracteristicas");
                });

            modelBuilder.Entity("DND.Shared.Models.Entities.Clase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("descripcion");

                    b.Property<int>("NivelMaximo")
                        .HasColumnType("int")
                        .HasColumnName("nivel_maximo");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("nombre");

                    b.Property<string>("PathImage")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("pathImage");

                    b.Property<string>("Rasgos")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("rasgos");

                    b.HasKey("Id");

                    b.ToTable("Clases");
                });

            modelBuilder.Entity("DND.Shared.Models.Entities.Conjuro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("descripcion");

                    b.Property<string>("Escuela")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("escuela");

                    b.Property<int>("Nivel")
                        .HasColumnType("int")
                        .HasColumnName("nivel");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("nombre");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("tipo");

                    b.HasKey("Id");

                    b.ToTable("Conjuros");
                });

            modelBuilder.Entity("DND.Shared.Models.Entities.Dote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("categoria");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)")
                        .HasColumnName("descripcion");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("nombre");

                    b.Property<string>("Prerequisito")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("prerequisito");

                    b.HasKey("Id");

                    b.ToTable("Dotes");
                });

            modelBuilder.Entity("DND.Shared.Models.Entities.Habilidades", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AbrirCerraduras")
                        .HasColumnType("int")
                        .HasColumnName("abrir_cerraduras");

                    b.Property<int>("Alquimia")
                        .HasColumnType("int")
                        .HasColumnName("alquimia");

                    b.Property<int>("Arte")
                        .HasColumnType("int")
                        .HasColumnName("arte");

                    b.Property<int>("AveriguarIntenciones")
                        .HasColumnType("int")
                        .HasColumnName("averiguar_intenciones");

                    b.Property<int>("Avistar")
                        .HasColumnType("int")
                        .HasColumnName("avistar");

                    b.Property<int>("Buscar")
                        .HasColumnType("int")
                        .HasColumnName("buscar");

                    b.Property<int>("Concentracion")
                        .HasColumnType("int")
                        .HasColumnName("concentracion");

                    b.Property<int>("ConocimientoDeConjuros")
                        .HasColumnType("int")
                        .HasColumnName("conocimiento_de_conjuros");

                    b.Property<int>("DescifrarEscritura")
                        .HasColumnType("int")
                        .HasColumnName("descifrar_escritura");

                    b.Property<int>("Diplomacia")
                        .HasColumnType("int")
                        .HasColumnName("diplomacia");

                    b.Property<int>("Disfrazarse")
                        .HasColumnType("int")
                        .HasColumnName("disfrazarse");

                    b.Property<int>("Engañar")
                        .HasColumnType("int")
                        .HasColumnName("engañar");

                    b.Property<int>("Equilibrio")
                        .HasColumnType("int")
                        .HasColumnName("equilibrio");

                    b.Property<int>("Escapismo")
                        .HasColumnType("int")
                        .HasColumnName("escapismo");

                    b.Property<int>("Esconderse")
                        .HasColumnType("int")
                        .HasColumnName("esconderse");

                    b.Property<int>("Escuchar")
                        .HasColumnType("int")
                        .HasColumnName("escuchar");

                    b.Property<int>("Falsificar")
                        .HasColumnType("int")
                        .HasColumnName("falsificar");

                    b.Property<int>("Interpretar")
                        .HasColumnType("int")
                        .HasColumnName("interpretar");

                    b.Property<int>("Intimidar")
                        .HasColumnType("int")
                        .HasColumnName("intimidar");

                    b.Property<int>("InutilizarMecanismo")
                        .HasColumnType("int")
                        .HasColumnName("inutilizar_mecanismo");

                    b.Property<int>("Montar")
                        .HasColumnType("int")
                        .HasColumnName("montar");

                    b.Property<int>("MoverseSigilosamente")
                        .HasColumnType("int")
                        .HasColumnName("moverse_sigilosamente");

                    b.Property<int>("Nadar")
                        .HasColumnType("int")
                        .HasColumnName("nadar");

                    b.Property<int>("Oficio")
                        .HasColumnType("int")
                        .HasColumnName("oficio");

                    b.Property<int>("Piruetas")
                        .HasColumnType("int")
                        .HasColumnName("piruetas");

                    b.Property<int>("ReunirInformacion")
                        .HasColumnType("int")
                        .HasColumnName("reunir_informacion");

                    b.Property<int>("SaberAEI")
                        .HasColumnType("int")
                        .HasColumnName("saber_aei");

                    b.Property<int>("SaberArcano")
                        .HasColumnType("int")
                        .HasColumnName("saber_arcano");

                    b.Property<int>("SaberGeografia")
                        .HasColumnType("int")
                        .HasColumnName("saber_geografia");

                    b.Property<int>("SaberHistoria")
                        .HasColumnType("int")
                        .HasColumnName("saber_historia");

                    b.Property<int>("SaberLocal")
                        .HasColumnType("int")
                        .HasColumnName("saber_local");

                    b.Property<int>("SaberNYR")
                        .HasColumnType("int")
                        .HasColumnName("saber_nyr");

                    b.Property<int>("SaberNaturaleza")
                        .HasColumnType("int")
                        .HasColumnName("saber_naturaleza");

                    b.Property<int>("SaberPlanos")
                        .HasColumnType("int")
                        .HasColumnName("saber_planos");

                    b.Property<int>("SaberReligion")
                        .HasColumnType("int")
                        .HasColumnName("saber_religion");

                    b.Property<int>("Saltar")
                        .HasColumnType("int")
                        .HasColumnName("saltar");

                    b.Property<int>("Sanar")
                        .HasColumnType("int")
                        .HasColumnName("sanar");

                    b.Property<int>("Supervivencia")
                        .HasColumnType("int")
                        .HasColumnName("supervivencia");

                    b.Property<int>("Tasacion")
                        .HasColumnType("int")
                        .HasColumnName("tasacion");

                    b.Property<int>("TratoConAnimales")
                        .HasColumnType("int")
                        .HasColumnName("trato_con_animales");

                    b.Property<int>("Trepar")
                        .HasColumnType("int")
                        .HasColumnName("trepar");

                    b.Property<int>("UsarObjetoMagico")
                        .HasColumnType("int")
                        .HasColumnName("usar_objeto_magico");

                    b.Property<int>("UsoDeCuerdas")
                        .HasColumnType("int")
                        .HasColumnName("uso_de_cuerdas");

                    b.HasKey("Id");

                    b.ToTable("Habilidades");
                });

            modelBuilder.Entity("DND.Shared.Models.Entities.ObjetoMagico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)")
                        .HasColumnName("descripcion");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nombre");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("precio");

                    b.HasKey("Id");

                    b.ToTable("ObjetosMagicos");
                });

            modelBuilder.Entity("DND.Shared.Models.Entities.Personaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Alineamiento")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("alineamiento");

                    b.Property<int>("AtaqueBase")
                        .HasColumnType("int")
                        .HasColumnName("ataque_base");

                    b.Property<int>("CA")
                        .HasColumnType("int")
                        .HasColumnName("ca");

                    b.Property<int>("CaracteristicasId")
                        .HasColumnType("int")
                        .HasColumnName("caracteristicas_id");

                    b.Property<string>("Clase")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("clase");

                    b.Property<string>("Deidad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("deidad");

                    b.Property<int>("HabilidadesId")
                        .HasColumnType("int")
                        .HasColumnName("habilidades_id");

                    b.Property<int>("Iniciativa")
                        .HasColumnType("int")
                        .HasColumnName("iniciativa");

                    b.Property<string>("Jugador")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("jugador");

                    b.Property<int>("Nivel")
                        .HasColumnType("int")
                        .HasColumnName("nivel");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("nombre");

                    b.Property<int>("PG")
                        .HasColumnType("int")
                        .HasColumnName("pg");

                    b.Property<decimal>("PiezaOro")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("gp");

                    b.Property<string>("Raza")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("raza");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("sexo");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int")
                        .HasColumnName("usuario_id");

                    b.HasKey("Id");

                    b.ToTable("Personajes");
                });

            modelBuilder.Entity("DND.Shared.Models.Entities.Raza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("descripcion");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("nombre");

                    b.Property<string>("PathImage")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("pathImage");

                    b.Property<string>("Rasgos")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("rasgos");

                    b.HasKey("Id");

                    b.ToTable("Razas");
                });

            modelBuilder.Entity("DND.Shared.Models.Entities.TablaClase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("AtaqueBase")
                        .HasColumnType("float")
                        .HasColumnName("ataque_base");

                    b.Property<int>("ClaseId")
                        .HasColumnType("int")
                        .HasColumnName("clase_id");

                    b.Property<string>("Especial")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("especial");

                    b.Property<int>("Nivel")
                        .HasColumnType("int")
                        .HasColumnName("nivel");

                    b.Property<double>("SFortaleza")
                        .HasColumnType("float")
                        .HasColumnName("s_fortaleza");

                    b.Property<double>("SReflejos")
                        .HasColumnType("float")
                        .HasColumnName("s_reflejos");

                    b.Property<double>("SVoluntad")
                        .HasColumnType("float")
                        .HasColumnName("s_voluntad");

                    b.HasKey("Id");

                    b.ToTable("TablasClases");
                });

            modelBuilder.Entity("DND.Shared.Models.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("contraseña");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("correo_electronico");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("nombre");

                    b.Property<string>("PathImage")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("pathImage");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("usuario");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
