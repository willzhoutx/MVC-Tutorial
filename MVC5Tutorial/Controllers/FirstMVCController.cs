using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5Tutorial.Models;

namespace MVC5Tutorial.Controllers
{
    public class FirstMVCController : Controller
    {
        // GET: FirstMVC
        public ActionResult SayHello()
        {
            ViewData["CurrentTime"] = DateTime.Now.ToString();

            Employee emp = new Employee();
            emp.FirstName = "Joe";
            emp.LastName = "Blow";
            emp.Salary = 80000;
            //ViewData["Employee"] = emp;
            ViewBag.Employee = emp;

            return View("HelloView");
        }
    }
}