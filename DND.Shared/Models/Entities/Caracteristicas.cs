using System.ComponentModel.DataAnnotations;

namespace DND.Shared.Models.Entities
{
    public class Caracteristicas
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Fuerza")]
        public int FUE { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Destreza")]
        public int DES { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Constitución")]
        public int CON { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Sabiduría")]
        public int SAB { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Inteligencia")]
        public int INT { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Carisma")]
        public int CAR { get; set; }
    }
}
