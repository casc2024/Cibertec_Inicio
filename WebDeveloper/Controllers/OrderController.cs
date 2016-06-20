using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class OrderController : Controller
    {
        private OrderData _order = new OrderData();
        // GET: Order
        public ActionResult Index()
        {
            return View(_order.GetList());
        }

        public ActionResult Details()
        {
            return View();
        }
    }
}