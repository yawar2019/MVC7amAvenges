using MVC7amAvenges.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC7amAvenges.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index(EmployeeModel emp)
        {
            return View();
        }

        [OutputCache(Duration =20,Location =System.Web.UI.OutputCacheLocation.Client)]
        public ActionResult getMeData()
        {
            return View();
        }
    }
}