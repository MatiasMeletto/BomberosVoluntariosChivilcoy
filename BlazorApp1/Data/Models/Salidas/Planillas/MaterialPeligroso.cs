using BlazorApp1.Data.Enums;

namespace BlazorApp1.Data.Models.Salidas.Planillas
{
    public class MaterialesPeligrosos : Salida
    {
        //Localización, datos del solicitante, personas damnificadas y datos del seguro

        public string Sustancias { get; set; }

        //Acciones sobre los materiales
        public bool Controlada { get; set; }
        public bool Venteo { get; set; }
        public bool DilucionDeVapores { get; set; }
        public bool Neutralizacion { get; set; }
        public bool Trasvase { get; set; }
        public bool OtraAccionesMateriales { get; set; }
        public string DetallesAccionesMateriales { get; set; }

        //Acciones sobre las personas
        public TipoEvacuacion Evacuacion { get; set; }
        public bool Descontaminacion { get; set; }
        public bool Confinamiento { get; set; }
        public bool SinAccion { get; set; }
        public bool OtraAccionesPersonas { get; set; }
        public string DetallesAccionesPersonas { get; set; }

        //Superficie Aferctada
        public TipoSuperficie TipoSuperficie { get; set; }
        public string DetalleSuperficieAfectada { get; set; }

        //Situación
        public TipoSituacionExplosion TipoSituacion { get; set; }

        public TipoMaterialPeligroso Tipo { get; set; }
    }
}
