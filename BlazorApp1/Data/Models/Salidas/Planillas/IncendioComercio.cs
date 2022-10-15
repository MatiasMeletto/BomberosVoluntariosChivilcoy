using BlazorApp1.Data.Enums;

namespace BlazorApp1.Data.Models.Salidas.Planillas
{
    public class IncendioComercio : Incendio
    {
        public TipoLugarComercioIncendio TipoLugar { get; set; }
    }
}
