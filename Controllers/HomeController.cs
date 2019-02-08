using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCExampleNick.Models;

namespace MVCExampleNick.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Department()
        {
            var vm = new MainViewModel()
            {
                Name = "Hello World",
                Departments = new List<Department>()
                {
                    new Department()
                    {
                        Id = 1,
                        Name = "Dept 1"
                    },
                    new Department()
                    {
                        Id = 2,
                        Name = "Dept 2"
                    }
                }
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult Department(MainViewModel vm)
        {
            

            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
