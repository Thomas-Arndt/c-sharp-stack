using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace RazorFun.Controllers
{
    public class MainController : Controller
    {
        [HttpGet("")]
        public ViewResult index()
        {
            return View();
        }
    }
}