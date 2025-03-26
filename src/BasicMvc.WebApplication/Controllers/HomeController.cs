using Microsoft.AspNetCore.Mvc;

namespace BasicMvc.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
