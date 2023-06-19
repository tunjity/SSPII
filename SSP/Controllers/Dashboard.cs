using Microsoft.AspNetCore.Mvc;

namespace SSP.Controllers
{
    public class Dashboard : Controller
    {
        public IActionResult Index()
        {
            ViewBag.DisplayDashboard = "1";
            return View();
        } 
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("Login/SignIn");
        }
    }
}
