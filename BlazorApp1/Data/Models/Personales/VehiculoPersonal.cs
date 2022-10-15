using BlazorApp1.Data.Models.Salidas.Componentes;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Data.Models.Personales
{
    public class VehiculoPersonal : Vehiculo
    {
        public int PersonaId { get; set; }
        [ForeignKey("PersonaId")]
        public Bombero Bombero { get; set; }
    }
}
