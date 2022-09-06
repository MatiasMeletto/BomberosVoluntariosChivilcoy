﻿using BlazorApp1.Data.Enums;

namespace BlazorApp1.Data.Models.Salidas.Planillas
{
    public class FactorClimatico : Salida
    {
        //Localización, datos del solicitante, personas damnificadas y datos del seguro

        public TipoFactoresClimaticos Tipo { get; set; }

        //Daños superficie evacuada
        public bool? Evacuó { get; set; }
        public int Kilometros { get; set; }
        public int Hectareas { get; set; }
        public int Metros { get; set; }
        public string DetalleSuperficieDañada { get; set; }

    }
}