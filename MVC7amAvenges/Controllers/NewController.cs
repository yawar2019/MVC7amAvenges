using MVC7amAvenges.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC7amAvenges.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public string helloWorld()
        {
            return "Welcome to My Den";
        }

        public ActionResult getmeTahnos()
        {
            return Redirect("http://www.google.com");
        }

        [Route("Hyderabad/Superman/{id}")]
        [Route("Hyderabad/CronoVirus")]
        public ActionResult getmeTahnos2(int? id)
        {
            return Content("Welcome to jungle "+id);
        }

        public ActionResult getmeTahnos3()
        {
            return Content("<p style='color:red'>Welcome to My Den</p>");
        }
        public ContentResult getmeTahnos4()
        {
            return Content("<script>alert('welcome to world')</script>");
        }
        public string getMeId(int? id)
        {
            return "My Employee Id is "+id;
        }

        public ActionResult sendinfo() {

            ViewBag.info ="crona";
            return View();
        }

        public ActionResult sendinfo2()
        {
            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Prathyusha";
            obj.EmpSalary = 89493;

            ViewBag.info = obj;
            return View();
        }

        public ViewResult sendinfo3()
        {
            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Prathyusha";
            obj.EmpSalary = 89493;

            EmployeeModel obj1 = new Models.EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Neerja";
            obj1.EmpSalary = 79493;

            List<EmployeeModel> empList = new List<EmployeeModel>();
            empList.Add(obj);
            empList.Add(obj1);

            ViewBag.info = empList;


            return View();
        }
        public ViewResult sendinfo4()
        {
            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Prathyusha";
            obj.EmpSalary = 89493;

           
             
            return View(obj);
        }

        public ActionResult sendinfo5()
        {
            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Prathyusha";
            obj.EmpSalary = 89493;

            EmployeeModel obj1 = new Models.EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Neerja";
            obj1.EmpSalary = 79493;

            EmployeeModel obj3 = new Models.EmployeeModel();
            obj3.EmpId = 3;
            obj3.EmpName = "sai";
            obj3.EmpSalary = 59493;


            List<EmployeeModel> empList = new List<EmployeeModel>();
            empList.Add(obj);
            empList.Add(obj1);
            empList.Add(obj3);

            return View(empList);
        }

        public ViewResult sendinfo6()
        {
            return View();
        }

        public FileResult getmefile()
        {
            return File("~/Web.config","application/pdf");
        }
        public FileResult getmefile2()
        {
            return File("~/ActionResult.pdf", "application/pdf","Pokeman");
        }
        //thanks Pradeep for showing demo

        public JsonResult getmejson() {

            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Prathyusha";
            obj.EmpSalary = 89493;

            EmployeeModel obj1 = new Models.EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Neerja";
            obj1.EmpSalary = 79493;

            EmployeeModel obj3 = new Models.EmployeeModel();
            obj3.EmpId = 3;
            obj3.EmpName = "sai";
            obj3.EmpSalary = 59493;


            List<EmployeeModel> empList = new List<EmployeeModel>();
            empList.Add(obj);
            empList.Add(obj1);
            empList.Add(obj3);

            return Json(empList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult getmepartialView() {

            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Prathyusha";
            obj.EmpSalary = 89493;

            EmployeeModel obj1 = new Models.EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Neerja";
            obj1.EmpSalary = 79493;

            EmployeeModel obj3 = new Models.EmployeeModel();
            obj3.EmpId = 3;
            obj3.EmpName = "sai";
            obj3.EmpSalary = 59493;


            List<EmployeeModel> empList = new List<EmployeeModel>();
            empList.Add(obj);
            empList.Add(obj1);
            empList.Add(obj3);
            return View(empList);
        }

        public PartialViewResult getmepartialView2()
        {

            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Prathyusha";
            obj.EmpSalary = 89493;

            EmployeeModel obj1 = new Models.EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Neerja";
            obj1.EmpSalary = 79493;

            EmployeeModel obj3 = new Models.EmployeeModel();
            obj3.EmpId = 3;
            obj3.EmpName = "sai";
            obj3.EmpSalary = 59493;


            List<EmployeeModel> empList = new List<EmployeeModel>();
            empList.Add(obj);
            empList.Add(obj1);
            empList.Add(obj3);
            return PartialView("_MyPartialView", empList);
        }

        public RedirectResult GoToGoogle(int? id) {
            return Redirect("http://www.google.com");
        }

        public RedirectResult GoToGoogle2()
        {
            return Redirect("~/New/GoToGoogle?id=1");
        }

        public RedirectToRouteResult getmeRoute()
        {

            return RedirectToRoute("Default1");
        }
        public RedirectToRouteResult getmeRoute2()
        {
            EmployeeModel obj3 = new Models.EmployeeModel();
            obj3.EmpId = 3;
            obj3.EmpName = "sai";
            obj3.EmpSalary = 59493;

            return RedirectToAction("Index","Default", obj3);
        }

        public ActionResult HtmlHelperExample()
        {
            Employee db = new Employee();

            ViewBag.ShowEmployees = new SelectList(db.getEmployees(), "EmpId", "EmpName", 35035);

            EmployeeModel emp = new EmployeeModel();
            emp.EmpName = "jai";


            return View(emp);
        }

        public ActionResult ValidationExample()
        {

            return View();
        }
        [HttpPost]
        public ActionResult ValidationExample(RegisterModel r)
        {

            return View();
        }
    }
}