using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementAPP.BLL;
using UniversityManagementAPP.Models;

namespace UniversityManagementAPP.Controllers
{
    public class CourseController : Controller
    {
        //
        // GET: /Course/
        CourseManager aCourseManager = new CourseManager();
        DepartmentManager aDepartmentManager = new DepartmentManager();
        SemesterManager aSemesterManager = new SemesterManager();
        public ActionResult SaveCourse()
        {
            List<Department> Departments = aDepartmentManager.GetAllDepartments();
            List<Semester> semesters = aSemesterManager.GetAllSemesters();
            ViewBag.Departments = Departments.Select(x => new SelectListItem() {Value = x.DepartmentId.ToString(), Text = x.Name});
            ViewBag.Semester = semesters.Select(x => new SelectListItem() {Value = x.SemesterId.ToString(), Text = x.Name});
            return View();
        }
     
        [HttpPost]
        public ActionResult SaveCourse(Course aCourse)
        {
            ViewBag.message = aCourseManager.Save(aCourse);
            List<Department> Departments = aDepartmentManager.GetAllDepartments();
            List<Semester> semesters = aSemesterManager.GetAllSemesters();
            ViewBag.Departments = Departments.Select(x => new SelectListItem() { Value = x.DepartmentId.ToString(), Text = x.Name });
            ViewBag.Semester = ViewBag.Semester = semesters.Select(x => new SelectListItem() { Value = x.SemesterId.ToString(), Text = x.Name }); ;
            return View();
        }
	}
}