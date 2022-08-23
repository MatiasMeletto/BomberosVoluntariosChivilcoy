namespace BlazorApp1.Data.Models
{
    public class Incendios : Salida
    {
        public int SuperficieAccidenteId { get; set; }

        public int LugarId { get; set; }

        public string? Lugar { get; set; }

        public string? DeteccionAutomaticaId { get; set; }

        public string? ExtincionId { get; set; }

        public int VehiculosAfectados { get; set; }

        public string? LugarDeSiniestro { get; set; }




    }
}
