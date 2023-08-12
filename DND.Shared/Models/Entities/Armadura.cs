using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DND.Shared.Models.Entities
{
    public class Armadura
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Categoría")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Categoria { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Clase de Armadura")]
        public int ClaseDeArmadura { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Bonificador de Destreza")]
        public int BonDes { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Fallo Arcano")]
        public int FalloArcano { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Peso")]
        public int Peso { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Precio")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }


        // Propiedades NotMapped

        [NotMapped]
        [Display(Name = "Categorias")]
        static public List<string> Categorias = new List<string>
        {
            "Ligera",
            "Intermedia",
            "Pesada"
        };
        [NotMapped]
        [Display(Name = "Categorias")]
        static public List<int> Bonificadores = new List<int>
        {
            0,1,2,3,4,5,6,7,8,9
        };
        [NotMapped]
        [Display(Name = "Categorias")]
        static public List<int> ArcaneFailure = new List<int>
        {
            0,5,10,15,20,25,30,35,40,45,50
        };
    }
}
