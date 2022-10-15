using Vista.Data.Enums;
using Vista.Data.Models.Personales;
using Vista.Data.Models.Salidas.Componentes;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Vista.Data.Models.Salidas.Planillas
{
    public class Accidente : Salida
    {
        //Localización, datos del solicitante, personas damnificadas y datos del seguro

        public TipoAccidente Tipo { get; set; }

        public int CantidadVehiculos { get; set; }

        public List<VehiculoAfectadoAccidente> VehiculosAfectado { get; set; }
        public TipoCondicionesClimaticas CondicionesClimaticas { get; set; }
        [Required, StringLength(255)]
        public string? OtroCondicion { get; set; }
    }
}
