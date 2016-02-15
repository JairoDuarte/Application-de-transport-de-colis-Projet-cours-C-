using AppWeb.ViewModels;
using AutoMapper;
using ClassLibrary;
using Metier.Repository;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AppWeb.Controllers
{
    public class TypeUserController : Controller
    {
        /*TypeUserRepository ty_ = new TypeUserRepository();

        // GET: TypeUser
        public ActionResult Index()
        {
            var us = Mapper.Map<IEnumerable<TypeUser>, IEnumerable<TypeUserViewModel>>(ty_.list());
            return View(us);
        }

        // GET: TypeUser/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TypeUser/Create
        [HttpPost]
        public ActionResult Create(TypeUserViewModel cl)
        {
            if (ModelState.IsValid)
            {
                var us_ = Mapper.Map<TypeUserViewModel, TypeUser>(cl);
                ty_.add(us_);

                return RedirectToAction("Index");
            }

            return View(cl);
        }

        // GET: TypeUser/Edit/5
        public ActionResult Edit(int id)
        {
            var us = Mapper.Map<TypeUser,TypeUserViewModel>(ty_.findid(id));
            return View(us);
       }

        // POST: TypeUser/Edit/5
        [HttpPost]
        public ActionResult Edit(TypeUserViewModel cl)
        {
            if (ModelState.IsValid)
            {
                var us = Mapper.Map<TypeUserViewModel, TypeUser>(cl);
                ty_.update(us);
                return RedirectToAction("index");
            }
            return View (cl);
        }

        // GET: TypeUser/Delete/5
        public ActionResult Delete(int id)
        {
            ty_.delete(id);
            return RedirectToAction("index");
        }
        */
    }
}
