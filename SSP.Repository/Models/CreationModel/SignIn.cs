using System.ComponentModel.DataAnnotations;

namespace SSP.Repository.Models.CreationModel
{
    public class SignIn
    {
        [Required(ErrorMessage = "Please Select UserType")]
        [Display(Name = "UserType")]
        public string UserType { get; set; }

        [Required(ErrorMessage = "Please enter PhoneNumber or RIN")]
        [Display(Name = "PhoneNumber or RIN")]
        public string PhoneNumber_RIN { get; set; }

        [Required(ErrorMessage = "Enter your password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    } 
    public class ForgetPassword
    {

        [Required(ErrorMessage = "Please enter PhoneNumber or RIN")]
        [Display(Name = "PhoneNumber or RIN")]
        public string PhoneNumber_RIN { get; set; }

        [Required(ErrorMessage = "Enter your password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
