using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND.Shared.Models.Entities
{
    public class VendedorProducto
    {
        [Key]
        public int Id { get; set; }
        public int VendedorId { get; set; }
        public Vendedor Vendedor { get; set; }

        public int ArmaduraId { get; set; }
        public Armadura Armadura { get; set; } // Referencia a la entidad Armadura

        public int? ArmaId { get; set; }
        public Arma Arma { get; set; } // Referencia a la entidad Arma

        public int? ObjetoMagicoId { get; set; }
        public ObjetoMagico ObjetoMagico { get; set; } // Referencia a la entidad ObjetoMagico
    }
}
