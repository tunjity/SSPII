﻿using System;
using System.Collections.Generic;

namespace SSP.PayeModel;

public partial class CompanyListBkApi
{
    public long TaxPayerId { get; set; }

    public int TaxPayerTypeId { get; set; }

    public string? TaxPayerTypeName { get; set; }

    public string? TaxPayerName { get; set; }

    public string? TaxPayerRin { get; set; }

    public string? MobileNumber { get; set; }

    public string? ContactAddress { get; set; }

    public string? EmailAddress { get; set; }

    public string? Tin { get; set; }

    public string? TaxOffice { get; set; }
}
