using Microsoft.AspNetCore.Mvc;
using SSP.Infrastructure.RawSql;
using SSP.Infrastructure;
using SSP.PayeModelII;

namespace SSP.Controllers.MonthlyRemitance
{
    public class Employee : Controller
    {
        private IEmployeesMonthlyIncomeRepository _repository;
        private IAllRawSql _allRawSql;
        public Employee()
        {
            _repository = new EmployeesMonthlyIncomeRepository();
            _allRawSql = new AllRawSql();
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("rin") != null)
            {
                string rin = HttpContext.Session.GetString("id").ToString();
                List<EmployeesMonthlyIncome> resp = new List<EmployeesMonthlyIncome>();
                resp = _repository.GetById(rin).ToList();
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


        public IActionResult Upload() =>
            View();
        [HttpPost]
        public IActionResult PostUpload()
        {
            // talk to payeinput table
            return View();
        }
    }
}
