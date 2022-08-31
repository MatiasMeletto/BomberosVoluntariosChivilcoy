using BlazorApp1.Data.Enums;

namespace BlazorApp1.Data.Models.Salidas.Planillas
{
    public class IncendioVivienda : Incendio
    {
        public TipoIncendioVivienda TipoLugar { get; set; }
        public string OtroLugar { get; set; }
    }
}
