using Microsoft.AspNetCore.Mvc;

namespace SSP.Controllers.MonthlyRemitance
{
    public class Schedule : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
