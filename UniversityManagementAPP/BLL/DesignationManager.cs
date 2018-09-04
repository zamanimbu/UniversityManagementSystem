using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagementAPP.DAL;
using UniversityManagementAPP.Models;

namespace UniversityManagementAPP.BLL
{
    public class DesignationManager
    {
        DesignationGateway aDesignationGateway = new DesignationGateway();
        public List<Designation> GetAllDesignation()
        {
            return aDesignationGateway.GetAllDesignation();
        }
    }
}