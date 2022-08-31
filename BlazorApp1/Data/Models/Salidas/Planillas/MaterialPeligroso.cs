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
        public bool Evacuacion { get; set; }
        public bool Descontaminacion { get; set; }
        public bool Confinamiento { get; set; }
        public bool SinAccion { get; set; }
        public bool OtraAccionesPersonas { get; set; }
        public string DetallesAccionesPersonas { get; set; }

        //Superficie Aferctada
        public bool? Evacuó { get; set; }
        public int Kilometros { get; set; }
        public int Hectareas { get; set; }
        public int Metros { get; set; }
        public string DetalleSuperficieAfectada { get; set; }

        //Situación
        public bool? Derrame { get; set; }
        public bool? Incendio { get; set; }
        public bool? Indeterminado { get; set; }

        public TipoMaterialPeligroso Tipo { get; set; }
    }
}
