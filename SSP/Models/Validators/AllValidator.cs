namespace SSP.Models.Validators
{
    public class AllValidator
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
    } 
    public class RTNValidator
    {
        public string RIN { get; set; }
        public string TIN { get; set; }
        public string Phone { get; set; }
    }  
    public class FeesValidator
    {
        public string LTG { get; set; }
        public string Others { get; set; }
        public string Basic { get; set; }
        public string Rent { get; set; }  
        public string Transport { get; set; }
        public string Meal { get; set; }
        public string Utility { get; set; }
    }
}
