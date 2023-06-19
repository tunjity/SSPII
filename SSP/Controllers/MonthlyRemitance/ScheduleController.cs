using Microsoft.AspNetCore.Mvc;
using SSP.Infrastructure.Utility;
using Syncfusion.EJ2.DropDowns;

namespace SSP.Controllers.MonthlyRemitance
{
    public class ScheduleController : Controller
    {
        public IActionResult Index()
        {
            System.Globalization.DateTimeFormatInfo info = System.Globalization.DateTimeFormatInfo.GetInstance(null);
            var yrs = new List<SelectForDropdown>();
            var last10Years = from n in Enumerable.Range(0, 10)
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

            return View();
        }
    }
}
