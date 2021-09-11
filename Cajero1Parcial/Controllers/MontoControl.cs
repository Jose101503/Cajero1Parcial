using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cajero1Parcial.Controllers
{
    public class MontoControl
    {

        public ActionResult procesar(int Monto)
        {

            if ((Monto % 5) == 0) { 
            return RedirectResult("/CajeroVistas/VistaError");
        }
            else
            {
                return RedirectResult("/CajeroVistas/MontoMostrar");
            }
        }

        private ActionResult RedirectResult(string v)
        {
            throw new NotImplementedException();
        }

    }
    
}