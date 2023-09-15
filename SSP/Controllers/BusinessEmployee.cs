using Microsoft.AspNetCore.Mvc;
using SSP.Repository.Infrastructure;
using SSP.Repository.Infrastructure.RawSql;

namespace SSP.Controllers
{
    public class BusinessEmployee : Controller
    {
        private IBusinessEmployeeRepository _repository;
        private IAllRawSql _allRawSql;
        public BusinessEmployee()
        {
            _repository = new BusinessEmployeeRepository();
            _allRawSql = new AllRawSql();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetByRIN(string rin)
        {
            var ret = _allRawSql.GetBusinessEmployeebyRin(rin);
            return View(ret);
        }
    }
}
