using BlazorApp1.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Data.Models.Personales
{
    public class BomberoDependencia
    {
        public int BomberoDependenciaId { get; set; }

        public TipoRol Rol { get; set; }

        public int PersonaId { get; set; }
        [ForeignKey("PersonaId")]
        public Bombero Bombero { get; set; }

        public int DependenciaId { get; set; }
        public Dependencia Dependencia { get; set; }
    }
}
