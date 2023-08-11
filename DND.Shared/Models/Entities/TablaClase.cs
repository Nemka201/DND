using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DND.Shared.Models.Entities
{
    public class TablaClase
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Ataque Base")]
        public int Nivel { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nivel de la clase")]
        public double AtaqueBase { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Salvación de Fortaleza")]
        public double SFortaleza { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Salvación de Reflejos")]
        public double SReflejos { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Salvación de Voluntad")]
        public double SVoluntad { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Rasgos de la clase")]
        [MaxLength(255, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Especial { get; set; }
        [ForeignKey("ClaseId")]
        public int ClaseId { get; set; }
    }
}
