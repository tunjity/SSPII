using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSP.Repository;
using SSP.Repository.Infrastructure;

namespace SSP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilityController : ControllerBase
    {
        private IAssetTaxPayerDetailsApiRepository _atdrepository;
        private IAgencyTypeRepository _atrepository;
        private IAssetTypeRepository _atyperepository;
        private IBusinessTypeRepository _btyperepository;
        private IExceptionTypeRepository _etyperepository;
        private INotificationTypeRepository _ntyperepository;
        private ISalaryTypeMasterRepository _stmrepository;
        private ITaxPayerTypeRepository _tptrepository;
        public UtilityController(IAssetTaxPayerDetailsApiRepository atdrepository, IAgencyTypeRepository atrepository, IAssetTypeRepository atyperepository, IBusinessTypeRepository btyperepository, IExceptionTypeRepository etyperepository, INotificationTypeRepository ntyperepository, ISalaryTypeMasterRepository stmrepository, ITaxPayerTypeRepository tptrepository)
        {
            _atdrepository = atdrepository;
            _atrepository = atrepository;
            _atyperepository = atyperepository;
            _btyperepository = btyperepository;
            _etyperepository = etyperepository;
            _ntyperepository = ntyperepository;
            _stmrepository = stmrepository;
            _tptrepository = tptrepository;
        }

        [HttpGet("get-all-agencytype")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(ReturnObject), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        public async Task<ActionResult> GetAllAgencyType()
        {
            var resp = new ReturnObject();
            var ret = _atrepository.GetAll();
            if (ret.Count() < 0)
            {
                resp.status = false;
                resp.message = "An Error Occur";
                return Ok(resp);
            }
            resp.data = ret;
            resp.status = true;
            resp.message = "Record Gotten Successfully";
            return Ok(resp);
        }
        [HttpGet("get-all-assettype")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(ReturnObject), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        public async Task<ActionResult> GetAllAssettype()
        {
            var resp = new ReturnObject();
            var ret = _atyperepository.GetAll();
            if (ret.Count() < 0)
            {
                resp.status = false;
                resp.message = "An Error Occur";
                return Ok(resp);
            }
            
            
            resp.data = ret;
            resp.status = true;
            resp.message = "Record Gotten Successfully";
            return Ok(resp);
        }
        [HttpGet("get-all-businesstype")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(ReturnObject), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        public async Task<ActionResult> GetAllBusinesstype()
        {
            var resp = new ReturnObject();
            var ret = _btyperepository.GetAll();
            if (ret.Count() < 0)
            {
                resp.status = false;
                resp.message = "An Error Occur";
                return Ok(resp);
            }
            
            
            resp.data = ret;
            resp.status = true;
            resp.message = "Record Gotten Successfully";
            return Ok(resp);
        }
        [HttpGet("get-all-exceptiontype")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(ReturnObject), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        public async Task<ActionResult> GetAllExceptiontype()
        {
            var resp = new ReturnObject();
            var ret = _etyperepository.GetAll();
            if (ret.Count() < 0)
            {
                resp.status = false;
                resp.message = "An Error Occur";
                return Ok(resp);
            }
            resp.data = ret;
            resp.status = true;
            resp.message = "Record Gotten Successfully";
            return Ok(resp);
        }
        [HttpGet("get-all-notificationtype")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(ReturnObject), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        public async Task<ActionResult> GetAllNotificationtype()
        {
            var resp = new ReturnObject();
            var ret = _ntyperepository.GetAll();
            if (ret.Count() < 0)
            {
                resp.status = false;
                resp.message = "An Error Occur";
                return Ok(resp);
            }
            resp.data = ret;
            resp.status = true;
            resp.message = "Record Gotten Successfully";
            return Ok(resp);
        }
        [HttpGet("get-all-salarytypemaster")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(ReturnObject), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        public async Task<ActionResult> GetAllSalarytypemaster()
        {
            var resp = new ReturnObject();
            var ret = _stmrepository.GetAll();
            if (ret.Count() < 0)
            {
                resp.status = false;
                resp.message = "An Error Occur";
                return Ok(resp);
            }
            resp.data = ret;
            resp.status = true;
            resp.message = "Record Gotten Successfully";
            return Ok(resp);
        }
        [HttpGet("get-all-taxpayertype")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(ReturnObject), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        public async Task<ActionResult> GetAllTaxpertype()
        {
            var resp = new ReturnObject();
            var ret = _tptrepository.GetAll();
            if (ret.Count() < 0)
            {
                resp.status = false;
                resp.message = "An Error Occur";
                return Ok(resp);
            }
            resp.data = ret;
            resp.status = true;
            resp.message = "Record Gotten Successfully";
            return Ok(resp);
        }
       
    }
}
