using DND.Shared.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND.Shared.Models.DTO
{
    public class IndexDTO
    {
        public List<Arma>? Armas { get; set; }
        public List<Armadura>? Armaduras { get; set; }
        public List<Clase>? Clases { get; set; }
        public List<Conjuro>? Conjuros { get; set; }
        public List<Dote>? Dotes { get; set; }
        public List<ObjetoMagico>? ObjetosMagicos { get; set; }
        public List<Raza>? Razas { get; set; }

    }
}
