using Microsoft.AspNetCore.Mvc;
using SSP.Repository.Infrastructure;
using SSP.Repository.Infrastructure.RawSql;

namespace SSP.Controllers
{
    public class AssociatedBusiness : Controller
    {
        private IAssetTaxPayerDetailsApiRepository _repository;
        private IAllRawSql _allRawSql;
        public AssociatedBusiness()
        {
            _repository = new AssetTaxPayerDetailsApiRepository();
            _allRawSql = new AllRawSql();
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("rin") != null)
            {
                string rin = HttpContext.Session.GetString("rin").ToString();
                var resp = _allRawSql.GetAssociateBusinessbyRin(rin);
                return View(resp);
            }
            return View();
        } 
        public IActionResult Add()
        {
            return View();
        }
    }
}
