using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Facade;
using Core;
using Infra;

namespace MVCKodutöö.Controllers
{
    public class TestController : Controller
    {
        public ActionResult GetView()
        {
            var model = new EmployeeListViewModel();
            var employees = Employees.Get();
            var list = new List<EmployeeViewModel>();
            foreach (var e in employees)
            {
                var employee = new EmployeeViewModel(e);
                list.Add(employee);
            }
            model.Employees = list;
            model.UserName = "Admin";
            return View("MyView", model);
        }
    }
}