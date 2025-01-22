using Microsoft.AspNetCore.Mvc;

namespace MaterialManagement.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
