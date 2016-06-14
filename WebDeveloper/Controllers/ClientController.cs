using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;

namespace WebDeveloper.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            //Sugerencia para la referencia Ctrl + .
            //Ordenar el código Ctrl + K + D
            var client = new ClientData();
            return View(client.GetList());
        }
    }
}