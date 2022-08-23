﻿namespace BlazorApp1.Data.Models
{
    public class MaterialesPeligrosos
    {
        public int MaterialesPeligrososId { get; set; }


        public string Sustancias { get; set; }


        public int AccionSobreMaterialesId { get; set; }
        public AccionSobreMateriales AccionSobreMateriales { get; set; }


        public int AccionSobrePersonasId { get; set; }
        public AccionSobrePersonas AccionSobrePersonas { get; set; }


        public string DatosDeSuperficie { get; set; }


        public string? Situacion { get; set; }


        public int SalidaId { get; set; }
        public Salida Salida { get; set; }
    }
}
