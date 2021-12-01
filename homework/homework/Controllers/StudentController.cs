using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index(int? id)
        {
            if(id== null)
            {
                ViewData["Salam qaqas"] = "Id is null";
                return View("NewList");
            }
            return Json(new { Name = "Ayxan", Surname = "Abdullayev", Age = 21 });
        }
    }
}
