using Microsoft.AspNetCore.Mvc;

namespace Bank.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
