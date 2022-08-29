using BlazorApp1.Data.Enums;

namespace BlazorApp1.Data.Models.Salidas
{
    public class Incendio : Salida
    {
        public int SuperficieAccidente { get; set; }

        //public int LugarId { get; set; }
        //public Lugar Lugar { get; set; }

        public bool DeteccionAutomaticaId { get; set; }

        public bool Extintor { get; set; }
        public bool Hidrante { get; set; }
        public List<EmbarcacionAfectada> EmbarcacionAfectadas { get; set; }
        public List<VehiculoAfectado> VehiculoAfectados { get; set; }
        public string? LugarDeSiniestroEmbarcacion { get; set; }

        //Superficie Afectada
        public bool? Evacuó { get; set; }
        public int Kilometros { get; set; }
        public int Hectareas { get; set; }
        public int Metros { get; set; }
        public bool? EvacuacionParcial { get; set; }
        public bool? EvacuacionTotal { get; set; }
        public string DetalleSuperficieAfectadaIncendio { get; set; }
        public TipoCausaIncendio SuperficieAfectadaCausa { get; set;}
        //Fin Superficie Afectada
        public TipoIncendio Tipo { get; set; }
    }
}
