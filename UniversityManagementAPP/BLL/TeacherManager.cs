using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagementAPP.DAL;
using UniversityManagementAPP.Models;

namespace UniversityManagementAPP.BLL
{
    public class TeacherManager
    {
        TeacherGateway aGateway = new TeacherGateway();
        public string SaveTeacher(Teacher aTeacher)
        {
            int rowEffected = aGateway.SaveTeacher(aTeacher);
            if (rowEffected > 0)
            {
                return "Save Successfully";
            }
            else
            {
                return "Save Failed";
            }
        }
    }
}