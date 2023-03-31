using Microsoft.AspNetCore.Mvc;

namespace SSP.Controllers
{
    public class Dashboard : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("Login/SignIn");
        }
    }
}
