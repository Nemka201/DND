using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DND.Shared.Models.Entities
{
    public class Personaje
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nombre")]
        [MaxLength(255, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Jugador")]
        [MaxLength(255, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Jugador { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Clase")]
        [MaxLength(255, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Clase { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Raza")]
        [MaxLength(255, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Raza { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Alineamiento")]
        [MaxLength(255, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Alineamiento { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nivel")]
        public int Nivel { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Deidad")]
        [MaxLength(30, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Deidad { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Sexo")]
        [MaxLength(10, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Puntos de Vida")]
        public int PG { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Clase de armadura")]
        public int CA { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Iniciativa")]
        public int Iniciativa { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Ataque Base")]
        public int AtaqueBase { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Piezas de oro")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PiezaOro { get; set; }
        [ForeignKey("CaracteristicasId")]
        public int CaracteristicasId { get; set; }
        [ForeignKey("HabilidadesId")]
        public int HabilidadesId { get; set; }
    }
}
