﻿using System;
using System.Collections.Generic;

namespace SSP.EIRSModel;

public partial class MapCertificateSignDigital
{
    public long Csdid { get; set; }

    public long? CertificateId { get; set; }

    public string? Notes { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Certificate? Certificate { get; set; }
}
