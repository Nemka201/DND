using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND.Shared.Models.Entities
{
    public class Partida
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nombre de Campaña")]
        [MaxLength(255, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Creador ID")]
        [ForeignKey("UsuarioId")]
        public int DmId { get; set; }
    }
}
