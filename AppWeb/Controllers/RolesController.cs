using AppWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppWeb.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RolesController : Controller
    {
        RoleRepository bd = new RoleRepository();
        // GET: Roles
        public ActionResult Index()
        {
            List<RoleViewModels> l = bd.list();

            return View(l);
        }
        // GET: Roles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Roles/Create
        [HttpPost]
        public ActionResult Create(RoleViewModels c)
        {
            bd.add(c);
            return RedirectToAction("index");
        }

        // GET: Roles/Edit/5
        public ActionResult Edit(string id)
        {
            RoleViewModels r = bd.findid(id);

            return View(r);
        }

        // POST: Roles/Edit/5
        [HttpPost]
        public ActionResult Edit(RoleViewModels c)
        {
            bd.update(c);

            return RedirectToAction("index");
        }

        // GET: Roles/Delete/5
        public ActionResult Delete(string id)
        {
            int v = bd.delete(id);

            if(v> 0)
            {
                return RedirectToAction("Erreur", "Colis");
            }
            return RedirectToAction("index");
        }

        // POST: Roles/Delete/5
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
