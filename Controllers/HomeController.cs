using Microsoft.AspNetCore.Mvc;

namespace MorenoCourse.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Sono la index della Home");
        }
    }
}