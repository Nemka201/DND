using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DND.Shared.Models.Entities
{
    public class Raza
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nombre")]
        [MaxLength(255, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Descripción")]
        [MaxLength(2000, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Rasgos de la Raza")]
        [MaxLength(2000, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Rasgos { get; set; }
        public string PathImage { get; set; }

        [NotMapped]
        public IFormFile? Image { get; set; }
    }
}
