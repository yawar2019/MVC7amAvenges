using AdoNetExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdoNetExample.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Employee db = new Employee();
        public ActionResult Index()
        {
            return View(db.getEmployees());
        }
    }
}