using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcAppForOracle.ViewModels;
using MvcAppForOracle.Abstract;
using MvcAppForOracle.Models;

namespace MvcAppForOracle.Controllers
{
    public class HRManagementController : Controller
    {
        private IEmployee _employee;
        public HRManagementController(IEmployee employee)
        {
            _employee = employee;
        }
        // GET: HRManagement
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowAllJobs()
        {
            var rep = _employee.FindAll;
            return View(rep);
        }
    }
}