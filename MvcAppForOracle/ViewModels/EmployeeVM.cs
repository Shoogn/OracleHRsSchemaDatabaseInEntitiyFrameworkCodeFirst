using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAppForOracle.ViewModels
{
    public class EmployeeVM
    {
        public decimal EmployeeID { get; set; }
        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string JobID { get; set; }
        public string JobTitle { get; set; }
        public decimal Salary { get; set; }
        public decimal CommissionPCT { get; set; }
        public string DepartmentName { get; set; }
        public DateTime HireDate { get; set; }
        public string ManageName { get; set; }
    }
}