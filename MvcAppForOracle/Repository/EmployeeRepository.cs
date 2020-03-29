using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcAppForOracle.Abstract;
using MvcAppForOracle.ViewModels;

using MvcAppForOracle.Models;
namespace MvcAppForOracle.Repository
{
    public class EmployeeRepository : IEmployee
    {
        private HRDbContext _context = new HRDbContext();

        public IQueryable<Job> FindAll
        {
            get { return _context.Jobs; }
        }

        public IEnumerable<EmployeeVM> FindAllEmployeesByJobId(string id)
        {
            var query = (from e in _context.Employees
                         where e.JobID == id
                         join j in _context.Jobs on e.JobID equals j.JobID
                         join d in _context.Departments on e.DepartmentID equals d.DepartmentID
                         join m in _context.Employees on e.EmployeeID equals m.ManagerID
                         select new EmployeeVM
                         {
                             CommissionPCT = e.CommissionPCT,
                             Email = e.Email,
                             DepartmentName = d.DepartmentName,
                             EmployeeID = e.EmployeeID,
                             FisrtName = e.FirstName,
                             HireDate = e.HireDate,
                             JobID = e.JobID,
                             LastName = e.LastName,
                             ManageName = e.FirstName,
                             PhoneNumber = e.PhonNumber,
                             Salary = e.Salary,
                             JobTitle = j.JobTitle
                         }).ToList();
            return query;
        }
    }
}