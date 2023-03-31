using Microsoft.AspNetCore.Mvc;
using SSP.Infrastructure;

namespace SSP.Controllers
{
    public class CompanyList : Controller
    {

        private ICompanyListApiRepository _repository;
        public CompanyList()
        {
            _repository = new CompanyListApiRepository();
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("rin") != null)
            {
                string rin = HttpContext.Session.GetString("rin").ToString();
                var resp = _repository.GetByRIN(rin);
                return View(resp);
            }
            return View();
        }
    }
}
