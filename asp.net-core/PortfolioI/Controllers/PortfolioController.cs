using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace PortfolioI.Controllers
{
    public class PortfolioController : Controller
    {
        [HttpGet("/")]
        public ViewResult index() 
        {
            return View();
        }

        [HttpGet("projects")]
        public ViewResult projects() 
        {
            return View();
        }

        [HttpGet("contact")]
        public ViewResult contact()
        {
            return View("Contact");
        }
    }
}