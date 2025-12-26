using Microsoft.AspNetCore.Mvc;

namespace salian_project.Controllers
{
    public class UserController : Controller
    {
        public IActionResult List()
        {
            return View() ;
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            var user = new User();
            return View(user);
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (!ModelState.IsValid)
            {
              ViewBag.error = "اطلاعات وارد شده صحیح نمی باشد.";
              return View(user);
            } 

            ViewBag.success = "کاربر با موفقیت افزوده شد. ";
            return View(user);
        }
    }
}
