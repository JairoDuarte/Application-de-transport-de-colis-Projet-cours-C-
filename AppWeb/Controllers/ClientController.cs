using System.Collections.Generic;
using System.Web.Mvc;
using Metier.Repository;
using AutoMapper;
using ClassLibrary;
using AppWeb.ViewModels;

namespace AppWeb.Controllers
{
    public class ClientController : Controller
    {
        private ClientRepository _client = new ClientRepository();
        // GET: Client
        public ActionResult Index()
        {
            var cl = _client.list();
            var _clientViewModel = Mapper.Map<IEnumerable<Client>,IEnumerable<ClientViewModel>>(cl);

            return View(_clientViewModel);
        }

        // GET: Client/Details/5
        public ActionResult Details(int id)
        {
            var clientv = Mapper.Map<Client,ClientViewModel>(_client.findid(id));
            return View(clientv);
        }

        // GET: Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientViewModel cl)
        {
            if (ModelState.IsValid)
            {
               var clientv = Mapper.Map<ClientViewModel, Client>(cl);
               _client.add(clientv);

                return RedirectToAction("Index");
            }
            return View(cl);

        }

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            var clientv = Mapper.Map<Client, ClientViewModel>(_client.findid(id));
            return View(clientv);
        }

        // POST: Client/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( ClientViewModel cl)
        {
            if (ModelState.IsValid)
            {
               var clientv = Mapper.Map<ClientViewModel, Client>(cl);
               _client.update(clientv);

                return RedirectToAction("Index");
            }
            return View(cl);
        }

        // GET: Client/Delete/5
        public ActionResult Delete(int id)
        {
            var cl = Mapper.Map<Client, ClientViewModel>(_client.findid(id));
            return View(cl);
        }

        // POST: Client/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ClientViewModel c)
        {
            _client.delete(id);
            return RedirectToAction("index");
         
        }
    }
}
