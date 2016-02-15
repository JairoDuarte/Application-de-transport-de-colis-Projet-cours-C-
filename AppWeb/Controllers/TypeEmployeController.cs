using AppWeb.ViewModels;
using AutoMapper;
using ClassLibrary;
using Metier.Repository;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AppWeb.Controllers
{
    [Authorize(Roles = "Admin")]
    public class TypeEmployeController : Controller
    {

        TypeEmployeRepository ty_ = new TypeEmployeRepository();

        // GET: TypeUser
        public ActionResult Index()
        {
            var us = Mapper.Map<IEnumerable<TypeEmploye>, IEnumerable<TypeEmployeViewModel>>(ty_.list());
            return View(us);
        }

        // GET: TypeUser/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TypeUser/Create
        [HttpPost]
        public ActionResult Create(TypeEmployeViewModel cl)
        {
            if (ModelState.IsValid)
            {
                var us_ = Mapper.Map<TypeEmployeViewModel, TypeEmploye>(cl);
                ty_.add(us_);

                return RedirectToAction("Index");
            }

            return View(cl);
        }

        // GET: TypeUser/Edit/5
        public ActionResult Edit(int id)
        {
            var us = Mapper.Map<TypeEmploye, TypeEmployeViewModel>(ty_.findid(id));
            return View(us);
        }

        // POST: TypeUser/Edit/5
        [HttpPost]
        public ActionResult Edit(TypeEmployeViewModel cl)
        {
            if (ModelState.IsValid)
            {
                var us = Mapper.Map<TypeEmployeViewModel, TypeEmploye>(cl);
                ty_.update(us);
                return RedirectToAction("index");
            }
            return View(cl);
        }

        // GET: TypeUser/Delete/5
        public ActionResult Delete(int id)
        {
            ty_.delete(id);
            return RedirectToAction("index");
        }
    }
}
