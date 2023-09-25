using BCrypt.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SSP.Repository;
using SSP.Repository.EIRSModel;
using SSP.Repository.Infrastructure;
using SSP.Repository.Models.CreationModel;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace SSP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class LoginController : ControllerBase
    {
        private EirsContext _db;
        private readonly IConfiguration config;
        public LoginController(IConfiguration config, EirsContext db)
        {
            this.config = config;
            _db = db;
        }
        [HttpPost("SignIn")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(ReturnObject), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        public ActionResult SignIn(SignIn model)
        {
            var resp = new ReturnObject();
            Company eirsUser = new();
            var ret = _db.Companies.SingleOrDefault(o => (o.CompanyRin == model.PhoneNumber_RIN.ToString().Trim()) || (o.MobileNumber1 == model.PhoneNumber_RIN.ToString().Trim()));
            if (ret != null)
            {
                if (BCrypt.Net.BCrypt.Verify(model.Password, ret.Password))
                {
                    TokenManager tokenManager = new();
                    var token = tokenManager.GetToken(model.PhoneNumber_RIN, ret.CompanyId, config);
                    return Ok(new { token = token, expiryAt = DateTime.UtcNow.AddDays(1) });
                }
            }
            return Ok("Invalid Login Detail");
        }

        [HttpPost("CreateAccount")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(ReturnObject), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        public ActionResult CreateAccount(CompanyStepOne model)
        {
            var resp = new ReturnObject();
            Company company = new()
            {
                TaxPayerTypeId = 2,
                MobileNumber1 = model.MobileNumber1,
                ContactAddress = model.ContactAddress,
                CompanyName = model.CompanyName,
                TaxOfficeId = 1,
                NotificationMethodId = 1,
                EconomicActivitiesId = 1
            };
            //send sms region
            string? SmsBaseUrl = config.GetConnectionString("SmsBaseUrl");
            string? username = config.GetConnectionString("username");
            string? password = config.GetConnectionString("password");
            //check if it exist
            var checker = _db.Companies.FirstOrDefault(o => (o.CompanyName == company.CompanyName && o.MobileNumber1 == company.MobileNumber1) || (o.CompanyName == company.CompanyName && o.ContactAddress == company.ContactAddress));
            if (checker != null)
            {
                resp.status = false;
                resp.message = "Company Already Exist";
                return Ok(resp);
            }
            Random r = new Random();
            var x = r.Next(0, 1000000);
            string s = x.ToString("000000");
            company.VerificationOtp = Convert.ToInt32(s);
            StringBuilder sbSMSContent = new StringBuilder();
            sbSMSContent.Append("Use "); sbSMSContent.Append(s); sbSMSContent.Append(" as your Login OTP To Edo State Self Service Portal, This expiry at the close of this page");
            bool ret = SendSMS(model.MobileNumber1, sbSMSContent.ToString(), username, password, SmsBaseUrl);
            if (ret)
            {
                _db.Companies.Add(company);
                _db.SaveChanges();

                resp.status = true;
                resp.message = "Company Saved Successfully";
                resp.data = $"The OTP is {s} and CompanyID is {company.CompanyId}";
                return Ok(resp);
            }
            resp.status = false;
            resp.message = "Unable to send OTP at the moment";
            return Ok(resp);
        }  
        [HttpPost("ForgetPassword")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(ReturnObject), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
     
        public ActionResult ForgetPassword(ForgetPassword model)
        {
            var resp = new ReturnObject();
            var ret = _db.Companies.FirstOrDefault(o => o.CompanyId == model.CompanyId);;
            if (ret == null)
            {
                resp.status = false;
                resp.message = "Company Doesnt Exist";
                return Ok(resp);
            }
            _db.Companies.Where(o => o.CompanyId == model.CompanyId).ExecuteUpdate(setters => setters.SetProperty(b => b.Password, BCrypt.Net.BCrypt.HashPassword(model.Password)));
            resp.status = true;
            resp.message = "Compnay Password Updated Successfully";
            return Ok(resp);

        }

        [HttpPost("ValidateOTPAccount")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(ReturnObject), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        public ActionResult ValidateOTPAccount(CompanyStepTwo model)
        {
            var resp = new ReturnObject();
            var ret = _db.Companies.FirstOrDefault(o => o.CompanyId.Equals(model.CompanyId));
            if (ret == null)
            {
                resp.status = false;
                resp.message = "Company Doesnt Exist";
                return Ok(resp);
            }
            _db.Companies.Where(o => o.CompanyId.Equals(model.CompanyId)).ExecuteUpdate(setters => setters.SetProperty(b => b.Password, BCrypt.Net.BCrypt.HashPassword(model.Password)));
            resp.status = true;
            resp.message = "Compnay Password Saved Successfully";
            return Ok(resp);
        }
        [NonAction]
        public static bool SendSMS(string pStrToNumber, string pStrBody, string email, string password, string url)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json"; httpWebRequest.Method = "POST";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string message = pStrBody;
                string sender_name = "ERAS";
                string recipients = pStrToNumber;
                string forcednd = "1";
                string json = "{\"email\":\"" + email + "\",\"password\":\"" + password + "\",\"message\":\"" + message + "\",\"sender_name\":\"" + sender_name + "\",\"recipients\":\"" + recipients + "\",\"forcednd\":\"" + forcednd + "\"}";
                streamWriter.Write(json); streamWriter.Flush(); streamWriter.Close();
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd(); Console.WriteLine(result);
            }

            return true;
        }
    }
}
