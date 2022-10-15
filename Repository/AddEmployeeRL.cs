using EmployeePayrollMVC.Models;
using System;
using System.Data.SqlClient;

namespace EmployeePayrollMVC.Repository
{
    public class AddEmployeeRL
    {
        public static string dbpath = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EmployeePayrollMVC;Integrated Security=True";

        SqlConnection sqlConnection;

        public AddEmployeeModel AddEmployee(AddEmployeeModel employee)
        {
            try
            {

                SqlCommand command = new SqlCommand("AddEmployeeSP ", sqlConnection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                sqlConnection.Open();

                command.Parameters.AddWithValue("@EmpName", employee.EmpName);
                command.Parameters.AddWithValue("@Profile", employee.Profile);
                command.Parameters.AddWithValue("@Gender", employee.Gender);
                command.Parameters.AddWithValue("@Dept", employee.Dept);
                command.Parameters.AddWithValue("@Salary", employee.Salary);
                command.Parameters.AddWithValue("@StartDate", employee.StartDate);

                command.ExecuteNonQuery();
                return employee;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public AddEmployeeModel UpdateEmployee(AddEmployeeModel employee, int EmployeeId)
        {

            try
            {

                SqlCommand command = new SqlCommand("UpdateEmployeeSP", sqlConnection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                sqlConnection.Open();
                command.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                command.Parameters.AddWithValue("@EmpName", employee.EmpName);
                command.Parameters.AddWithValue("@Profile", employee.Profile);
                command.Parameters.AddWithValue("@Gender", employee.Gender);
                command.Parameters.AddWithValue("@Dept", employee.Dept);
                command.Parameters.AddWithValue("@Salary", employee.Salary);
                command.Parameters.AddWithValue("@StartDate", employee.StartDate);
                var result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    return employee;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

        }

        public string DeleteEmployee(AddEmployeeModel employee)
        {
            try
            {

                SqlCommand command = new SqlCommand("DeleteEmployeeSP ", sqlConnection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                sqlConnection.Open();

                command.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);

                command.ExecuteNonQuery();
                var result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    return "Employee deleted";
                }
                else
                {
                    return "Failed to delete Employee";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }

        }

    }

}

