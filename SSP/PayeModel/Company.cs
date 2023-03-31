using System;
using System.Collections.Generic;

namespace SSP.PayeModel;

public partial class Company
{
    public long CompanyId { get; set; }

    public int CompanyCreateBy { get; set; }

    public DateTime CompanyCreateAt { get; set; }

    public string CompanyRin { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string? CompanyTin { get; set; }

    public string MobileNumber1 { get; set; } = null!;

    public string? MobileNumber2 { get; set; }

    public string EmailAddress1 { get; set; } = null!;

    public string? EmailAddress2 { get; set; }

    public int? TaxOffice { get; set; }

    public int TaxPayerType { get; set; }

    public int EconomicActivity { get; set; }

    public int PreferredNotificationMethod { get; set; }

    public string TaxPayerStatus { get; set; } = null!;

    public double? AccountBalance { get; set; }

    public string? Add1Hno { get; set; }

    public string? Add2Street { get; set; }

    public string? Add3OffstreetTown { get; set; }

    public int? State { get; set; }

    public int? Town { get; set; }

    public string? ContactPerson { get; set; }

    public int? Ward { get; set; }
}
