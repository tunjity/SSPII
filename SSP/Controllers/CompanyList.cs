using Microsoft.AspNetCore.Mvc;
using SSP.Infrastructure;
using SSP.Infrastructure.RawSql;

namespace SSP.Controllers
{
    public class CompanyList : Controller
    {
       private ICompanyListApiRepository _repository;
       private IAllRawSql _allRawSql;
        public CompanyList()
        {
            _repository = new CompanyListApiRepository();
            _allRawSql = new AllRawSql();
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("rin") != null)
            {
                string rin = HttpContext.Session.GetString("rin").ToString();
                var resp = _allRawSql.GetCompanyListApibyRin(rin);
                return View(resp);
            }
            return View();
        }
    }
}
