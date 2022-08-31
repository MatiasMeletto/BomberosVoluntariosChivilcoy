using BlazorApp1.Data.Enums;
using BlazorApp1.Data.Models.Salidas.Componentes;

namespace BlazorApp1.Data.Models.Salidas.Planillas
{
    public class Incendio : Salida
    {
        //Localización, datos del solicitante, personas damnificadas y datos del seguro
        public bool DeteccionAutomaticaId { get; set; }

        public bool? Extintor { get; set; }
        public bool? Hidrante { get; set; }
        public List<EmbarcacionAfectada> EmbarcacionAfectadas { get; set; }
        public List<VehiculoAfectado> VehiculoAfectados { get; set; }
        public TipoLugarSiniestroEmbarcacion TipoLugarSiniestroEmbarcacion { get; set; }
        public string? OtroLugarDeSiniestroEmbarcacion { get; set; }

        //Superficie Afectada
        public TipoEvacuacion TipoEvacuacion { get; set; }
        public TipoSuperficie TipoSuperficieAfectada { get; set; }
        public string DetalleSuperficieAfectadaIncendio { get; set; }
        public TipoCausaIncendio SuperficieAfectadaCausa { get; set; }

        //Fin Superficie Afectada
        public TipoIncendio Tipo { get; set; }
        public TipoIncendioAbertura TipoAbertura { get; set; }
        public string OtraAbertura { get; set; }
        public TipoIncendioTecho TipoTecho { get; set; }
        public string OtroTecho { get; set; }
        public string OtroLugar { get; set; }
    }
}
