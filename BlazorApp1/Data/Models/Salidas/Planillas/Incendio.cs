using BlazorApp1.Data.Enums;
using BlazorApp1.Data.Models.Salidas.Componentes;

namespace BlazorApp1.Data.Models.Salidas.Planillas
{
    public class Incendio : Salida
    {
        //Localización, datos del solicitante, personas damnificadas y datos del seguro
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
        public TipoCausaIncendio SuperficieAfectadaCausa { get; set; }

        //Fin Superficie Afectada
        public TipoIncendio Tipo { get; set; }
        public TipoIncendioAbertura TipoAbertura { get; set; }
        public string OtraAbertura { get; set; }
        public TipoIncendioTecho TipoTecho { get; set; }
        public string OtroTecho { get; set; }
    }
}
