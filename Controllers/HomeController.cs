using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MediaMatters.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Albums()
        {
            return View();
        }
        public IActionResult Books()
        {
            return View();
        }
        public IActionResult Games()
        {
            return View();
        }
    }
}
