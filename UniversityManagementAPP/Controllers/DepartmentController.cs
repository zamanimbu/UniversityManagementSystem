using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementAPP.BLL;
using UniversityManagementAPP.Models;

namespace UniversityManagementAPP.Controllers
{
    public class DepartmentController : Controller
    {
        //
        // GET: /Department/
        public ActionResult SaveDepartment()
        {
            return View();
        }
        DepartmentManager aDepartmentManager = new DepartmentManager();
        [HttpPost]
        public ActionResult SaveDepartment(Department aDepartment)
        {
            ViewBag.message = aDepartmentManager.Save(aDepartment);

            return View();
        }

        public ActionResult ViewAllDepartments()
        {
            List<Department> departments = aDepartmentManager.GetAllDepartments();
            return View(departments);
        }
       

	}
}