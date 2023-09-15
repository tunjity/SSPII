﻿using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class MapCertificateSignVisible
{
    public long Csvid { get; set; }

    public long? CertificateId { get; set; }

    public int? UserId { get; set; }

    public DateTime? SignDate { get; set; }

    public string? Notes { get; set; }

    public int? SignSourceId { get; set; }

    public string? AdditionalSignatureLocation { get; set; }

    public int? StageId { get; set; }

    public string? DocumentWidth { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
