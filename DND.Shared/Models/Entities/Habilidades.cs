using System.ComponentModel.DataAnnotations;

namespace DND.Shared.Models.Entities
{
    public class Habilidades
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Abrir Cerraduras")]
        public int AbrirCerraduras { get; set; }
        [Display(Name = "Alquimia")]
        public int Alquimia { get; set; }
        [Display(Name = "Arte")]
        public int Arte { get; set; }
        [Display(Name = "Averiguar Intenciones")]
        public int AveriguarIntenciones { get; set; }
        [Display(Name = "Avistar")]
        public int Avistar { get; set; }
        [Display(Name = "Buscar")]
        public int Buscar { get; set; }
        [Display(Name = "Concentración")]
        public int Concentracion { get; set; }
        [Display(Name = "Conocimiento de Conjuros")]
        public int ConocimientoDeConjuros { get; set; }
        [Display(Name = "Descifrar Escritura")]
        public int DescifrarEscritura { get; set; }
        [Display(Name = "Diplomacia")]
        public int Diplomacia { get; set; }
        [Display(Name = "Disfrazarse")]
        public int Disfrazarse { get; set; }
        [Display(Name = "Engañar")]
        public int Engañar { get; set; }
        [Display(Name = "Equilibrio")]
        public int Equilibrio { get; set; }
        [Display(Name = "Escapismo")]
        public int Escapismo { get; set; }
        [Display(Name = "Esconderse")]
        public int Esconderse { get; set; }
        [Display(Name = "Escuchar")]
        public int Escuchar { get; set; }
        [Display(Name = "Falsificar")]
        public int Falsificar { get; set; }
        [Display(Name = "Interpretar")]
        public int Interpretar { get; set; }
        [Display(Name = "Intimidar")]
        public int Intimidar { get; set; }
        [Display(Name = "Inutilizar Mecanismo")]
        public int InutilizarMecanismo { get; set; }
        [Display(Name = "Montar")]
        public int Montar { get; set; }
        [Display(Name = "Moverse Sigilosamente")]
        public int MoverseSigilosamente { get; set; }
        [Display(Name = "Nadar")]
        public int Nadar { get; set; }
        [Display(Name = "Oficio")]
        public int Oficio { get; set; }
        [Display(Name = "Piruetas")]
        public int Piruetas { get; set; }
        [Display(Name = "Reunir Información")]
        public int ReunirInformacion { get; set; }
        [Display(Name = "Saber Arcano")]
        public int SaberArcano { get; set; }
        [Display(Name = "Saber Arquitectura e ingeniería")]
        public int SaberAEI { get; set; }
        [Display(Name = "Saber Geografía")]
        public int SaberGeografia { get; set; }
        [Display(Name = "Saber Historia")]
        public int SaberHistoria { get; set; }
        [Display(Name = "Saber Local")]
        public int SaberLocal { get; set; }
        [Display(Name = "Saber los Planos")]
        public int SaberPlanos { get; set; }
        [Display(Name = "Saber Naturaleza")]
        public int SaberNaturaleza { get; set; }
        [Display(Name = "Saber Nobleza y Realeza")]
        public int SaberNYR { get; set; }
        [Display(Name = "Saber Religión")]
        public int SaberReligion { get; set; }
        [Display(Name = "Saltar")]
        public int Saltar { get; set; }
        [Display(Name = "Sanar")]
        public int Sanar { get; set; }
        [Display(Name = "Supervivencia")]
        public int Supervivencia { get; set; }
        [Display(Name = "Tasación")]
        public int Tasacion { get; set; }
        [Display(Name = "Trato con Animales")]
        public int TratoConAnimales { get; set; }
        [Display(Name = "Trepar")]
        public int Trepar { get; set; }
        [Display(Name = "Usar Objeto Mágico")]
        public int UsarObjetoMagico { get; set; }
        [Display(Name = "Uso de cuerdas")]
        public int UsoDeCuerdas { get; set; }

    }
}
