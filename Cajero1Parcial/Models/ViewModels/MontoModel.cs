using System.ComponentModel.DataAnnotations;


namespace Cajero1Parcial.Models.ViewModels
{
    public class MontoModel
    {
        [Display(Name = "Monto")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public int Monto { get; set; }
    }
    
}

