using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagementAPP.Models;

namespace UniversityManagementAPP.DAL
{
    public class SemesterGateway : Gateway
    {
        public List<Semester> GetAllSemesters()
        {
            Query = "SELECT * FROM Semester";
            Command.CommandText = Query;
            Connection.Open();
            List<Semester> semesters = new List<Semester>();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                Semester aSemester = new Semester
                {
                    SemesterId = Convert.ToInt32(Reader["SemesterId"]),
                    Name = Reader["Name"].ToString()
                };

                semesters.Add(aSemester);
            }
            Reader.Close();
            Connection.Close();

            return semesters;
        }
    }
}