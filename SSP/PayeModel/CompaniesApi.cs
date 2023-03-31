using System;
using System.Collections.Generic;

namespace SSP.PayeModel;

public partial class CompaniesApi
{
    public long CompanyId { get; set; }

    public string CompanyRin { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string? Tin { get; set; }

    public string MobileNumber1 { get; set; } = null!;

    public string? MobileNumber2 { get; set; }

    public string? EmailAddress1 { get; set; }

    public string? EmailAddress2 { get; set; }

    public int? TaxOfficeId { get; set; }

    public string? TaxOfficeName { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public string? TaxPayerTypeName { get; set; }

    public int EconomicActivitiesId { get; set; }

    public string? EconomicActivitiesName { get; set; }

    public int NotificationMethodId { get; set; }

    public string? NotificationMethodName { get; set; }

    public string? ContactAddress { get; set; }

    public string? Active { get; set; }

    public string? ActiveText { get; set; }

    public int? RegisterationStatusId { get; set; }

    public string? RegisterationStatusName { get; set; }

    public DateTime? RegisterationDate { get; set; }
}
