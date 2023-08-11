using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DND.Shared.Models.Entities
{
    public class ObjetoMagico
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Descripcion")]
        [MaxLength(2000, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Precio")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }

    }
}
