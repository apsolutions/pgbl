﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using System.Net;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Logistica.Models;


namespace Logistica.Controllers
{
    [Authorize]
    public class RolesController : Controller
    {

        private ApplicationDbContext context = new ApplicationDbContext();

        // GET: Roles
        public ActionResult Index()
        {
            var roles = context.Roles.ToList();
            return View(roles);
        }

        // GET: Roles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Roles/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                context.Roles.Add(new IdentityRole()
                {
                    Name = collection["Name"]
                });
                context.SaveChanges();
                ViewBag.ResultMessage = "Rol creado satisfactoriamente!";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Roles/Edit/5
        public ActionResult Edit(string id)
        {
            if (id.Equals(string.Empty))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var thisRole = context.Roles.Find(id);

            if (thisRole == null)
            {
                return HttpNotFound();
            }

            return View(thisRole);
        }

        // POST: Roles/Edit/5
        [HttpPost]
        public ActionResult Edit(IdentityRole role)
        {
            try
            {
                context.Entry(role).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Roles/Delete/5
        [HttpPost]
        public ActionResult Delete(string id)
        {
            try
            {
                var thisRole = context.Roles.Find(id);
                context.Roles.Remove(thisRole);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Users(string id)
        {
            if (id == null || id.Equals(string.Empty))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ViewBag.usersInRole = (from usr in context.Users
                               where usr.Roles.Where(r => r.RoleId.Equals(id, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault() != null
                               select new
                               {
                                   usr.Id,
                                   usr.UserName,
                                   Seleccionado = false
                               }
                               ).ToList();

            ViewBag.listaUsuarios = (from usuario in context.Users
                                     where usuario.Roles.Where(r => r.RoleId.Equals(id, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault() == null
                                     select new
                                     {
                                         usuario.Id,
                                         usuario.UserName,
                                         Seleccionado = false
                                     }
                                     ).ToList();
            ViewBag.rol = (from rol in context.Roles
                           where rol.Id.Equals(id)
                           select new
                           {
                               rol.Id,
                               rol.Name
                           }
                           ).ToList();

            if (ViewBag.usersInRole == null)
            {
                return HttpNotFound();
            }
            return View();
        }
    }
}
