using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAppForOracle.Models
{
    [Table("EMPLOYEES")]
    public class Employee
    {
        [Key]
        [Column("EMPLOYEE_ID")]
        public decimal EmployeeID { get; set; }
        [Column("JOB_ID")]
        public string JobID { get; set; }
        [Column("DEPARTMENT_ID")]
        public decimal DepartmentID { get; set; }
        [Column("MANAGER_ID")]
        [ForeignKey("Employees")]
        public decimal ManagerID { get; set; }
        [Column("FIRST_NAME")]
        public string FirstName { get; set; }
        [Column("LAST_NAME")]
        public string LastName { get; set; }
        [Column("EMAIL")]
        public  string Email { get; set; }
        [Column("PHONE_NUMBER")]
        public string PhonNumber { get; set; }
        [Column("HIRE_DATE")]
        public DateTime HireDate { get; set; }
        [Column("SALARY")]
        public decimal Salary { get; set; }
        [Column("COMMISSION_PCT")]
        public decimal CommissionPCT { get; set; }


        // Relationship
        public virtual Job Job { get; set; }
        public virtual Employee Employees { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<JobHistory> JobHistories { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}