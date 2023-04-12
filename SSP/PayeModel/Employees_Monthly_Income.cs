using System.ComponentModel.DataAnnotations;

namespace SSP.PayeModel
{
    public class Employees_Monthly_Income
    {
        [Key]
        public int EmployeeID { get; set; }
        public int BusinessID { get; set; }
        public string Basic { get; set; }
        public double Rent { get; set; }
        public string Transport { get; set; }
        public string LTG { get; set; }
        public string Others { get; set; }
        public double Total_Income { get; set; }
        public string NHF { get; set; }
        public string NHIS { get; set; }

    }
}
