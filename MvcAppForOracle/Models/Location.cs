using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAppForOracle.Models
{
    [Table("LOCATIONS")]
    public class Location
    {
        [Key]
        [Column("LOCATION_ID")]
        public decimal LocationID { get; set; }
        [Column("COUNTRY_ID")]
        public decimal CountryID { get; set; }
        [Column("STRRRT_ADDRESS")]
        public string StreetAddress { get; set; }
        [Column("POSTAL_CODE")]
        public string PostalCode { get; set; }
        [Column("CITY")]
        public string City { get; set; }
        [Column("STATE_PROVINCE")]
        public string StreetProvince { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual Country Country { get; set; }

    }
}