using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace Task22
{
    public class EmployeeDataAccess
    {


        public class Employee
        {
            public int EmployeeId { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public string City { get; set; }
        }
        public static List<Employee> GetAllEmployees()
        {
            List<Employee> listEmployees = new List<Employee>();

            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("Select * from tblEmployee", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Employee employee = new Employee();
                    employee.EmployeeId = Convert.ToInt32(rdr["EmployeeId"]);
                    employee.Name = rdr["Name"].ToString();
                    employee.Gender = rdr["Gender"].ToString();
                    employee.City = rdr["City"].ToString();

                    listEmployees.Add(employee);
                }
            }

            return listEmployees;
        }
        public static void UpdateEmployee(int EmployeeId, string Name,
                                            string Gender, string City)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                string updateQuery = "Update tblEmployee SET Name = @Name,  " +
                    "Gender = @Gender, City = @City WHERE EmployeeId = @EmployeeId ";
                SqlCommand cmd = new SqlCommand(updateQuery, con);
                SqlParameter paramEmployeeId = new SqlParameter("@EmployeeId", EmployeeId);
                cmd.Parameters.Add(paramEmployeeId);
                SqlParameter paramName = new SqlParameter("@Name", Name);
                cmd.Parameters.Add(paramName);
                SqlParameter paramGender = new SqlParameter("@Gender", Gender);
                cmd.Parameters.Add(paramGender);
                SqlParameter paramCity = new SqlParameter("@City", City);
                cmd.Parameters.Add(paramCity);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}