
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace TimeDisplay.Controllers
{
    public class MainController : Controller
    {
        [HttpGet("/")]
        public IActionResult index() {

            ViewBag.Time = DateTime.Now;
            return View();
        }

    }
}