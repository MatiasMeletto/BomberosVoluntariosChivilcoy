using BlazorApp1.Data.Enums;
using BlazorApp1.Data.Models.Personales;
using BlazorApp1.Data.Models.Salidas.Componentes;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data.Models.Salidas.Planillas
{
    public class Accidente : Salida
    {
        //Localización, datos del solicitante, personas damnificadas y datos del seguro

        public TipoAccidente Tipo { get; set; }

        public int CantidadVehiculos { get; set; }

        public List<VehiculoAfectado> VehiculosAfectado { get; set; }
        [Required, StringLength(255)]
        public string CondicionesClimaticas { get; set; }
    }
}
