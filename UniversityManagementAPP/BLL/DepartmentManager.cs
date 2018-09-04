using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementAPP.DAL;
using UniversityManagementAPP.Models;

namespace UniversityManagementAPP.BLL
{
    public class DepartmentManager
    {
        DepartmentGateway aGateway = new DepartmentGateway();
        public string Save(Department aDepartment)
        {
            if (!aGateway.IsDeptExist(aDepartment.Name))
            {
                int rowEffected = aGateway.Save(aDepartment);
                if (rowEffected > 0)
                {
                    return "Save Successfully";
                }
                else
                {
                    return "Save Failed";
                }
            }
            else
            {
                return "Department Exist ";
            }
        }

        public List<Department> GetAllDepartments()
        {
            return aGateway.GetAllDepartments();
        }

        
    }
}