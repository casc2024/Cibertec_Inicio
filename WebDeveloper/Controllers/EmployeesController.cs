using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.Model;
using WebDeveloper.DataAccess;

namespace WebDeveloper.Controllers
{
    public class EmployeesController : Controller
    {
        //private EmployeesData _employees = new EmployeesData();
        private EmployeesData _employees;
        public EmployeesController(EmployeesData employees) {
            _employees = employees;
        }
        // GET: Employees
        public ActionResult Index()
        {
            return View(_employees.GetList());
        }

        public ActionResult Create() {
            return View(new Employees());
        }

        [HttpPost]
        public ActionResult Create(Employees _employee)
        {
            if (ModelState.IsValid)
            {
                _employees.Add(_employee);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            return View(_employees.GetEmployeeById(id));
        }

        [HttpPost]
        public ActionResult Edit(Employees _employee)
        {
            if (ModelState.IsValid)
            {
                _employees.Update(_employee);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            return View(_employees.GetEmployeeById(id));
        }
        [HttpPost]
        public ActionResult Delete(Employees _employee)
        {
            if (_employees.Delete(_employees.GetEmployeeById(_employee.Id)) > 0) return RedirectToAction("Index");
            return View();
        }
    }
}