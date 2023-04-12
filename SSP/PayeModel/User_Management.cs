using System.ComponentModel.DataAnnotations;

namespace SSP.PayeModel
{
    public class User_Management
    {
        [Key]
        public int CompanyID { get; set; }
        public int BusinessID { get; set; }
        public int TaxpayerID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
