using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementAPP.BLL;
using UniversityManagementAPP.Models;

namespace UniversityManagementAPP.Controllers
{
    public class TeacherController : Controller
    {
        //
        // GET: /Teacher/
        DesignationManager aDesignationManager = new DesignationManager();
        DepartmentManager aDepartmentManager = new DepartmentManager();
        TeacherManager aTeacherManager = new TeacherManager();
        public ActionResult SaveTeacher()
        {
            List<Designation> designations = aDesignationManager.GetAllDesignation();
            ViewBag.Designations = designations.Select(x => new SelectListItem() {Value = x.DesignationId.ToString(), Text = x.Name});
            List<Department> departments = aDepartmentManager.GetAllDepartments();
            ViewBag.Departments = departments.Select(x => new SelectListItem() { Value = x.DepartmentId.ToString(), Text = x.Name });
            return View();
        }
        [HttpPost]
        public ActionResult SaveTeacher(Teacher aTeacher)
        {
            ViewBag.message = aTeacherManager.SaveTeacher(aTeacher);
            List<Designation> designations = aDesignationManager.GetAllDesignation();
            ViewBag.Designations = designations.Select(x => new SelectListItem() { Value = x.DesignationId.ToString(), Text = x.Name });
            List<Department> departments = aDepartmentManager.GetAllDepartments();
            ViewBag.Departments = departments.Select(x => new SelectListItem() { Value = x.DepartmentId.ToString(), Text = x.Name });
            return View();
        }
	}
}