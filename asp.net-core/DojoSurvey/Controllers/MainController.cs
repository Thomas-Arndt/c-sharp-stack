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

        [HttpPost("formSubmit")]
        public IActionResult processForm(string name, string location, string language, string comment) {
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.comment = comment;
            return View("ResultView");
        }
    }
}