using Microsoft.AspNetCore.Mvc;

namespace SSP.Controllers.MonthlyRemitance
{
    public class Employee : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
        
        [HttpPost]
        public IActionResult Index(string rin)
        {
            // talk to payeinput table
            return View();
        }
    }
}
