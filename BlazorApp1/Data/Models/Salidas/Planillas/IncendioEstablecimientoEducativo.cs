using BlazorApp1.Data.Enums;

namespace BlazorApp1.Data.Models.Salidas.Planillas
{
    public class IncendioEstablecimientoEducativo : Incendio
    {
        public TipoIncendioEstablecimientoEducativo TipoLugar { get; set; }
        public string OtroLugar { get; set; }
    }
}
