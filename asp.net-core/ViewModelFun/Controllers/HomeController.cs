using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("message")]
        public IActionResult Message() 
        {
            string message = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Ducimus, natus. Numquam ipsa impedit pariatur at tenetur, vel suscipit eligendi soluta accusantium beatae corrupti incidunt, ratione officia eius vitae sit totam sint nisi adipisci, doloremque quam optio ad quos. Quo quam, dolorem doloremque, placeat, ratione consequatur fugit voluptatum distinctio odio odit culpa provident. Asperiores repellendus illum accusamus id possimus. Nesciunt tenetur ratione sit impedit adipisci veniam officiis iure ut, velit vero natus, nulla id doloribus repellat accusantium aspernatur alias. Quam, sunt?";
            return View("Message", message);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[] {1,2,3,10,43,5};
            return View("Numbers", numbers);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            string[] users = new string[] {
                "Moose Phillips",
                "Sarah",
                "Jerry",
                "Rene Ricky",
                "Barbarah"
            };
            return View("Users", users);
        }

        [HttpGet("user")]
        public IActionResult OneUser()
        {
            User user = new User()
            {
                FirstName = "Moose",
                LastName = "Phillips"
            };
            return View("User", user);
        }

        [HttpGet("privacy")]
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
