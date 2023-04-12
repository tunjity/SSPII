using Microsoft.AspNetCore.Mvc;

namespace SSP.Controllers.Tax_Clearance_Certificate
{
    public class TccAwaitingApproval : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
