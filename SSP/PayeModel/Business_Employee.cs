using System.ComponentModel.DataAnnotations;

namespace SSP.PayeModel
{
    public class Business_Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public int BusinessID { get; set; }
        public bool Empployee_Status { get; set; }
        public string Designation { get; set; }
        public DateTime Start_Date { get; set; }
       
    }
}
