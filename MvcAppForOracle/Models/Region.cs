using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MvcAppForOracle.Models
{
    [Table("REGIONS")]
    public class Region
    {
        [Key]
        [Column("REGION_ID")]
        public decimal RegionID { get; set; }
        [Column("REGION_NAME")]
        public string RegionName { get; set; }

        public ICollection<Country> Countries { get; set; }
    }
}