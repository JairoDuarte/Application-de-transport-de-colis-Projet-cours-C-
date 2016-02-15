using AppWeb.ViewModels;
using AutoMapper;
using ClassLibrary;
using Metier.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppWeb.Controllers
{
    [Authorize(Roles = "Admin")]
    public class VoieController : Controller
    {

        VoieTransmissionRepository ty_ = new VoieTransmissionRepository();

            // GET: TypeUser
        public ActionResult Index()
        {
            var us = Mapper.Map<IEnumerable<VoieTransmission>, IEnumerable<VoieTransmissionViewModel>>(ty_.list());
            return View(us);
        }

        // GET: TypeUser/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TypeUser/Create
        [HttpPost]
        public ActionResult Create(VoieTransmissionViewModel cl)
        {
            if (ModelState.IsValid)
            {
                var us_ = Mapper.Map<VoieTransmissionViewModel, VoieTransmission>(cl);
                ty_.add(us_);

                return RedirectToAction("Index");
            }

            return View(cl);
        }

        // GET: TypeUser/Edit/5
        public ActionResult Edit(int id)
        {
            var us = Mapper.Map<VoieTransmission, VoieTransmissionViewModel>(ty_.findid(id));
            return View(us);
        }

        // POST: TypeUser/Edit/5
        [HttpPost]
        public ActionResult Edit(VoieTransmissionViewModel cl)
        {
            if (ModelState.IsValid)
            {
                var us = Mapper.Map<VoieTransmissionViewModel, VoieTransmission>(cl);
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
