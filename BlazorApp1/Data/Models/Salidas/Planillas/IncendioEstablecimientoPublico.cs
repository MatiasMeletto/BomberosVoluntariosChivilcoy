using BlazorApp1.Data.Enums;

namespace BlazorApp1.Data.Models.Salidas.Planillas
{
    public class IncendioEstablecimientoPublico : Incendio  
    {
        public TipoIncendioEstablecimientoPublico TipoLugar { get; set; }
    }
}
