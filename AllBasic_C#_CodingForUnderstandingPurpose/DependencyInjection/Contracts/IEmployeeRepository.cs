using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DependencyInjection.Models;

namespace DependencyInjection.Contracts
{
    public interface IEmployeeRepository
    {

        List<Employee> GetAllEmployee();
    }
}