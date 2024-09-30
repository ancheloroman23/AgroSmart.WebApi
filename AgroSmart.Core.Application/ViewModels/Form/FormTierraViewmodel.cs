using System.ComponentModel.DataAnnotations;

namespace AgroSmart.Core.Application.ViewModels.Form
{
    public class FormTierraViewmodel
    {
        [Required]
        public string TipoDeSuelo { get; set; }

        [Required]
        public string HumedadTerreno { get; set; }

        [Required]
        public string Drenaje { get; set; }

        [Required]
        public string LuzSolar { get; set; }

        [Required]
        public string TipoDeRiego { get; set; }

        [Required]
        public string TipoDeFertilizacion { get; set; }

        [Required]
        public bool ProblemasDePlagas { get; set; }

        [Required]
        public string TamanoTerreno { get; set; }
    }
}
