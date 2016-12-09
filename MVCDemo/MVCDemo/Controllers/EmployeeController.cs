using System.Web.Mvc;
using BusinessLayer;
using System.Collections.Generic;
using System.Linq;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employeer
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            List<Employee> employees = employeeBusinessLayer.Employees.ToList();

            return View(employees);
        }

        [HttpGet]
        public ActionResult Create()
        {
           

            return View();
        }
    }
}