using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logistica.DbLogistica;
using Logistica.Models;

namespace Logistica.Controllers
{
    public class CampamentosController : Controller
    {

        private logisticaEntities logistica = new logisticaEntities();

        // GET: Campamentos
        public ActionResult Index()
        {
            ViewBag.campamentos = (from c in logistica.compound where c.disable == 0 select c).ToList();
            return View();
        }

        // GET: Campamentos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Campamentos/Create
        public ActionResult Create()
        {            
            return View(new CampamentoViewModel());
        }

        // POST: Campamentos/Create
        [HttpPost]
        public ActionResult Create(CampamentoViewModel collection)
        {
            try
            {
                var campamento = new compound() {
                    bedrooms = collection.Habitaciones,
                    capacity = collection.Capacidad,
                    cellphone_signal = Convert.ToInt16(collection.SenalCelular),
                    disable = Convert.ToInt16(false),
                    drinkable_water = Convert.ToInt16(collection.AguaPotable),
                    electricity = Convert.ToInt16(collection.Electricidad),
                    location = collection.Provincia,
                    name = collection.Nombre,
                    toilet_quantity = collection.CantidadBanos,
                    toilet_type = collection.tipoBano,
                    town = collection.Comunidad,
                    ventilation = collection.Ventilacion,
                    wifi = Convert.ToInt16(collection.Wifi)
                };

                logistica.compound.Add(campamento);

                logistica.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Campamentos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Campamentos/Edit/5
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

        // GET: Campamentos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Campamentos/Delete/5
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
