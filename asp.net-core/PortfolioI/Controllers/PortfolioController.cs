using Microsoft.AspNetCore.Mvc;

namespace PortfolioI.Controllers
{
    public class PortfolioController : Controller
    {
        [HttpGet("/")]
        public string index() 
        {
            return "This is my index!";
        }

        [HttpGet("/projects")]
        public string projects() 
        {
            return "These are my projects!";
        }

        [HttpGet("/contact")]
        public string contact()
        {
            return "Contact Me!";
        }
    }
}