using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.ActionFilters;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    //Un pretipo para el enrrutamiento, prefijo con el cual se va ingresar sera "Razor"
    [LogActionFilter]
    [RoutePrefix("Razor")]
    public class RazorController : Controller
    {
        // GET: Razor
        [Route]
        public ActionResult Index()
        {
            //var client = new Client()
            //{
            //    Id = 1,
            //    LastName = "Cueva",
            //    Name = "Aladino"
            //};
            //return View(client);
            var lclient = new List<Client>()
            {
                new Client { Id = 1, Name ="Aladino1", LastName ="Cueva"},
                new Client { Id = 2, Name ="Aladino2", LastName ="Cueva"},
                new Client { Id = 3, Name ="Aladino3", LastName ="Cueva"}
            };
            return View(lclient);
        }

        public ActionResult Product() {
            var productData = new ProductData();
            return View(productData.GetFakeProducts());
        }

        // ViewBag.{} ó ViewBag["    "]
        [Route("Entry/{date:DateTime}")]//donde se va recibir parametros se tiene q poner el tipo
        public ActionResult EntryDate(DateTime date) {
            ViewBag.Date = date.ToShortDateString();
            return View();
        }

        [Route("Entry/{id:int}")]
        public string EntryId(int id) {
            return id.ToString();
        }
    }
}