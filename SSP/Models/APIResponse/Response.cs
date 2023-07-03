namespace SSP.Models.APIResponse
{
    public class Response
    {
        public class Receiver
        {
            public bool Success { get; set; }
            public string Message { get; set; }
            public List<TaxPayerClassResult> Result { get; set; }

        }
        public class TaxPayerClassResult
        {
            public long TaxPayerID { get; set; }
            public int TaxPayerTypeID { get; set; }
            public string TaxPayerRIN { get; set; }
            public string TaxPayerName { get; set; }
            public string TaxPayerMobileNumber { get; set; }
            public string TaxPayerAddress { get; set; }
            public string TaxOfficeID { get; set; }
            public string TaxOfficeName { get; set; }
            public string TaxPayerTypeName { get; set; }
        }
    }
}
