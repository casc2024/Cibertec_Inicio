using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class RazorController : Controller
    {
        // GET: Razor
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
    }
}