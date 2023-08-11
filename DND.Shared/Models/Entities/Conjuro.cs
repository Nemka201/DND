using System.ComponentModel.DataAnnotations;

namespace DND.Shared.Models.Entities
{
    public class Conjuro
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nombre")]
        [MaxLength(255, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Tipo")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Tipo { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Escuela")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Escuela { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nivel")]
        public int Nivel { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Descripción")]
        [MaxLength(1500, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Descripcion { get; set; }
    }
}
