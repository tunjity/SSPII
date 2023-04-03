using Microsoft.AspNetCore.Mvc;
using SSP.Infrastructure;
using SSP.Infrastructure.RawSql;

namespace SSP.Controllers.MonthlyRemitance
{
    public class Employee : Controller
    {
        private IBusinessEmployeeRepository _repository;
        private IAllRawSql _allRawSql;

        public Employee()
        {
            _repository = new BusinessEmployeeRepository();
            _allRawSql = new AllRawSql();
        }
        public IActionResult Index() => View();

        public IActionResult GetbyName(int id)
        {
            var nameid = Convert.ToString(id);
            var ret = _allRawSql.GetByEmployeeName(nameid);
            return View(nameid);
        }
    }
}
