using BlazorApp1.Data.Enums;
using BlazorApp1.Data.Models.Salidas.Planillas;

namespace BlazorApp1.Data.Models.Salidas.Componentes
{
    public class Damnificado
    {
        public int DamnificadoId { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public TipoSexo Sexo { get; set; }
        public string LugarDeNacimiento { get; set; }
        public int Edad { get; set; }
        public TipoDamnificado? Estado {get; set;}
        public int? VehiculoId { get; set; }
        public VehiculoDamnificado VehiculoDamnificado { get; set; }

        public int SalidaId { get; set; }
        public Salida Salida { get; set; }
    }
}
