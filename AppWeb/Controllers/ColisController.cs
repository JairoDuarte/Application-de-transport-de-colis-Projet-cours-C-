using AppWeb.ViewModels;
using AutoMapper;
using ClassLibrary;
using Metier.Repository;
using System.Collections.Generic;
using System.Web.Mvc;
using System;

namespace AppWeb.Controllers
{
    public class ColisController : Controller
    {
        VoieTransmissionRepository voiet = new VoieTransmissionRepository();
        ColisRepository ty_ = new ColisRepository();
        ClientRepository cli = new ClientRepository();
        NatureColisRepository nature = new NatureColisRepository();
        VilleRepository ville = new VilleRepository();
        TypeColisRepository tc = new TypeColisRepository();
        EmployeRepository em = new EmployeRepository();
        List<string> d;
        
        // GET: TypeUser
        public ActionResult Index()
        {
            var us = Mapper.Map<List<Colis>, List<ColisViewModel>>(ty_.list());
           
            return View(us);
        }

        public ActionResult Details(int id)
        {
            var us = Mapper.Map<Colis, ColisViewModel>(ty_.findid(id));
            if (us.Colisid == -1)
            {
                return View("Erreur");
            }
           
            return View(us);
                
        }
        public ActionResult Suivre(int id)
        {
            var us = Mapper.Map<Colis, ColisViewModel>(ty_.findid(id));
            if (us.Colisid == -1)
            {
                return View("Erreur");
            }

            return View(us);
        }
        // GET: TypeUser/Create
        public ActionResult Create()
        {
            d = new List<string>();
            d.Add("En preparation");
            d.Add("En Acheminement");
            d.Add("En Livraison");

            ViewBag.Clientid = new SelectList(cli.list(), "Clientid", "nomClient");
            ViewBag.naturecolisid = new SelectList(nature.list(), "NatureColisid", "nomNatureColis");
            ViewBag.typecolisid = new SelectList(tc.list(), "TypeColisid", "nomTypeColis");
            ViewBag.voietransmissionid = new SelectList(voiet.list(), "VoieTransmissionid", "VoieTransmissionNom");
            ViewBag.villeArriveColisid = new SelectList(ville.list(), "Villeid", "nomVille");
            ViewBag.villeDepartColisid = new SelectList(ville.list(), "Villeid", "nomVille");
            ViewBag.etatColis = new SelectList(d);
                
            return View();
        }

        // POST: TypeUser/Create
        [HttpPost]

        public ActionResult Create(ColisViewModel cl)
        {
            cl.date = DateTime.Now;

            if (ModelState.IsValid)
            {
                var us_ = Mapper.Map<ColisViewModel, Colis>(cl);
                ty_.add(us_);

                return RedirectToAction("Index");
            }
            ViewBag.Clientid = new SelectList(cli.list(), "Clientid", "nomClient");
            ViewBag.naturecolisid = new SelectList(nature.list(), "NatureColisid", "nomNatureColis");
            ViewBag.typecolisid = new SelectList(tc.list(), "TypeColisid", "nomTypeColis");
            ViewBag.voietransmissionid = new SelectList(voiet.list(), "VoieTransmissionid", "VoieTransmissionNom");
            ViewBag.villeArriveColisid = new SelectList(ville.list(), "Villeid", "nomVille");
            ViewBag.villeDepartColisid = new SelectList(ville.list(), "Villeid", "nomVille");
            ViewBag.etatColis = new SelectList(d);

            return View(cl);
        }

        // GET: TypeUser/Edit/5
        public ActionResult Edit(int id)
        {
            var us = Mapper.Map<Colis, ColisViewModel>(ty_.findid(id));
            d = new List<string>();
            d.Add("En preparation");
            d.Add("En Acheminement");
            d.Add("En Livraison");
            ViewBag.Clientid = new SelectList(cli.list(), "Clientid", "nomClient",us.clientid);
            ViewBag.naturecolisid = new SelectList(nature.list(), "NatureColisid", "nomNatureColis",us.naturecolisid);
            ViewBag.typecolisid = new SelectList(tc.list(), "TypeColisid", "nomTypeColis",us.typecolisid);
            ViewBag.voietransmissionid = new SelectList(voiet.list(), "VoieTransmissionid", "VoieTransmissionNom",us.voietransmissionid);
            ViewBag.villeArriveColisid = new SelectList(ville.list(), "Villeid", "nomVille",us.villeArriveColisid);
            ViewBag.villeDepartColisid = new SelectList(ville.list(), "Villeid", "nomVille",us.villeDepartColisid);
            ViewBag.etatColis = new SelectList(d,us.etatColis);

            return View(us);
        }

        // POST: TypeUser/Edit/5
        [HttpPost]
        public ActionResult Edit(ColisViewModel cl)
        {
            if (ModelState.IsValid)
            {
                var us = Mapper.Map<ColisViewModel, Colis>(cl);
                ty_.update(us);
                return RedirectToAction("index");
            }
            d = new List<string>();
            d.Add("En preparation");
            d.Add("En Acheminement");
            d.Add("En Livraison");
            ViewBag.Clientid = new SelectList(cli.list(), "Clientid", "nomClient", cl.clientid);
            ViewBag.naturecolisid = new SelectList(nature.list(), "NatureColisid", "nomNatureColis", cl.naturecolisid);
            ViewBag.typecolisid = new SelectList(tc.list(), "TypeColisid", "nomTypeColis", cl.typecolisid);
            ViewBag.voietransmissionid = new SelectList(voiet.list(), "VoieTransmissionid", "VoieTransmissionNom", cl.voietransmissionid);
            ViewBag.villeArriveColisid = new SelectList(ville.list(), "Villeid", "nomVille", cl.villeArriveColisid);
            ViewBag.villeDepartColisid = new SelectList(ville.list(), "Villeid", "nomVille", cl.villeDepartColisid);

            ViewBag.etatColis = new SelectList(d,cl.etatColis);
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
