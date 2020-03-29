using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAppForOracle.Models
{
    [Table("COUNTRIES")]
    public class Country
    {
        [Key]
        [Column("COUNTRY_ID")]
        public string CountryID { get; set; }
        [Column("COUNTRY_NAME")]
        public string CountryName { get; set; }
        [Column("REGION_ID")]
        public decimal RegionID { get; set; }

        public virtual Region Region { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }
}