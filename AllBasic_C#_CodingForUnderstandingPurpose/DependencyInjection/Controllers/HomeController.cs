using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DependencyInjection.DataAccess;
using DependencyInjection.Models;
using DependencyInjection.Contracts;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        
        IEmployeeRepository repo;

        public HomeController(IEmployeeRepository r)
        {
            repo = r;
        }

        public ActionResult Index()
        {
            List<Employee> emplist = repo.GetAllEmployee();
            return View(emplist);
        }
	}
}