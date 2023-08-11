using DND.Shared.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DND.API.Context
{
    public partial class DndContext : DbContext
    {
        public DndContext(DbContextOptions<DndContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Clase> Clases { get; set; }
        public DbSet<TablaClase> TablasClases { get; set; }
        public DbSet<Conjuro> Conjuros { get; set; }
        public DbSet<Dote> Dotes { get; set; }
        public DbSet<Raza> Razas { get; set; }
        public DbSet<Personaje> Personajes { get; set; }
        public DbSet<Habilidades> Habilidades { get; set; }
        public DbSet<Caracteristicas> Caracteristicas { get; set; }
        public DbSet<Arma> Armas { get; set; }
        public DbSet<Armadura> Armaduras { get; set; }
        public DbSet<ObjetoMagico> ObjetosMagicos { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Partida> Partidas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(u => u.Id);
                entity.Property(u => u.Id).HasColumnName("id");
                entity.Property(u => u.User).HasColumnName("usuario")
                    .HasMaxLength(255);
                entity.Property(u => u.CorreoElectronico).HasColumnName("correo_electronico")
                    .HasMaxLength(255);
                entity.Property(u => u.Nombre).HasColumnName("nombre")
                       .HasMaxLength(255);
                entity.Property(u => u.Contraseña).HasColumnName("contraseña")
                    .HasMaxLength(255);
                entity.Property(u => u.PathImage).HasColumnName("pathImage")
                    .HasMaxLength(255);
            });
            modelBuilder.Entity<Arma>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Id).HasColumnName("id");
                entity.Property(c => c.Nombre).HasColumnName("nombre");
                entity.Property(c => c.Categoria).HasColumnName("categoria");
                entity.Property(c => c.TipoDaño).HasColumnName("tipo-daño");
                entity.Property(c => c.Critico).HasColumnName("critico");
                entity.Property(c => c.Daño).HasColumnName("daño");
                entity.Property(c => c.Precio).HasColumnName("precio");
                entity.Property(c => c.Alcance).HasColumnName("alcance");

            });
            modelBuilder.Entity<Armadura>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Id).HasColumnName("id");
                entity.Property(c => c.Nombre).HasColumnName("nombre");
                entity.Property(c => c.Categoria).HasColumnName("categoria");
                entity.Property(c => c.ClaseDeArmadura).HasColumnName("ca");
                entity.Property(c => c.BonDes).HasColumnName("bono-des");
                entity.Property(c => c.Peso).HasColumnName("peso");
                entity.Property(c => c.FalloArcano).HasColumnName("fallo-arcano");
                entity.Property(c => c.Precio).HasColumnName("precio");
            });
            modelBuilder.Entity<Clase>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Id).HasColumnName("id");
                entity.Property(c => c.Nombre).HasColumnName("nombre")
                    .HasMaxLength(255);
                entity.Property(c => c.NivelMaximo).HasColumnName("nivel_maximo");
                entity.Property(c => c.Descripcion).HasColumnName("descripcion")
                    .HasMaxLength(255);
                entity.Property(c => c.Rasgos).HasColumnName("rasgos")
                    .HasMaxLength(255);
                entity.Property(c => c.PathImage).HasColumnName("pathImage")
                     .HasMaxLength(255);
            });
            modelBuilder.Entity<TablaClase>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Id).HasColumnName("id");
                entity.Property(c => c.Nivel).HasColumnName("nivel");
                entity.Property(c => c.AtaqueBase).HasColumnName("ataque_base");
                entity.Property(c => c.SFortaleza).HasColumnName("s_fortaleza");
                entity.Property(c => c.SReflejos).HasColumnName("s_reflejos");
                entity.Property(c => c.SVoluntad).HasColumnName("s_voluntad");
                entity.Property(c => c.Especial).HasColumnName("especial");
                entity.Property(c => c.ClaseId).HasColumnName("clase_id");
            });
            modelBuilder.Entity<Conjuro>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Id).HasColumnName("id");
                entity.Property(c => c.Nombre).HasColumnName("nombre")
                    .HasMaxLength(255);
                entity.Property(c => c.Tipo).HasColumnName("tipo")
                    .HasMaxLength(255);
                entity.Property(c => c.Escuela).HasColumnName("escuela")
                    .HasMaxLength(255);
                entity.Property(c => c.Nivel).HasColumnName("nivel");
                entity.Property(c => c.Descripcion).HasColumnName("descripcion")
                    .HasMaxLength(255);
            });
            modelBuilder.Entity<Dote>(entity =>
            {
                entity.HasKey(d => d.Id);
                entity.Property(d => d.Id).HasColumnName("id");
                entity.Property(d => d.Nombre).HasColumnName("nombre")
                    .HasMaxLength(255);
                entity.Property(d => d.Categoria).HasColumnName("categoria")
                    .HasMaxLength(255);
                entity.Property(d => d.Descripcion).HasColumnName("descripcion")
                    .HasMaxLength(1500);
                entity.Property(d => d.Prerequisito).HasColumnName("prerequisito")
                    .HasMaxLength(255);

            });
            modelBuilder.Entity<Raza>(entity =>
            {
                entity.HasKey(r => r.Id);
                entity.Property(r => r.Id).HasColumnName("id");
                entity.Property(r => r.Nombre).HasColumnName("nombre")
                       .HasMaxLength(255);
                entity.Property(r => r.Descripcion).HasColumnName("descripcion")
                     .HasMaxLength(255);
                entity.Property(r => r.Rasgos).HasColumnName("rasgos")
                .HasMaxLength(255);
                entity.Property(r => r.PathImage).HasColumnName("pathImage")
                     .HasMaxLength(255);
            });
            modelBuilder.Entity<Caracteristicas>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Id).HasColumnName("id");
                entity.Property(c => c.FUE).HasColumnName("fue");
                entity.Property(c => c.DES).HasColumnName("des");
                entity.Property(c => c.CON).HasColumnName("con");
                entity.Property(c => c.SAB).HasColumnName("sab");
                entity.Property(c => c.INT).HasColumnName("int");
                entity.Property(c => c.CAR).HasColumnName("car");
            });
            modelBuilder.Entity<Habilidades>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Id).HasColumnName("id");
                entity.Property(c => c.AbrirCerraduras).HasColumnName("abrir_cerraduras");
                entity.Property(c => c.Alquimia).HasColumnName("alquimia");
                entity.Property(c => c.Arte).HasColumnName("arte");
                entity.Property(c => c.AveriguarIntenciones).HasColumnName("averiguar_intenciones");
                entity.Property(c => c.Avistar).HasColumnName("avistar");
                entity.Property(c => c.Buscar).HasColumnName("buscar");
                entity.Property(c => c.Concentracion).HasColumnName("concentracion");
                entity.Property(c => c.ConocimientoDeConjuros).HasColumnName("conocimiento_de_conjuros");
                entity.Property(c => c.DescifrarEscritura).HasColumnName("descifrar_escritura");
                entity.Property(c => c.Diplomacia).HasColumnName("diplomacia");
                entity.Property(c => c.Disfrazarse).HasColumnName("disfrazarse");
                entity.Property(c => c.Engañar).HasColumnName("engañar");
                entity.Property(c => c.Equilibrio).HasColumnName("equilibrio");
                entity.Property(c => c.Escapismo).HasColumnName("escapismo");
                entity.Property(c => c.Esconderse).HasColumnName("esconderse");
                entity.Property(c => c.Escuchar).HasColumnName("escuchar");
                entity.Property(c => c.Falsificar).HasColumnName("falsificar");
                entity.Property(c => c.Interpretar).HasColumnName("interpretar");
                entity.Property(c => c.Intimidar).HasColumnName("intimidar");
                entity.Property(c => c.InutilizarMecanismo).HasColumnName("inutilizar_mecanismo");
                entity.Property(c => c.Montar).HasColumnName("montar");
                entity.Property(c => c.MoverseSigilosamente).HasColumnName("moverse_sigilosamente");
                entity.Property(c => c.Nadar).HasColumnName("nadar");
                entity.Property(c => c.Oficio).HasColumnName("oficio");
                entity.Property(c => c.Piruetas).HasColumnName("piruetas");
                entity.Property(c => c.ReunirInformacion).HasColumnName("reunir_informacion");
                entity.Property(c => c.SaberArcano).HasColumnName("saber_arcano");
                entity.Property(c => c.SaberAEI).HasColumnName("saber_aei");
                entity.Property(c => c.SaberGeografia).HasColumnName("saber_geografia");
                entity.Property(c => c.SaberHistoria).HasColumnName("saber_historia");
                entity.Property(c => c.SaberLocal).HasColumnName("saber_local");
                entity.Property(c => c.SaberPlanos).HasColumnName("saber_planos");
                entity.Property(c => c.SaberNaturaleza).HasColumnName("saber_naturaleza");
                entity.Property(c => c.SaberNYR).HasColumnName("saber_nyr");
                entity.Property(c => c.SaberReligion).HasColumnName("saber_religion");
                entity.Property(c => c.Saltar).HasColumnName("saltar");
                entity.Property(c => c.Sanar).HasColumnName("sanar");
                entity.Property(c => c.Supervivencia).HasColumnName("supervivencia");
                entity.Property(c => c.Tasacion).HasColumnName("tasacion");
                entity.Property(c => c.TratoConAnimales).HasColumnName("trato_con_animales");
                entity.Property(c => c.Trepar).HasColumnName("trepar");
                entity.Property(c => c.UsarObjetoMagico).HasColumnName("usar_objeto_magico");
                entity.Property(c => c.UsoDeCuerdas).HasColumnName("uso_de_cuerdas");
            });
            modelBuilder.Entity<Personaje>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Id).HasColumnName("id");
                entity.Property(c => c.UsuarioId).HasColumnName("usuario_id");
                entity.Property(c => c.Nombre).HasColumnName("nombre");
                entity.Property(c => c.Jugador).HasColumnName("jugador");
                entity.Property(c => c.Clase).HasColumnName("clase");
                entity.Property(c => c.Raza).HasColumnName("raza");
                entity.Property(c => c.Alineamiento).HasColumnName("alineamiento");
                entity.Property(c => c.Nivel).HasColumnName("nivel");
                entity.Property(c => c.Deidad).HasColumnName("deidad");
                entity.Property(c => c.Sexo).HasColumnName("sexo");
                entity.Property(c => c.PG).HasColumnName("pg");
                entity.Property(c => c.CA).HasColumnName("ca");
                entity.Property(c => c.Iniciativa).HasColumnName("iniciativa");
                entity.Property(c => c.AtaqueBase).HasColumnName("ataque_base");
                entity.Property(c => c.CaracteristicasId).HasColumnName("caracteristicas_id");
                entity.Property(c => c.HabilidadesId).HasColumnName("habilidades_id");
                entity.Property(c => c.PiezaOro).HasColumnName("gp");

            });
            modelBuilder.Entity<ObjetoMagico>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Id).HasColumnName("id");
                entity.Property(c => c.Nombre).HasColumnName("nombre");
                entity.Property(c => c.Descripcion).HasColumnName("descripcion");
                entity.Property(c => c.Precio).HasColumnName("precio");
            });
            modelBuilder.Entity<Vendedor>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Id).HasColumnName("id");
                entity.Property(c => c.UsuarioId).HasColumnName("usuario_id");
                entity.Property(c => c.Nombre).HasColumnName("nombre");
                entity.Property(c => c.Categoria).HasColumnName("categoria");
                entity.Property(c => c.TamañoLocal).HasColumnName("tamaño");
                entity.Property(c => c.ZonaLocal).HasColumnName("zona_local");
                entity.Property(c => c.CantItems).HasColumnName("cant_items");
            });
            modelBuilder.Entity<Partida>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Id).HasColumnName("id");
                entity.Property(c => c.DmId).HasColumnName("dm_id");
                entity.Property(c => c.Nombre).HasColumnName("nombre");
            });
            //modelBuilder.Entity<VendedorProducto>()
            //    .HasKey(vp => new { vp.VendedorId, vp.ProductoId });

            //modelBuilder.Entity<VendedorProducto>()
            //    .HasOne(vp => vp.Vendedor)
            //    .WithMany(v => v.VendedorProductos)
            //    .HasForeignKey(vp => vp.VendedorId);

            //modelBuilder.Entity<VendedorProducto>()
            //    .HasOne(vp => vp.Armadura) // Relación con la entidad Armadura
            //    .WithMany(a => a.VendedorProductos)
            //    .HasForeignKey(vp => vp.ProductoId);

            //modelBuilder.Entity<VendedorProducto>()
            //    .HasOne(vp => vp.Arma) // Relación con la entidad Arma
            //    .WithMany(a => a.VendedorProductos)
            //    .HasForeignKey(vp => vp.ProductoId);

            //modelBuilder.Entity<VendedorProducto>()
            //    .HasOne(vp => vp.ObjetoMagico) // Relación con la entidad ObjetoMagico
            //    .WithMany(o => o.VendedorProductos)
            //    .HasForeignKey(vp => vp.ProductoId);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
