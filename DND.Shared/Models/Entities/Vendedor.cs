using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DND.Shared.Models.Entities
{
    public class Vendedor
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("PartidaId")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "ID de la partida")]
        public int PartidaId { get; set; }
        [ForeignKey("UsuarioId")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Id del DM")]
        public int UsuarioId { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nombre del Vendedor")]
        [MaxLength(25, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Tipo de Vendedor")]
        [MaxLength(25, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Tamaño del local")]
        [MaxLength(25, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string TamañoLocal { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Zona donde esta ubicado el local")]
        [MaxLength(25, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string ZonaLocal { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Cantidad de items")]
        public int CantItems { get; set; }
        public ICollection<VendedorProducto> VendedorProductos { get; set; }


        // Propiedades Not Mapped

        [NotMapped]
        [Display(Name = "Tipos de vendedores")]
        public List<string> Categorias = new List<string>
        {
            "Herrero",
            "Bazar",
            "Tienda de Alquimia"
        };
        [NotMapped]
        [Display(Name = "Tipos de vendedores")]
        public List<string> TamañosLocales = new List<string>
        {
            "Pequeño",
            "Mediano",
            "Enorme"
        };
        [NotMapped]
        [Display(Name = "Tipos de vendedores")]
        public List<string> ZonasLocales = new List<string>
        {
            "Desfavorecida",
            "Barrio Comercial",
            "Barrio Noble"
        };
    }
}
