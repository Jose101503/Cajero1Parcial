using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cajero1Parcial.Models.ViewModels
{
    public class MontoModel
    {
        [Display(Name = "Monto")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public int Monto { get; set; }
    }
    public ActionResult()
    {

        return ViewModels();
    }
}

