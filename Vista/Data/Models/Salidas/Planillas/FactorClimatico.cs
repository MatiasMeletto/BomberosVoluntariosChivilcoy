using Vista.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Vista.Data.Models.Salidas.Planillas
{
    public class FactorClimatico : Salida
    {
        //Localización, datos del solicitante, personas damnificadas y datos del seguro

        public TipoFactoresClimaticos Tipo { get; set; }

        //Daños superficie evacuada
        public TipoEvacuacion Evacuacion { get; set; }
        public TipoSuperficie Superficie { get; set; }
        [Required, StringLength(255)]
        public string DetalleSuperficieDañada { get; set; }

    }
}
