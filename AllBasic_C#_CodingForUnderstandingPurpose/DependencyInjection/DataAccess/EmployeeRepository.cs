using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DependencyInjection.Models;
using DependencyInjection.Contracts;

namespace DependencyInjection.DataAccess
{
    public class EmployeeRepository:IEmployeeRepository
    {
        public List<Employee> GetAllEmployee()
        {
            return new List<Employee>()
        {
        new Employee(){Name="Anish",Age=25,Salary= 50000,Localtion= "India"},
        new Employee(){Name="kumar",Age=26,Salary=50000,Localtion="Nepal"},
        new Employee(){Name="Singh",Age=27,Salary=50000,Localtion="SriLanka"}
        };
        }
    }
}