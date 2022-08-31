using BlazorApp1.Data.Enums;
using BlazorApp1.Data.Models.Salidas.Componentes;

namespace BlazorApp1.Data.Models.Salidas.Planillas
{
    public class ServicioEspecial : Salida
    {
        //Localización, datos del solicitante, personas damnificadas y datos del seguro
        public TipoServiciosEspeciales Tipo { get; set; }

        public string InformacionServicio { get; set; }


        public string TipoRepresentacion { get; set; }


        public string TipoPrevencion { get; set; }


        public int? DatosCapacitacionId { get; set; }
        public DatosCapacitacion? DatosCapacitacion { get; set; }
    }
}
