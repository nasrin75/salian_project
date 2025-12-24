using Microsoft.AspNetCore.Mvc;

namespace salian_project.Controllers
{
    public class UserController : Controller
    {
        public IActionResult List()
        {
            return View() ;
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
