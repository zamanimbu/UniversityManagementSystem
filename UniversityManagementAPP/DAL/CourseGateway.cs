using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using UniversityManagementAPP.Models;

namespace UniversityManagementAPP.DAL
{
    public class CourseGateway : Gateway
    {
        public bool IsNameExist(string name)
        {
            Query = "SELECT * FROM Course WHERE Name = '" + name + "' ";
            Command.CommandText = Query;

            Connection.Open();

            Reader = Command.ExecuteReader();

            bool isExist = Reader.HasRows;

            Reader.Close();
            Connection.Close();
            return isExist;
        }

        public bool IsCodeExist(string code)
        {
            Query = "SELECT * FROM Course WHERE Name = '" + code + "' ";
            Command.CommandText = Query;

            Connection.Open();

            Reader = Command.ExecuteReader();

            bool isExist = Reader.HasRows;

            Reader.Close();
            Connection.Close();
            return isExist;
        }

        public int Save(Course aCourse)
        {
            Query = "INSERT INTO Course VALUES(@code,@name,@credit,@description,@departmenId,@semesterId)";
            Command.CommandText = Query;
            Command.Parameters.Clear();
            Command.Parameters.Add("code", sqlDbType: SqlDbType.VarChar);
            Command.Parameters["code"].Value = aCourse.Code;
            Command.Parameters.Add("name", sqlDbType: SqlDbType.VarChar);
            Command.Parameters["name"].Value = aCourse.Name;
            Command.Parameters.Add("credit", sqlDbType: SqlDbType.Float);
            Command.Parameters["credit"].Value = aCourse.Credit;
            Command.Parameters.Add("description", sqlDbType: SqlDbType.VarChar);
            Command.Parameters["description"].Value = aCourse.Description;
            Command.Parameters.Add("departmenId", SqlDbType.Int);
            Command.Parameters["departmenId"].Value = aCourse.DepartmentId;
            Command.Parameters.Add("semesterId", SqlDbType.Int);
            Command.Parameters["semesterId"].Value = aCourse.SemesterId;


            Connection.Open();
            int isRowEffefted = Command.ExecuteNonQuery();
            Connection.Close();

            return isRowEffefted;
        }
    }
}