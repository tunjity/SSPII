using Microsoft.AspNetCore.Mvc;
using SSP.Infrastructure;

namespace SSP.Controllers
{
    public class BusinessEmployee : Controller
    {
        private IBusinessEmployeeRepository _repository;
        public BusinessEmployee()
        {
            _repository = new BusinessEmployeeRepository();
        }
        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult GetByRIN(string rin)
        {var ret = _repository.GetById(rin);
            return View();
        }
    }
}
