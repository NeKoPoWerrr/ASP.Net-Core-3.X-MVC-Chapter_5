using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter_5.Controllers
{
    public class PassDataController : Controller
    {
        public IActionResult PetShop()
        {
            ViewData["Company"] = "汪星人寵物店"; //ViewData
            ViewBag.Address = "台北市信義區"; //ViewBag
            List<string> petList = new List<string>(); //List model
            petList.Add("狗");
            petList.Add("貓");
            petList.Add("魚");
            petList.Add("鼠");
            petList.Add("變色龍");
            ViewData.Model = petList;
            return View();
        }

        public IActionResult PassTempData()
        {
            TempData["ErrorMessage"] = "無足夠權限";
            TempData["UserName"] = "David";
            TempData["Time"] = DateTime.Now.ToLongTimeString();
            return RedirectToAction("ErrorMessage", "ErrorHandler");
        }
        public IActionResult PassViewData()
        {
            ViewData["Name"] = "Kenvin";
            ViewData["Age"] = 33;
            ViewData["Single"] = true;
            //ViewData["Emplyees"] = empsList;
            return View();
        }
    }
}
