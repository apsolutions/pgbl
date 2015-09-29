using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Logistica.Controllers
{
    [Authorize]
    public class ComunidadesController : Controller
    {
        // GET: Comunidad
        public ActionResult Index()
        {
            return View();
        }

        // GET: Comunidad/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Comunidad/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Comunidad/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Comunidad/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Comunidad/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Comunidad/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Comunidad/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
