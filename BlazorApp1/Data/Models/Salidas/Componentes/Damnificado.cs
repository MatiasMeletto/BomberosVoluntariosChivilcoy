using Vista.Data.Enums;
using Vista.Data.Models.Salidas.Planillas;
using System.ComponentModel.DataAnnotations;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class Damnificado
    {
        public int DamnificadoId { get; set; }

        [Required, StringLength(255)]
        public string Nombre { get; set; }
        [Required, StringLength(255)]
        public string Apellido { get; set; }
        [Required, StringLength(255)]
        public string Dni { get; set; }
        public TipoSexo Sexo { get; set; }
        [Required, StringLength(255)]
        public string LugarDeNacimiento { get; set; }
        public int Edad { get; set; }
        public TipoDamnificado Estado {get; set;}

        public VehiculoDamnificado? VehiculoDamnificado { get; set; }

        public int SalidaId { get; set; }
        public Salida Salida { get; set; }
    }
}
