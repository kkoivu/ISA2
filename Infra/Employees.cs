using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Infra
{
    public static class Employees
    {
        public static List<Employee> Get()
        {
            var employees = new List<Employee>
            {
                new Employee("John", "Doe", 14000),
                new Employee("Michael", "Jackson", 16000),
                new Employee("Robert", "Pattinson", 20000)
            };
            return employees;
        }
    }
}
