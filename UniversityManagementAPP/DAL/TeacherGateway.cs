using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using UniversityManagementAPP.Models;

namespace UniversityManagementAPP.DAL
{
    public class TeacherGateway : Gateway
    {
        public int SaveTeacher(Teacher aTeacher)
        {
            Query = "INSERT INTO Teacher VALUES(@name,@adress,@email,@contuctNo,@degignationId,@departmentId,@credit)";
            Command.CommandText = Query;
            Command.Parameters.Clear();
            Command.Parameters.Add("name", sqlDbType: SqlDbType.VarChar);
            Command.Parameters["name"].Value = aTeacher.Name;
            Command.Parameters.Add("adress", sqlDbType: SqlDbType.VarChar);
            Command.Parameters["adress"].Value = aTeacher.Adress;
            Command.Parameters.Add("email", sqlDbType: SqlDbType.VarChar);
            Command.Parameters["email"].Value = aTeacher.Email;
            Command.Parameters.Add("contuctNo", sqlDbType: SqlDbType.VarChar);
            Command.Parameters["contuctNo"].Value = aTeacher.ContuctNo;
            Command.Parameters.Add("degignationId", SqlDbType.Int);
            Command.Parameters["degignationId"].Value = aTeacher.DesignationId;
            Command.Parameters.Add("departmentId", SqlDbType.Int);
            Command.Parameters["departmentId"].Value = aTeacher.DepartmentId;
            Command.Parameters.Add("credit", sqlDbType: SqlDbType.Float);
            Command.Parameters["credit"].Value = aTeacher.Credit;


            Connection.Open();
            int isRowEffefted = Command.ExecuteNonQuery();
            Connection.Close();

            return isRowEffefted;
        }
    }
}