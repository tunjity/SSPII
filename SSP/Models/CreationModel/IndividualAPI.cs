namespace SSP.Models.CreationModel
{
    public class IndividualAPI
    {
        public int GenderID { get; set; }

        public int TitleID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string MiddleName { get; set; }
        public string DOB { get; set; }
        public string TIN { get; set; }
        //public string NIN { get; set; }

        public string MobileNumber1 { get; set; }
        public string EmailAddress1 { get; set; }

        public string BiometricDetails { get; set; }

        public int? TaxOfficeID { get; set; }
        public int? MaritalStatusID { get; set; }

        public int NationalityID { get; set; }

        public int TaxPayerTypeID { get; set; }

        public int EconomicActivitiesID { get; set; }
        public int NotificationMethodID { get; set; }

        public string ContactAddress { get; set; }
    }
}
