using AppWeb.ViewModels;
using AutoMapper;
using ClassLibrary;
using Metier.Repository;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AppWeb.Controllers
{
    [Authorize(Roles = "Admin")]
    public class EmployeController : Controller
    {
        EmployeRepository ty_ = new EmployeRepository();
        TypeEmployeRepository tp_ = new TypeEmployeRepository();
        
        // GET: TypeUser
        public ActionResult Index()
        {
            var us = Mapper.Map<IEnumerable<Employe>, IEnumerable<EmployeViewModel>>(ty_.list());
            return View(us);
        }

        public ActionResult Details(int id)
        {
            var us = Mapper.Map<Employe, EmployeViewModel>(ty_.findid(id));
            return View(us);
        }
        [HttpPost]
        public ActionResult Selectnom(string nom)
        {
            var us = Mapper.Map<IEnumerable<Employe>, IEnumerable<EmployeViewModel>>(ty_.findnom(nom));
            return View("index",us);
        }
        // GET: TypeUser/Create
        public ActionResult Create()
        {
            ViewBag.TypeEmployeid =  new SelectList(tp_.list(), "TypeEmployeid", "nomTypeEmploye");


            return View();
        }

        // POST: TypeUser/Create
        [HttpPost]
        public ActionResult Create(EmployeViewModel cl)
        {
            if (ModelState.IsValid)
            {
                var us_ = Mapper.Map<EmployeViewModel, Employe>(cl);
                ty_.add(us_);

                return RedirectToAction("Index");
            }
            ViewBag.TypeEmployeid = new SelectList(tp_.list(), "TypeEmployeid", "nomTypeEmploye");
            return View(cl);
        }

        // GET: TypeUser/Edit/5
        public ActionResult Edit(int id)
        {
           
            var us = Mapper.Map<Employe, EmployeViewModel>(ty_.findid(id));
            ViewBag.TypeEmployeid = new SelectList(tp_.list(), "TypeEmployeid", "nomTypeEmploye",us.typeEmployeid);
            return View(us);
        }

        // POST: TypeUser/Edit/5
        [HttpPost]
        public ActionResult Edit(EmployeViewModel cl)
        {
            if (ModelState.IsValid)
            {
                var us = Mapper.Map<EmployeViewModel, Employe>(cl);
                ty_.update(us);
                return RedirectToAction("index");
            }
            ViewBag.TypeEmployeid = new SelectList(tp_.list(), "TypeEmployeid", "nomTypeEmploye",cl.TypeEmploye.TypeEmployeid);
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
