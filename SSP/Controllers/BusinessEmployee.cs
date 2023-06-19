using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SSP.Infrastructure;
using SSP.Infrastructure.RawSql;
using SSP.PayeModelII;

namespace SSP.Controllers
{
    public class BusinessEmployee : Controller
    {
        private IBusinessEmployeeRepository _repository;
        private readonly IMapper _mapper;
        private IAllRawSql _allRawSql;
        public BusinessEmployee(
            IMapper mapper)
        {
            _mapper = mapper;
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
            List<BusinessEmployeeViewModel> businessEmployeeViewModels = _mapper.Map<List<BusinessEmployeeViewModel>>(ret);
            return View(businessEmployeeViewModels);
        }
    }
}
