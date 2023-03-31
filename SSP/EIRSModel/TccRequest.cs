﻿using System;
using System.Collections.Generic;

namespace SSP.EIRSModel;

public partial class TccRequest
{
    public long TccrequestId { get; set; }

    public string? RequestRefNo { get; set; }

    public DateTime? RequestDate { get; set; }

    public long? ServiceBillId { get; set; }

    public int? TaxPayerId { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public int? TaxYear { get; set; }

    public int? StatusId { get; set; }

    public int? VisibleSignStatusId { get; set; }

    public int? PdftemplateId { get; set; }

    public string? GeneratedPath { get; set; }

    public string? ValidatedPath { get; set; }

    public string? SignedVisiblePath { get; set; }

    public string? SignedDigitalPath { get; set; }

    public string? SealedPath { get; set; }

    public int? SedeDocumentId { get; set; }

    public long? SedeOrderId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<MapTccrequestGenerateTccdetail> MapTccrequestGenerateTccdetails { get; } = new List<MapTccrequestGenerateTccdetail>();

    public virtual ICollection<MapTccrequestGenerate> MapTccrequestGenerates { get; } = new List<MapTccrequestGenerate>();

    public virtual ICollection<MapTccrequestIssue> MapTccrequestIssues { get; } = new List<MapTccrequestIssue>();

    public virtual ICollection<MapTccrequestPrepareTccdraft> MapTccrequestPrepareTccdrafts { get; } = new List<MapTccrequestPrepareTccdraft>();

    public virtual ICollection<MapTccrequestRevoke> MapTccrequestRevokes { get; } = new List<MapTccrequestRevoke>();

    public virtual ICollection<MapTccrequestSeal> MapTccrequestSeals { get; } = new List<MapTccrequestSeal>();

    public virtual ICollection<MapTccrequestSignDigital> MapTccrequestSignDigitals { get; } = new List<MapTccrequestSignDigital>();

    public virtual ICollection<MapTccrequestValidateTaxPayerIncome> MapTccrequestValidateTaxPayerIncomes { get; } = new List<MapTccrequestValidateTaxPayerIncome>();

    public virtual ICollection<MapTccrequestValidateTaxPayerInformation> MapTccrequestValidateTaxPayerInformations { get; } = new List<MapTccrequestValidateTaxPayerInformation>();

    public virtual ICollection<MapTccrequestValidate> MapTccrequestValidates { get; } = new List<MapTccrequestValidate>();
}
