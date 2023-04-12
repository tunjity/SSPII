using System.ComponentModel.DataAnnotations;

namespace SSP.PayeModel
{
    public class Employees_Monthly_Schedule
    {
        [Key]
        public int EmployeeID { get; set; }
        public int BusinessID { get; set; }
        public int  CompanyID { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int StatusID { get; set; }
        public string Basic { get; set; }
        public string Rent { get; set; }
        public string Transport { get; set; }
        public string LTG { get; set; }
        public string Others { get; set; }
        public double Total_Income { get; set; }
        public string NHF { get; set; }
        public string NHIS { get; set; }
        public double Pension { get; set; }
        public double Gross_Income { get; set; }
        public string CRA { get; set; }
        public double Tax_Free_Pay { get; set; }
        public double Chargable_Income { get; set; }
        public double Tax { get; set; }
    }
}
