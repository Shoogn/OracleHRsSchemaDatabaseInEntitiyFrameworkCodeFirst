using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAppForOracle.Models
{
    [Table("JOBS")]
    public class Job
    {
        [Column("JOB_ID")]
        public string JobID { get; set; }
        [Column("JOB_TITLE")]
        public string JobTitle { get; set; }
        [Column("MAX_SALARY")]
        public decimal MaxSalary { get; set; }
        [Column("MIN_SALARY")]
        public decimal MinSalary { get; set; }
        public virtual ICollection<JobHistory> JobHistories { get; set; }
    }
}