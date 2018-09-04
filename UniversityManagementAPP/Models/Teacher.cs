using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementAPP.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string ContuctNo { get; set; }
        public int DesignationId { get; set; }
        public int DepartmentId { get; set; }
        public double Credit { get; set; }

    }
}