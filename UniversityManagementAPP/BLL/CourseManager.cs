using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagementAPP.DAL;
using UniversityManagementAPP.Models;

namespace UniversityManagementAPP.BLL
{
    public class CourseManager
    {
       CourseGateway aGateway = new CourseGateway();
       
         public string Save(Course aCourse)
        {
            bool name = aGateway.IsNameExist(aCourse.Name);
            bool code = aGateway.IsCodeExist(aCourse.Code);

            if (!(name && code))
            {
                int rowEffected = aGateway.Save(aCourse);
                if (rowEffected > 0)
                {
                    return "Save Successfullly ";
                }
                else
                {
                    return "Save failed ";
                }
            }
            else
            {
                if (name)
                {
                    return "Duplicate Name Exist ";
                }
                else 
                {
                    return "Duplicate Code Exist ";
                }
            }
        }
    }
}
