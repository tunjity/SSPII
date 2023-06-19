using Microsoft.AspNetCore.Mvc;
using SSP.Infrastructure.RawSql;
using SSP.Infrastructure;
using SSP.PayeModelII;
using SSP.Models;
using SSP.Infrastructure.Utility;
using Grpc.Core;
using Microsoft.AspNetCore.Http;
using System.Configuration;
using Microsoft.Extensions.Hosting;
using Syncfusion.EJ2.Inputs;
using System.Data;
using Exception = System.Exception;
using ExcelDataReader;
using static SSP.Models.APIResponse.Response;
using Newtonsoft.Json;
using NuGet.Common;
using System.Net;
using System;
using OfficeOpenXml;
using System.Threading;
using SSP.Models.Validators;
using SSP.Models.CreationModel;
using SSP.EIRSModel;
using System.Net.Http.Headers;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSP.Controllers.MonthlyRemitance
{
    public class EmployeeController : Controller
    {
        private IEmployeesMonthlyIncomeRepository _repository;
        private IEmployeeRepository _repo;
        private IAllRawSql _allRawSql;
        private IConfiguration configuration;
        IExcelDataReader reader;
        public EmployeeController(IConfiguration iConfig)
        {
            configuration = iConfig;
            _repository = new EmployeesMonthlyIncomeRepository();
            _allRawSql = new AllRawSql();
        }
        public IActionResult Index()
        {
            var yrs = new List<AllYear>();
            var last10Years = from n in Enumerable.Range(0, 10)
                              select DateTime.Now.Year - n;
            foreach (var year in last10Years)
            {
                AllYear yr = new AllYear();
                yr.YearValue = year.ToString();
                yr.YearId = year.ToString();
                yrs.Add(yr);
            }
            BusinessEmployeeCreateAndGetViewModel mymodel = new BusinessEmployeeCreateAndGetViewModel();
            List<EmployeesMonthlyIncome> response = new List<EmployeesMonthlyIncome>();
            if (HttpContext.Session.GetString("rin") != null)
            {
                string rin = HttpContext.Session.GetString("rin").ToString();
                var resp = _allRawSql.GetAssociateBusinessbyRin(rin);
                ViewBag.Upshow = "0";
                ViewBag.Year = yrs.ToSelectList(nameof(AllYear.YearId), nameof(AllYear.YearValue));
                ViewBag.CompRin = resp.ToSelectList(nameof(AssetTaxPayerDetailsApi.AssetName), nameof(AssetTaxPayerDetailsApi.AssetRin));

                mymodel.empList = response;
                return View(mymodel);
            }
            return RedirectToAction("Login", "SignIn");
        }
        [HttpPost]
        public IActionResult Index(BusinessEmployeeCreateAndGetViewModel filter)
        {
            var yrs = new List<AllYear>();
            var last10Years = from n in Enumerable.Range(0, 10)
                              select DateTime.Now.Year - n;
            foreach (var year in last10Years)
            {
                AllYear yr = new AllYear();
                yr.YearValue = year.ToString();
                yr.YearId = year.ToString();
                yrs.Add(yr);
            }
            BusinessEmployeeCreateAndGetViewModel mymodel = new BusinessEmployeeCreateAndGetViewModel();
            List<EmployeesMonthlyIncome> response = new List<EmployeesMonthlyIncome>();
            if (HttpContext.Session.GetString("rin") != null)
            {
                string rin = HttpContext.Session.GetString("rin").ToString();
                string id = HttpContext.Session.GetString("id").ToString();
                var resp = _allRawSql.GetAssociateBusinessbyRin(rin);
                ViewBag.Year = yrs.ToSelectList(nameof(AllYear.YearId), nameof(AllYear.YearValue));
                ViewBag.CompRin = resp.ToSelectList(nameof(AssetTaxPayerDetailsApi.AssetRin), nameof(AssetTaxPayerDetailsApi.AssetName));

                if ((filter.employeeBusinessFilter.Year == null) && (filter.employeeBusinessFilter.CompRin == null))
                {
                    ViewBag.Upshow = "0";
                }
                else
                {
                    ViewBag.Upshow = "1";

                    response = _repository.GetById(id).ToList();
                }
                mymodel.empList = response;

                return View(mymodel);
            }
            return RedirectToAction("Login", "SignIn");
        }
        [HttpGet]
        public ActionResult Upload()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Upload(IFormFile file)
        {
            try
            {
                var saveTOApi = new Receiver();
                string msg, rin, totalMsg = "";
                List<ExcelModel> employees = new List<ExcelModel>();
                if (file == null)
                    throw new Exception("File is Not Received...");

                if (HttpContext.Session.GetString("rin") != null)
                {
                    rin = HttpContext.Session.GetString("rin").ToString();
                    string compId = HttpContext.Session.GetString("id").ToString();
                    string docpath = configuration.GetValue<string>("ConnectionStrings:upload");
                    string dataFileName = Path.GetFileName(file.FileName);
                    docpath = docpath + $"//{rin}";
                    string fileName = rin + "_" + dataFileName;
                    var filePath = Path.Combine(docpath, fileName);

                    if (!Directory.Exists(docpath))
                    {
                        Directory.CreateDirectory(docpath);
                    }
                    string extension = Path.GetExtension(dataFileName);

                    string[] allowedExtsnions = new string[] { ".xls", ".xlsx" };

                    if (!allowedExtsnions.Contains(extension))
                        throw new Exception("Sorry! This file is not allowed, make sure that file having extension as either.xls or.xlsx is uploaded.");

                    // Make a Copy of the Posted File from the Received HTTP Request
                    string saveToPath = Path.Combine(filePath);

                    if (!Directory.Exists(docpath))
                    {
                        Directory.CreateDirectory(docpath);
                    }
                    using (var stream = new MemoryStream())
                    {
                        await file.CopyToAsync(stream);
                        ExcelPackage.LicenseContext = LicenseContext.Commercial;
                        using (var package = new ExcelPackage(stream))
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();
                            var rowCount = worksheet.Dimension.Rows;
                            employees = GetListFromExcel<ExcelModel>(worksheet);
                        }
                        for (int i = 0; i < employees.Count; i++)
                        {
                            AllValidator name = new AllValidator { FirstName = employees[i].first_name, SurName = employees[i].surname };
                            RTNValidator rTN = new RTNValidator { TIN = employees[i].employee_tin, Phone = employees[i].employee_phone, RIN = employees[i].employee_rin };
                            FeesValidator fees = new FeesValidator { Basic = employees[i].annual_basic, Rent = employees[i].annual_rent, LTG = employees[i].leave_transport_grant_annual, Meal = employees[i].annual_meal, Others = employees[i].other_allowances_annual, Utility = employees[i].annual_utility, Transport = employees[i].annual_transport };
                            if ((!nameDet(name)) || (!rtnDet(rTN)) || (!feesDet(fees)))
                            {
                                msg = $"row {i} not added because firstname or surname or phone_number or RIN or TIN is null /r/n";
                                totalMsg = totalMsg + msg;
                            }
                            else
                            {
                                IndividualAPI individualAPI = new IndividualAPI
                                {
                                    TaxPayerTypeID = 1,
                                    GenderID = 1,
                                    TitleID = 2,
                                    FirstName = employees[i].first_name,
                                    MiddleName = employees[i].middle_name,
                                    DOB = "01/01/2004",
                                    TIN = employees[i].employee_tin,
                                    MobileNumber1 = employees[i].employee_phone,
                                    EmailAddress1 = "abc@gmail.com",
                                    BiometricDetails = "",
                                    TaxOfficeID = 34,
                                    MaritalStatusID = 3,
                                    NationalityID = 1,
                                    EconomicActivitiesID = 13,
                                    NotificationMethodID = 3,
                                    ContactAddress = "None Listed",
                                    LastName = employees[i].surname,
                                };
                                saveTOApi = await CallConfirmationAPIAsync(employees[i].employee_rin, employees[i].employee_phone, employees[i].employee_tin, "1", individualAPI);
                                if (saveTOApi.Result != null)
                                {
                                    saveTOApi = await CallConfirmationAPIAsync("", "", "", "2", individualAPI);
                                }
                                Employee businessEmployee = new Employee
                                {
                                    EmployeeId = Convert.ToInt32(saveTOApi.Result.TaxPayerID),
                                    FirstName = individualAPI.FirstName,
                                    LastName = individualAPI.LastName,
                                    EmailAddress = individualAPI.EmailAddress1,
                                    EmployeeRin = employees[i].employee_rin,
                                    IndividualId = saveTOApi.Result.TaxPayerID.ToString(),
                                    Tin = individualAPI.TIN,
                                    TaxOffice = individualAPI.TaxOfficeID.ToString()
                                };
                                _repo.Insert(businessEmployee);
                                EmployeesMonthlyIncome employeesMonthlyIncome = new EmployeesMonthlyIncome
                                {
                                    Rent = Convert.ToDouble(employees[i].annual_rent),
                                    Basic = Convert.ToDouble(employees[i].annual_basic),
                                    Transport = Convert.ToDouble(employees[i].annual_transport),
                                    Ltg = Convert.ToDouble(employees[i].leave_transport_grant_annual),
                                    Utility = Convert.ToDouble(employees[i].annual_utility),
                                    Meal = Convert.ToDouble(employees[i].annual_meal),
                                    Others = Convert.ToDouble(employees[i].other_allowances_annual),
                                    Nhf = Convert.ToDouble(employees[i].nhf_contribution_declared),
                                    Nhis = Convert.ToDouble(employees[i].nhis_contribution_declared),
                                    Pension = Convert.ToDouble(employees[i].pension_contribution_declared),
                                    EmployeeId = businessEmployee.Id,
                                    CompanyId = Convert.ToInt32(compId)
                                };
                                _repository.Insert(employeesMonthlyIncome);
                            }

                        }
                    }

                    ViewBag.tempMsg = totalMsg;
                    return RedirectToAction("Employee", "Index", new BusinessEmployeeCreateAndGetViewModel { empList = null, employeeBusinessFilter = new EmployeeBusinessFilter { CompRin = rin, Year = null } });

                }

                return RedirectToAction("Login", "SignIn");
            }
            catch (Exception ex)
            {
                return View("Error", new ErrorViewModel()
                {
                    ControllerName = this.RouteData.Values["controller"].ToString(),
                    ActionName = this.RouteData.Values["action"].ToString(),
                    ErrorMessage = ex.Message
                });
            }
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Add(CreateSingleEmployeeModel file)
        {
            string msg,rin, totalMsg = "";
            var saveTOApi = new Receiver();
            try
            {
                if (HttpContext.Session.GetString("rin") != null)
                {
                    rin = HttpContext.Session.GetString("rin").ToString();
                    string compId = HttpContext.Session.GetString("id").ToString();
                    AllValidator name = new AllValidator { FirstName = file.FirstName, SurName = file.Surname };
                    RTNValidator rTN = new RTNValidator { TIN = file.TIN, Phone = file.PhoneNumber, RIN = file.RIN };
                    FeesValidator fees = new FeesValidator { Basic = file.BasicIncome.ToString(), Rent = file.Rent.ToString(), LTG =file.LifeAssurance.ToString(), Meal = null, Others = file.OtherIncome.ToString(), Utility = null, Transport = file.Transport.ToString() };
                    if ((!nameDet(name)) || (!rtnDet(rTN)) || (!feesDet(fees)))
                    {
                        msg = $"user not added because firstname or surname or phone_number or RIN or TIN is null";
                        totalMsg = totalMsg + msg;
                    }
                    else
                    {
                        IndividualAPI individualAPI = new IndividualAPI
                        {
                            TaxPayerTypeID = 1,
                            GenderID = 1,
                            TitleID = file.Title,
                            FirstName = file.FirstName,
                            MiddleName = "",
                            DOB = "01/01/2004",
                            TIN = file.TIN,
                            MobileNumber1 = file.PhoneNumber,
                            EmailAddress1 = "abc@gmail.com",
                            BiometricDetails = "",
                            TaxOfficeID = 34,
                            MaritalStatusID = 3,
                            NationalityID = 1,
                            EconomicActivitiesID = 13,
                            NotificationMethodID = 3,
                            ContactAddress = "None Listed",
                            LastName = file.Surname,
                        };

                        saveTOApi = await CallConfirmationAPIAsync(file.RIN, file.PhoneNumber, file.TIN, "1", individualAPI);
                        if (saveTOApi.Result != null)
                        {
                            saveTOApi = await CallConfirmationAPIAsync("", "", "", "2", individualAPI);
                        }
                        Employee businessEmployee = new Employee
                        {
                            EmployeeId = Convert.ToInt32(saveTOApi.Result.TaxPayerID),
                            FirstName = individualAPI.FirstName,
                            LastName = individualAPI.LastName,
                            EmailAddress = individualAPI.EmailAddress1,
                            EmployeeRin = file.RIN,
                            IndividualId = saveTOApi.Result.TaxPayerID.ToString(),
                            Tin = individualAPI.TIN,
                            TaxOffice = individualAPI.TaxOfficeID.ToString()
                        };
                        _repo.Insert(businessEmployee);
                        EmployeesMonthlyIncome employeesMonthlyIncome = new EmployeesMonthlyIncome
                        {
                            Rent = Convert.ToDouble(file.Rent),
                            Basic = Convert.ToDouble(file.BasicIncome),
                            Transport = Convert.ToDouble(file.Transport),
                            Ltg = Convert.ToDouble(file.LifeAssurance),
                            Utility = 0.00,
                            Meal = 0.00,
                            Others = Convert.ToDouble(file.OtherIncome),
                            Nhf = Convert.ToDouble(file.NHF),
                            Nhis = Convert.ToDouble(file.NHIS),
                            Pension = Convert.ToDouble(file.Pension),
                            EmployeeId = businessEmployee.Id,
                            CompanyId = Convert.ToInt32(compId)
                        };
                        _repository.Insert(employeesMonthlyIncome);
                    }
                    return RedirectToAction("Employee", "Index", new BusinessEmployeeCreateAndGetViewModel { empList = null, employeeBusinessFilter = new EmployeeBusinessFilter { CompRin = rin, Year = null } });
                }

                return RedirectToAction("Login", "SignIn");
            }
            catch (Exception ex)
            {
                return View("Error", new ErrorViewModel()
                {
                    ControllerName = this.RouteData.Values["controller"].ToString(),
                    ActionName = this.RouteData.Values["action"].ToString(),
                    ErrorMessage = ex.Message
                });
            }
        }
        public ActionResult DownloadFile()
        {
            string docpath = configuration.GetValue<string>("ConnectionStrings:templatepath");
            //var docpath = configuration.GetConnectionString("docpath");
            string path = docpath ?? string.Empty;
            string fileName = "EmployeeTemplate.xls";
            var sDocument = Path.Combine(path + fileName);

            // string path = Server.MapPath("~/Files/") + fileName;

            //Read the File data into Byte Array.
            byte[] bytes = System.IO.File.ReadAllBytes(sDocument);

            //Send the File to Download.
            return File(bytes, "application/octet-stream", fileName);
        }
        [NonAction]
        private bool nameDet(AllValidator name)
        {
            var ret = name.GetType()
                .GetProperties() //get all properties on object
                .Select(pi => pi.GetValue(name)) //get value for the property
                .Any(value => value != null);

            return ret;
        }
        [NonAction]
        private bool rtnDet(RTNValidator rtn)
        {
            var ret = rtn.GetType()
                 .GetProperties() //get all properties on object
                 .Select(pi => pi.GetValue(rtn)) //get value for the property
                 .Any(value => value != null);

            return ret;
        }
        [NonAction]
        private bool feesDet(FeesValidator fees)
        {
            var ret = fees.GetType()
                  .GetProperties() //get all properties on object
                  .Select(pi => pi.GetValue(fees)) //get value for the property
                  .Any(value => value != null);

            return ret;
        }
        [NonAction]
        private List<T> GetListFromExcel<T>(ExcelWorksheet sheet)
        {
            List<T> list = new List<T>();
            //first row is for knowing the properties of object
            var columnInfo = Enumerable.Range(1, sheet.Dimension.Columns).ToList().Select(n =>

                new { Index = n, ColumnName = sheet.Cells[1, n].Value.ToString() }
            );

            for (int row = 2; row < sheet.Dimension.Rows; row++)
            {
                T obj = (T)Activator.CreateInstance(typeof(T));//generic object
                foreach (var prop in typeof(T).GetProperties())
                {
                    int col = columnInfo.SingleOrDefault(c => c.ColumnName == prop.Name).Index;
                    var val = sheet.Cells[row, col].Value;
                    var propType = prop.PropertyType;
                    prop.SetValue(obj, Convert.ChangeType(val, propType));
                }
                list.Add(obj);
            }

            return list;
        }
        [NonAction]
        private async Task<Receiver> CallConfirmationAPIAsync(string rin, string phoneNumber, string tin, string caller, IndividualAPI individualAPI)
        {

            var respObj = new Receiver();

            string url = ConfigHelpers.AppSetting("ERASAPI", "ErasBaseUrl");
            // string url = configuration.GetValue<string>("ConnectionStrings:ErasBaseUrl");
            switch (caller)
            {
                case "1":
                    if (rin != "") url = url + "TaxPayer/SearchTaxPayerByRIN?TaxPayerRIN=" + rin;
                    else if (phoneNumber != "") url = url + "TaxPayer/SearchTaxPayerByMobileNumber?MobileNumber=" + phoneNumber;
                    else
                        url = url + "TaxPayer/SearchTaxPayerByTIN?TaxPayerTIN=" + tin;

                    using (HttpClient client = new HttpClient())
                    {
                        var response = await client.GetAsync(url).ConfigureAwait(false);

                        var result = response.Content.ReadAsStringAsync();
                        string res = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        respObj = JsonConvert.DeserializeObject<Receiver>(res);
                    }
                    break;
                case "2":
                    url = url + "TaxPayer/Individual/Insert";
                    var httpClient = new HttpClient { BaseAddress = new Uri(url) };
                    // httpClient.DefaultRequestHeaders.Add("Authorization", header);
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    string request = JsonConvert.SerializeObject(individualAPI);
                    var content = new StringContent(request, Encoding.UTF8, "application/json");

                    var resp = await httpClient.PostAsync(url, content);
                    var stringData = resp.Content.ReadAsStringAsync().Result;
                    var resultObj = JsonConvert.DeserializeObject<object>(stringData);
                    break;
            }


            return respObj;
        }
    }
}