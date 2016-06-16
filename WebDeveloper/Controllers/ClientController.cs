using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class ClientController : Controller
    {
        private ClientData _client = new ClientData();
        // GET: Client
        public ActionResult Index()
        {
            //Sugerencia para la referencia Ctrl + .
            //Ordenar el código Ctrl + K + D
            var client = new ClientData();
            return View(client.GetList());
        }

        public ActionResult Create()
        {
            return View(new Client());
        }
        [HttpPost]
        public ActionResult Create(Client client)
        {
            //var client = new ClientData();
            //client.Add(new Model.Client() { Name = collection["Name"], LastName = collection["LastName"] });
            //return RedirectToAction("Index", "Client");
            if (ModelState.IsValid)
            {
                _client.Add(client);
                return RedirectToAction("Index", "Client");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            //return View(_client.GetList().Where(x => x.Id == id).FirstOrDefault());
            return View(_client.GetClientById(id));
        }

        [HttpPost]
        public ActionResult Edit(Client client)
        {
            if (ModelState.IsValid)
            {
                _client.Update(client);
                return RedirectToAction("Index", "Client");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            //return View(_client.GetList().Where(x => x.Id == id).FirstOrDefault());
            var client = _client.GetClientById(id);
            if (client == null) return RedirectToAction("Index");
            return View(client);
        }

        [HttpPost]
        public ActionResult Delete(Client client)
        {
            //_client.Delete(_client.GetList().Where(x => x.Id == client.Id).FirstOrDefault());
            if (_client.Delete(_client.GetClientById(client.Id)) > 0)
                return RedirectToAction("Index", "Client");
            return View(client);
        }
    }
}