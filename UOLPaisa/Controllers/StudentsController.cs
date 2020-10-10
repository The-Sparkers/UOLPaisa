using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UOLPaisa.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public StudentsController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult AddStudent()
        {
            ViewBag.PageName = "Add Student";
            return View();
        }
        public IActionResult RemoveStudent()
        {
            ViewBag.PageName = "Remove Student";
            return View();
        }
    }
}
