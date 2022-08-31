using BlazorApp1.Data.Enums;

namespace BlazorApp1.Data.Models.Salidas.Planillas
{
    public class IncendioForestal : Incendio
    {
        public TipoIncendioForestal TipoLugar { get; set; }
        public string OtroLugar { get; set; }
    }
}
