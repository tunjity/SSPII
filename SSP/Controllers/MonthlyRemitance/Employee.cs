using Microsoft.AspNetCore.Mvc;

namespace SSP.Controllers.MonthlyRemitance
{
    public class Employee : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Index(string EmployeesResp)
        {

            return View();
        }
    }
}
