using MvcAppForOracle.Models;
using MvcAppForOracle.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAppForOracle.Abstract
{
    public interface IEmployee
    {
        //------- Get All Title of Job Code --------
        IQueryable<Job> FindAll { get; }


        IEnumerable<EmployeeVM> FindAllEmployeesByJobId(string id);
    }
}