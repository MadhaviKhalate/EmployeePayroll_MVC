using System;

namespace EmployeePayrollMVC.Models
{
    public class AddEmployeeModel
    {
        public int EmployeeId { get; set; }

        public string EmpName { get; set; }


        public string Profile { get; set; }

        public string Gender { get; set; }

        public string Dept { get; set; }

        public string Salary { get; set; }

        public DateTime StartDate { get; set; }
    }
}
