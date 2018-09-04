using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagementAPP.DAL;
using UniversityManagementAPP.Models;

namespace UniversityManagementAPP.BLL
{
    public class SemesterManager
    {
       SemesterGateway aSemesterGateway = new SemesterGateway();
        public List<Semester> GetAllSemesters()
        {
            return aSemesterGateway.GetAllSemesters();
        }
    }
}