namespace BlazorApp1.Data.Models.Salidas
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
