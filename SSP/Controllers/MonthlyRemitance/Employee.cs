using Microsoft.AspNetCore.Mvc;
using SSP.Infrastructure.RawSql;
using SSP.Infrastructure;

namespace SSP.Controllers.MonthlyRemitance
{
    public class Employee : Controller
    {
        private IPayeInputFileRepository _repository;
        private IAllRawSql _allRawSql;
        public Employee()
        {
            _repository = new PayeInputFileRepository();
            _allRawSql = new AllRawSql();
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("rin") != null)
            {
                string rin = HttpContext.Session.GetString("rin").ToString();
                var resp = _allRawSql.GetPayeInputFilebyRin(rin);
                return View(resp);
            }
            return RedirectToAction("Login", "SignIn");
        } 
        
        [HttpPost]
        public IActionResult Index(string rin)
        {
            // talk to payeinput table
            return View();
        }
    }
}
