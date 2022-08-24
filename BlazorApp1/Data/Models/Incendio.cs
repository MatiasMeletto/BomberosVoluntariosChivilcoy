using BlazorApp1.Data.Enums;

namespace BlazorApp1.Data.Models
{
    public class Incendio : Salida
    {
        public int SuperficieAccidenteId { get; set; }

        public int LugarId { get; set; }
        public Lugar Lugar { get; set; }

        public bool DeteccionAutomaticaId { get; set; }

        public bool Extintor { get; set; }
        public bool Hidrante { get; set; }
        public int EmbarcacionAfectadaId { get; set; }
        public EmbarcacionAfectada EmbarcacionAfectada { get; set; }
        public int VehiculoAfectadoId { get; set; }
        public VehiculoAfectado VehiculoAfectado { get; set; }
        public string? LugarDeSiniestro { get; set; }

        public TipoIncendio Tipo { get; set; }
    }
}
