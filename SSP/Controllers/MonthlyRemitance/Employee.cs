using Microsoft.AspNetCore.Mvc;
using SSP.Repository.Infrastructure.RawSql;
using SSP.Repository.Infrastructure;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        public IActionResult Index(string searchData)
        {
            if ((HttpContext.Session.GetString("rin") != null) && (searchData ==null))
            {
                string rin = HttpContext.Session.GetString("rin").ToString();
                var lstTaxPayerAsset = _allRawSql.GetAssociateBusinessbyRin(rin);
                ViewBag.TaxBusiness = new SelectList(lstTaxPayerAsset.Select(t => new { id = t.Id, text = t.AssetName }).Distinct(), "id", "text");
                
                return View();
            }
            else if(searchData != null )
            {

                var rs = _repository.GetById(searchData);
                ViewBag.EmployeesMonthlyIncome = rs;
            }
            return RedirectToAction("Login", "SignIn");
        } 
        
        [HttpGet]
        public JsonResult IndexWithTable(string rin)
        {
            var rs = _repository.GetById(rin);
            return Json(new { data = rs });
        }
    }
}
