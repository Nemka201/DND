using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DND.Shared.Models.Entities
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Usuario")]
        [MaxLength(255, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string User { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Correo Electrónico")]
        [MaxLength(255, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string CorreoElectronico { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nombre")]
        [MaxLength(255, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Contraseña")]
        [MaxLength(255, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Contraseña { get; set; }

        public string PathImage { get; set; }
        [NotMapped]
        public IFormFile? Image { get; set; }
        [NotMapped]
        public string cClave { get; set; } = null!; // Confirmacion Contraseña
    }
}
