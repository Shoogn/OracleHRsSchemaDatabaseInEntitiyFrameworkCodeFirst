using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcAppForOracle.Models
{
    public class HRDbContext : DbContext
    {
        public HRDbContext(): base("name=HRConnectionStrings") 
        { 
        
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobHistory> JobHistories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Country> Countries { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobHistory>().HasKey(k => k.EmployeeID);
            modelBuilder.HasDefaultSchema("HR");
            base.OnModelCreating(modelBuilder);
        }
    }
}