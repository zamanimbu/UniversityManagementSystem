using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagementAPP.Models;

namespace UniversityManagementAPP.DAL
{
    public class DesignationGateway : Gateway
    {
        public List<Designation> GetAllDesignation()
        {
            Query = "SELECT * FROM Designation";
            Command.CommandText = Query;
            Connection.Open();
          List<Designation> designations = new List<Designation>();
          Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                Designation aDesignation = new Designation
                {
                    DesignationId = Convert.ToInt32(Reader["DesignationId"]),
                    Name = Reader["Name"].ToString()
                };
            designations.Add(aDesignation);
            }
            Reader.Close();
            Connection.Close();

            return designations;
        }
    }
}