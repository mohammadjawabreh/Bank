using Microsoft.AspNetCore.Mvc;

namespace Bank.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
