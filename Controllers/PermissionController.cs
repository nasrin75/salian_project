using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace salian_project.Controllers
{
    public class PermissionController : Controller
    {
        public ActionResult List()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
}
}
