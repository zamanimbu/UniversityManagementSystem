using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementAPP.Models;

namespace UniversityManagementAPP.DAL
{
    public class DepartmentGateway : Gateway
    {
        public bool IsDeptExist(string name)
        {
            Query = "SELECT * FROM Department WHERE Name = '" + name + "' ";
            Command.CommandText = Query;

            Connection.Open();

            Reader = Command.ExecuteReader();

            bool isExist = Reader.HasRows;

            Reader.Close();
            Connection.Close();
            return isExist;
        }
        public int Save(Department aDepartment)
        {
            Query = "INSERT INTO Department VALUES(@Code,@Name)";
            Command.CommandText = Query;
            Command.Parameters.Clear();
            Command.Parameters.Add("Code", SqlDbType.VarChar);
            Command.Parameters["Code"].Value = aDepartment.Code;
            Command.Parameters.Add("Name", SqlDbType.VarChar);
            Command.Parameters["Name"].Value = aDepartment.Name;
            Connection.Open();
            int rowEffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowEffected;
        }

        public List<Department> GetAllDepartments()
        {
            Query = "SELECT * FROM Department";
            Command.CommandText = Query;
            Connection.Open();
            List<Department> departments = new List<Department>();

            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                Department aDepartment = new Department
                {
                    DepartmentId = Convert.ToInt32(Reader["DepartmentId"]),
                    Code = Reader["Code"].ToString(),
                    Name = Reader["Name"].ToString()
                };

                departments.Add(aDepartment);
            }
            Reader.Close();
            Connection.Close();

            return departments;
        }

       
    }
}