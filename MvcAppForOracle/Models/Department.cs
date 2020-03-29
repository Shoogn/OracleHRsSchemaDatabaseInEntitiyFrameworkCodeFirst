using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAppForOracle.Models
{
    [Table("DEPARTMENTS")]
    public class Department
    {
        [Key]
        [Column("DEPARTMENT_ID")]
        public decimal DepartmentID { get; set; }
        [Column("LOCATION_ID")]
        public decimal LocationID { get; set; }
        [Column("MANAGER_ID")]
        public decimal EmployeeID { get; set; }
        [Column("DEPARTMENT_NAME")]
        public string DepartmentName { get; set; }

        public virtual Location Location { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<JobHistory> JobHistories { get; set; }

    }
}