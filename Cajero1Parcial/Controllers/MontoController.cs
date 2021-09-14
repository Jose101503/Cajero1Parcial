using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cajero1Parcial.Controllers
{
    public class MontoController : Controller
    {
        // GET: Monto
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Procesar(int Monto)
        {
         
            
            {
                if ((Monto % 5) == 0)
                {
                    return Redirect("/Monto/MostrarMonto");
                }
                else
                    return Redirect("/Monto/Error");
            }
        }

        public ActionResult MostrarMonto()
        {
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }
    }
}