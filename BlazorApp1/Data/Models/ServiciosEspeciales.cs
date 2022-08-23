namespace BlazorApp1.Data.Models
{
    public class ServiciosEspeciales
    {
        public int ServiciosEspecilesId { get; set; }


        public string InformacionServicio { get; set; }


        public string TipoRepresentacion { get; set; }


        public string TipoPrevencion { get; set; }


        public int DatosCapacitacionId { get; set; }
        public DatosCapacitacion DatosCapacitacion { get; set; }
    }
}
