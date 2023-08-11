using DND.Shared.Models.Entities;

namespace DND.Shared.Models.DTO
{
    public class PersonajeDTO
    {
        PersonajeDTO(Personaje p, Caracteristicas c, Habilidades h)
        {
            personaje = p;
            caracteristicas = c;
            habilidades = h;
        }
        Personaje personaje { get; set; }
        Caracteristicas caracteristicas { get; set; }
        Habilidades habilidades { get; set; }
    }
}
