using Microsoft.AspNetCore.Mvc;

namespace salian_project.Controllers
{
    public class LogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
