using BlazorApp1.Data.Models.Salidas.Componentes;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data.Models.Personales
{
    public class Dependencia
    {
        public int DependenciaId { get; set; }

        [Required, StringLength(255)]
        public string NombreDependencia { get; set; }

        public List<BomberoDependencia> Bomberos { get; set; } = new();

        public List<IncidenteDependencia> Incidentes { get; set; } = new();
    }
}
