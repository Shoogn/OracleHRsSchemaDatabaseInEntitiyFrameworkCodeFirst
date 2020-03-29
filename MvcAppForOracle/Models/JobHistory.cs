using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAppForOracle.Models
{
    [Table("JOB_HISTORY")]
    public class JobHistory
    {
        [Key]
        [Column("EMPLOUEE_ID")]
        public decimal EmployeeID { get; set; }
        [Column("JOB_ID")]
        public decimal JobID { get; set; }
        [Column("DEPARTMENT_ID")]
        public decimal DepartmentID { get; set; }
        [Key]
        [Column("START_DATE")]
        public DateTime StartDate { get; set; }
        [Column("END_DATE")]
        public DateTime EndDate { get; set; }

        public virtual Employee Employee { get; set; }  
        public virtual Job Job { get; set; }

    }
}