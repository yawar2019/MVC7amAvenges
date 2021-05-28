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
        [HttpGet]
        public ActionResult Create() {

            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
           int i = db.saveEmployees(emp);
            if (i > 0)
            {
                return Redirect("Index");
            }
            else
            {
                return View();
            }
           
        }

        [HttpGet]
        public ActionResult Edit(int ? id)
        {
            EmployeeModel emp= db.getEmployeesById(id);

            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            int i = db.UpdateEmployees(emp);
            if (i > 0)
            {
                return Redirect("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            EmployeeModel emp = db.getEmployeesById(id);
            return View(emp);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            int i = db.DeleteEmployee(id);
            if (i > 0)
            {
                // return Redirect("~/Default/Index");
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public ActionResult getMyService()
        {
            ServiceReference1.MyWebServiceSoapClient obj = new ServiceReference1.MyWebServiceSoapClient();
           ViewBag.Add= obj.Add(5,10);
            ServiceReference2.MyWcfService1Client obj1 = new ServiceReference2.MyWcfService1Client();
            ViewBag.Add2 = obj.Add(5, 10);
            return View();

        }

       
    }
}