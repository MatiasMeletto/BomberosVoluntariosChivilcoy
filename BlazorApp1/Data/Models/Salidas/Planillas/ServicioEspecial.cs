using BlazorApp1.Data.Enums;
using BlazorApp1.Data.Models.Salidas.Componentes;

namespace BlazorApp1.Data.Models.Salidas.Planillas
{
    public class ServicioEspecial : Salida
    {
        //Localización, datos del solicitante, personas damnificadas y datos del seguro
        public TipoServiciosEspeciales Tipo { get; set; }
        public TipoOrganizacionBeneficiada TipoOrganizacion { get; set; }
        public string? OtroRepresentacion { get; set; }

        public DatosCapacitacion? DatosCapacitacion { get; set; }
    }
}
