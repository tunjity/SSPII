using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using SSP.EIRSModel;
using SSP.Models.CreationModel;
using System.Data;
using System.Net;
using System.Text;
using Vereyon.Web;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SSP.Controllers
{
    public class Login : Controller
    {
        private EirsContext _db;
        private readonly IConfiguration config;
        public Login(IConfiguration config, EirsContext db)
        {
            this.config = config;
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SignOut()
        {
            HttpContext.Session.Clear();
            return Redirect("/Login/SignIn");
        } 
        [HttpGet]
        public ActionResult SignIn()
        {
            var getTaxpayertype = _db.TaxPayerTypes.ToList();
            ViewBag.TaxPayerTypeList = ToSelectList(getTaxpayertype);

            return View();
        }
        [HttpPost]
        public ActionResult SignIn(SignIn model)
        {
            if (model.UserType != "Company")
            {
                var getTaxpayertype = _db.TaxPayerTypes.ToList();
                ViewBag.TaxPayerTypeList = ToSelectList(getTaxpayertype);

                TempData["AlertMessage"] = $"Incorrect UserType";
                return View();
            }
            if ((model.Password == null) || (model.Password.Length < 5))
            {
                var getTaxpayertype = _db.TaxPayerTypes.ToList();
                ViewBag.TaxPayerTypeList = ToSelectList(getTaxpayertype);
                ModelState.AddModelError("Password", "Please Enter Valid Password as the length is less than 5");
                TempData["AlertMessage"] = $"Incorrect Please Enter Valid Password as the length is less than 5";
                return View();
            }
            Company eirsUser = new Company();
            var ret = _db.Companies.SingleOrDefault(o => (o.CompanyRin == model.PhoneNumber_RIN.ToString().Trim()) || (o.MobileNumber1 == model.PhoneNumber_RIN.ToString().Trim()));

            if (ret != null)
            {
                if(BCrypt.Net.BCrypt.Verify(model.Password, ret.Password))
                {
                    HttpContext.Session.SetString("username", ret.CompanyName.ToString());
                    HttpContext.Session.SetString("rin", ret.CompanyRin.ToString());
                    TempData["AlertMessage"] = $"Welcome {ret.CompanyName}";
                    return Redirect("/Dashboard/Index");
                }
            }

            return Ok("Invalid Login Detail");
        }

        [HttpGet]
        public ActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ForgetPassword(ForgetPassword model)
        {
            if ((model.Password == null) || (model.Password.Length < 5))
            {
                TempData["AlertMessage"] = $"Incorrect Please Enter Valid Password as the length is less than 5";
                return View();
            }
            Company eirsUser = new Company();
            var ret = _db.Companies.FirstOrDefault(o => (o.CompanyRin == model.PhoneNumber_RIN.ToString().Trim()) || (o.CompanyRin == model.PhoneNumber_RIN.ToString().Trim()));

            if (ret == null)
            {
                TempData["AlertMessage"] = $"Incorrect User Not Found";
                return Redirect("/Login/CreateAccount");
            }
            else
            {
                ret.Password = BCrypt.Net.BCrypt.HashPassword(model.Password);
                _db.SaveChanges();
                TempData["AlertMessage"] = $"Password Changed Successfully";
                return Redirect("/Login/SignIn");
            }

        }

        [HttpGet]
        public ActionResult CreateAccount()
        {

            return View();
        }
        [HttpPost]
        public ActionResult CreateAccount(CompanyStepOne model)
        {
            Company company = new Company
            {
                TaxPayerTypeId = 2,
                MobileNumber1 = model.MobileNumber1,
                ContactAddress = model.ContactAddress,
                CompanyName = model.CompanyName,
                TaxOfficeId = 1,
                NotificationMethodId = 1,
                EconomicActivitiesId = 1
            };

            if (company.MobileNumber1.Length == 10)
            {
                if (!company.MobileNumber1.StartsWith("0"))
                {
                    company.MobileNumber1 = "0" + company.MobileNumber1;
                }
                else
                {
                    TempData["AlertMessage"] = $"Error Invalid Phone Number Format";
                    return Redirect("/Login/CreateAccount");
                }
            }
            else
            {
                TempData["AlertMessage"] = $"Error Invalid Phone Number Format";
                return Redirect("/Login/SignIn");
            }
            //send sms region
            string? SmsBaseUrl = config.GetConnectionString("SmsBaseUrl");
            string? username = config.GetConnectionString("username");
            string? password = config.GetConnectionString("password");
            //check if it exist
            var checker = _db.Companies.FirstOrDefault(o => (o.CompanyName == company.CompanyName && o.MobileNumber1 == company.MobileNumber1) || (o.CompanyName == company.CompanyName && o.ContactAddress == company.ContactAddress));
            if (checker != null)
            {
                TempData["AlertMessage"] = $"Error User Already Exist";
                return Redirect("/Login/CreateAccount");
            }
            Random r = new Random();
            var x = r.Next(0, 1000000);
            string s = x.ToString("000000");

            StringBuilder sbSMSContent = new StringBuilder();
            sbSMSContent.Append("Use "); sbSMSContent.Append(s); sbSMSContent.Append(" as your Login OTP To Edo State Self Service Portal, This expiry at the close of this page");
            bool ret = SendSMS(model.MobileNumber1, sbSMSContent.ToString(), username, password, SmsBaseUrl);
            if (ret)
            {
                company.VerificationOtp = Convert.ToInt32(s);
                TempData["cmpy"] = JsonConvert.SerializeObject(company);
                //alert otp sent
                TempData["AlertMessage"] = $"OTP sent";
                return Redirect("/Login/ValidateOTPAccount");
            }
            return View();
        }
        [HttpGet]
        public ActionResult ValidateOTPAccount()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ValidateOTPAccount(CompanyStepTwo model)
        {
            var company = JsonConvert.DeserializeObject<Company>(TempData["cmpy"].ToString());
            if (company == null)
            {
                return Redirect("/Login/CreateAccount");
            }
            //if (company.VerificationOtp != model.VerificationOtp)
            //{
            //    TempData["AlertMessage"] = $"Error Incorrect OTP";
            //    //alert in correct otp
            //    return Redirect("/Login/CreateAccount");
            //}
            company.Password = BCrypt.Net.BCrypt.HashPassword(model.Password);

            _db.Companies.Add(company);
            int i=_db.SaveChanges();
            if(i != 0)
            {
                HttpContext.Session.SetString("username", company.CompanyName.ToString());
                TempData["AlertMessage"] = $"Registration Was Successful";
                return Redirect("/Dashboard/Index");
            }
           return View();
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

        [NonAction]
        public SelectList ToSelectList(List<TaxPayerType> table)
        {
            List<SelectListItem> list = new List<SelectListItem>();

            foreach (var row in table)
            {
                list.Add(new SelectListItem()
                {
                    Text = row.TaxPayerTypeName.ToString(),
                    Value = row.TaxPayerTypeName.ToString()
                });
            }

            return new SelectList(list, "Value", "Text");
        }
    }
}
