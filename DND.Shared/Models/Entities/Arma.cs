using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DND.Shared.Models.Entities
{
    public class Arma
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Critico")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Critico { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Categoría")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Categoria { get; set; }

        [Display(Name = "Tipo de Daño")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string TipoDaño { get; set; }

        [Display(Name = "Daño")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Daño { get; set; }
        [Display(Name = "Alcance")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Alcance { get; set; }

        [Display(Name = "Peso")]
        public int Peso { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Precio")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }


        // Propiedades NotMapped

        [NotMapped]
        [Display(Name ="Tipos de Daño")]
        public List<string> TiposDaño = new List<string> 
            {
                "Contundente",
                "Cortante",
                "Perforante"
            };
        [NotMapped]
        [Display(Name = "Categorías")]
        static public List<string> Categorias = new List<string>
            {
                "Exóticas",
                "Marciales",
                "Sencillas"
            };
        [NotMapped]
        [Display(Name = "Categorías")]
        static public List<string> Alcances = new List<string>
            {
                "Cuerpo a cuerpo",
                "Distancia",
            };
        [NotMapped]
        [Display(Name = "Categorías")]
        static public List<string> Criticos = new List<string>
            {
                "| 18-20 | X2 |",
                "| 19-20 | X2 |",
                "| 20 | X2 |",
                "| 20 | X3 |",
                "| 20 | X4 |"
            };
    }
}
