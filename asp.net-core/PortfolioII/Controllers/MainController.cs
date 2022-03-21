using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace RazorFun.Controllers
{
    public class MainController : Controller
    {
        [HttpGet("/")]
        public IActionResult index() {
            return View();
        }
        [HttpGet("/projects")]
        public IActionResult projects() {
            return View();
        }
        [HttpGet("/contact")]
        public IActionResult contact() {
            return View();
        }
    }
}