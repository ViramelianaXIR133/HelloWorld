using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HelloworldController : Controller
    {
        // GET: Helloworld
        public ActionResult Index()
        {
            return View();
        }
    }
}