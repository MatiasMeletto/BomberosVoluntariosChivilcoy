using Vista.Data.Models.Personales;
using System.ComponentModel.DataAnnotations;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class VehiculoDamnificado : Vehiculo
    {
        [Required, StringLength(255)]
        public string Color { get; set; }
        public bool? Airbag { get; set; }

        public int DamnificadoId { get; set; }
        public Damnificado Damnificado { get; set; }
    }
}
