using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chapter_5.Models;

namespace Chapter_5.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult EmployeeList()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 10001, Name = "David", Phone ="0933", Email = "david.com" },
                new Employee { Id = 10002, Name = "Mary", Phone = "0925", Email = "Mary.com" },
                new Employee { Id = 10003, Name = "John", Phone = "0921", Email = "John.com" },
                new Employee { Id = 10004, Name = "Cindy", Phone = "0971", Email = "Cindy.com" },
                new Employee { Id = 10005, Name = "Rose", Phone = "0933", Email = "Rose.com" },
            };
            return View(employees);
        }
    }
}
