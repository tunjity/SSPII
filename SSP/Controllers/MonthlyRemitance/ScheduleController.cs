using ExcelDataReader;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using SSP.Infrastructure.RawSql;
using SSP.Infrastructure;
using SSP.Infrastructure.Utility;
using SSP.Models;
using SSP.PayeModelII;
using Syncfusion.EJ2.DropDowns;
using Newtonsoft.Json;
using SSP.EIRSModel;

namespace SSP.Controllers.MonthlyRemitance
{
    public class ScheduleController : Controller
    {
        private IEmployeesMonthlyScheduleRepository _repository;
        private IEmployeeRepository _repo;
        private IAllRawSql _allRawSql;
        private IConfiguration configuration;
        IExcelDataReader reader;
        public ScheduleController(IConfiguration iConfig)
        {
            configuration = iConfig;
            _repository = new EmployeesMonthlyScheduleRepository();
            _allRawSql = new AllRawSql();
        }
        public IActionResult Index()
        {
            System.Globalization.DateTimeFormatInfo info = System.Globalization.DateTimeFormatInfo.GetInstance(null);
            var yrs = new List<SelectForDropdown>();
            var last10Years = from n in Enumerable.Range(0, 5)
                              select DateTime.Now.Year - n;
            foreach (var year in last10Years)
            {
                SelectForDropdown yr = new SelectForDropdown();
                yr.Value = year.ToString();
                yr.Id = year.ToString();
                yrs.Add(yr);
            }
            var mths = new List<SelectForDropdown>();
            for (int i = 1; i < 13; i++)
            {
                SelectForDropdown mst = new SelectForDropdown();
                mst.Id = i.ToString();
                mst.Value = info.GetMonthName(i).ToString();
                mths.Add(mst);
            }
            ViewBag.Upshow = "0";
            ViewBag.Year = yrs.ToSelectList(nameof(SelectForDropdown.Id), nameof(SelectForDropdown.Value));
            ViewBag.Months = mths.ToSelectList(nameof(SelectForDropdown.Value), nameof(SelectForDropdown.Id));
            string itm = JsonConvert.SerializeObject(mths);
            HttpContext.Session.SetString("mthsItems", itm);          
            string yrItm = JsonConvert.SerializeObject(yrs);
            HttpContext.Session.SetString("yrItms", yrItm);

            return View();
        }

        [HttpPost]
        public IActionResult Index(BusinessEmployeeCreateAndGetViewModel filter)
        {
            string mthsList = HttpContext.Session.GetString("mthsItems");
            var mths = JsonConvert.DeserializeObject<List<SelectForDropdown>>(mthsList);
            ViewBag.Months = mths.ToSelectList(nameof(SelectForDropdown.Value), nameof(SelectForDropdown.Id)); 
            
            string yrList = HttpContext.Session.GetString("yrItms");
            var yrs = JsonConvert.DeserializeObject<List<SelectForDropdown>>(yrList);
            ViewBag.Year = yrs.ToSelectList(nameof(SelectForDropdown.Id), nameof(SelectForDropdown.Value));
           
           // BusinessEmployeeCreateAndGetViewModel mymodel = new BusinessEmployeeCreateAndGetViewModel();
           EmployeesMonthlySchedule response = new EmployeesMonthlySchedule();
            if (HttpContext.Session.GetString("rin") != null)
            {
                string rin = HttpContext.Session.GetString("rin").ToString();
                string id = HttpContext.Session.GetString("id").ToString();
                var resp = _allRawSql.GetAssociateBusinessbyRin(rin);
                ViewBag.Year = yrs.ToSelectList(nameof(SelectForDropdown.Id), nameof(SelectForDropdown.Value));
                ViewBag.Months = mths.ToSelectList(nameof(SelectForDropdown.Value), nameof(SelectForDropdown.Id));

                if ((filter.employeeBusinessFilter.Year == null) && (filter.employeeBusinessFilter.CompRin == null))
                {
                    ViewBag.Upshow = "0";
                }
                else
                {
                    ViewBag.Upshow = "1";

                    response =  _repository.GetAll().Where(o=>o.CompanyId.ToString() == id && o.Year.ToString() == filter.employeeBusinessFilter.Year && o.Month.ToString() == filter.employeeBusinessFilter.Months).FirstOrDefault();
                }
               // mymodel.empList = response;

                return View(response);
            }
            return RedirectToAction("Login", "SignIn");
        }
      
    }
}
