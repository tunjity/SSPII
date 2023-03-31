using Microsoft.AspNetCore.Mvc;
using SSP.Infrastructure;

namespace SSP.Controllers
{
    public class AssociatedBusiness : Controller
    {
        private IAssetTaxPayerDetailsApiRepository _repository;
        public AssociatedBusiness()
        {
            _repository = new AssetTaxPayerDetailsApiRepository();
        }
        public IActionResult Index()
        {
            var resp = _repository.GetAll();
            return View(resp);
        }
    }
}
