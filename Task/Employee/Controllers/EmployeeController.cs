using Employee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee.Controllers
{
    public class EmployeeController : Controller
    {
        employeeDbEntities db=new employeeDbEntities();
        
        public ActionResult Index()
        {
            List<tblEmployee> list=db.tblEmployees.ToList();
            return View(list);
        }

        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tblEmployee employee)
        {
            db.tblEmployees.Add(employee);
            db.SaveChanges();

            return RedirectToAction("Index"); 

           
        }

        public ActionResult Edit()
        {
            return View();
        }
        
        public ActionResult Delete()
        {
            return View();
        }
    }
}
