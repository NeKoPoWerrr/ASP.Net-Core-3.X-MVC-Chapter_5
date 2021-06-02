using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter_5.Controllers
{
    public class ErrorHandlerController : Controller
    {   
        [TempData]
        public string Message { get; set; }
        public IActionResult ErrorMessage()
        {
            if (!TempData.ContainsKey("ErrorMessage"))
            {
                return new EmptyResult();
            }
            TempData.Keep();
            return View();
        }
    }
}
