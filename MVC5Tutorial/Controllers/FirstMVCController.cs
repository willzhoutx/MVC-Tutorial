using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Tutorial.Controllers
{
    public class FirstMVCController : Controller
    {
        // GET: FirstMVC
        public ActionResult SayHello()
        {
            ViewData["CurrentTime"] = DateTime.Now.ToString();
            return View("HelloView");
        }
    }
}