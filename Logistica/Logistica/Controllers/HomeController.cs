using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Logistica.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Brigadas()
        {
            return View("Index");
        }

        public ActionResult Metricas()
        {
            return View("Index");
        }

        public ActionResult Configuraciones()
        {
            return View("Index");
        }
    }
}