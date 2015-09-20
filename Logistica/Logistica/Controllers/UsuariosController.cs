using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;
using Logistica.Models;
using Microsoft.AspNet.Identity.Owin;
using System.Threading.Tasks;
using System.Net;

namespace Logistica.Controllers
{
    [Authorize]
    public class UsuariosController : Controller
    {
        private ApplicationDbContext identity = new ApplicationDbContext();

        private ApplicationUserManager _userManager;

        public UsuariosController()
        {
        }

        public UsuariosController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        // GET: Usuarios
        public ActionResult Index()
        {
            ViewBag.usuarios = (from u in identity.Users
                            select new
                            {
                                u.Id,
                                u.UserName,
                                Seleccionado = false
                            }).ToList();
            return View();
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(UsuarioViewModel collection)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = collection.UserName, Email = collection.UserName };
                var result = await UserManager.CreateAsync(user, "GlobalPanama01!");
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                ViewBag.result = result;
            }

            // If we got this far, something failed, redisplay form
            return View(collection);
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(string id)
        {
            if (id.Equals(string.Empty))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var user = identity.Users.Find(id);

            if (user == null)
            {
                return HttpNotFound();
            }

            UsuarioViewModel usuario = new UsuarioViewModel() { Id = user.Id, UserName = user.UserName };
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        public ActionResult Edit(UsuarioViewModel collection)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // TODO: Add update logic here
                    var usuario = identity.Users.Find(collection.Id);
                    usuario.UserName = collection.UserName;
                    usuario.Email = collection.UserName;
                    identity.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View(collection);
                }
            }

            return View(collection);
            
        }

        // POST: Usuarios/Delete/5
        [HttpPost]
        public ActionResult Delete(string id)
        {
            if (id.Equals(string.Empty))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var user = identity.Users.Find(id);

            if (user == null)
            {
                return HttpNotFound();
            }

            try
            {
                // TODO: Add update logic here
                identity.Users.Remove(user);
                identity.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }            
        }

        public ActionResult Roles(string id)
        {
            if (id == null || id.Equals(string.Empty))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ViewBag.rolesUsuario = (from r in identity.Roles
                                where r.Users.Where(u => u.UserId.Equals(id, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault() != null
                                select new
                                {
                                    r.Id,
                                    r.Name,
                                    Seleccionado = false
                                }).ToList();
            
            ViewBag.rolesDisponibles = (from r in identity.Roles
                                        where r.Users.Where(u => u.UserId.Equals(id, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault() == null
                                        select new
                                        {
                                            r.Id,
                                            r.Name,
                                            Seleccionado = false
                                        }).ToList();
            ViewBag.usuario = (from u in identity.Users
                               where u.Id.Equals(id, StringComparison.CurrentCultureIgnoreCase)
                               select new
                               {
                                   u.Id,
                                   u.UserName
                               }).ToList();
            if (ViewBag.rolesUsuario == null)
            {
                return HttpNotFound();
            }

            return View();
        }

        [HttpPost]
        public bool SalvarRoles(string userName, List<RolesViewModel> roles)
        {
            try
            {
                var usuario = identity.Users.FirstOrDefault(u => u.UserName.Equals(userName, StringComparison.CurrentCultureIgnoreCase));
                var rolesUsuario = usuario.Roles.ToList();

                if (rolesUsuario.Count != 0)
                {
                    foreach (var rol in rolesUsuario)
                    {
                        usuario.Roles.Remove(rol);
                    }
                }

                if (roles != null && roles.Count != 0)
                {
                    foreach (var rol in roles)
                    {
                        usuario.Roles.Add(new IdentityUserRole()
                        {
                            RoleId = rol.Id
                        });
                    }
                }

                identity.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpPost]
        public async Task<bool> RestablecerContrasena(string id)
        {
            try
            {
                var remove = await UserManager.RemovePasswordAsync(id);
                if (remove.Succeeded)
                {
                    var reset = await UserManager.AddPasswordAsync(id, "GlobalPanama01!");
                    if (reset.Succeeded)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
