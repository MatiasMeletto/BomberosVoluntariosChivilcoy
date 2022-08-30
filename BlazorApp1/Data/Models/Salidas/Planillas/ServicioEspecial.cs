using BlazorApp1.Data.Models.Salidas.Componentes;

namespace BlazorApp1.Data.Models.Salidas.Planillas
{
    public class ServicioEspecial : Salida
    {
        public string InformacionServicio { get; set; }


        public string TipoRepresentacion { get; set; }


        public string TipoPrevencion { get; set; }


        public int? DatosCapacitacionId { get; set; }
        public DatosCapacitacion? DatosCapacitacion { get; set; }
    }
}
