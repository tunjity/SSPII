using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class MapCertificateRevoke
{
    public long Crid { get; set; }

    public long? CertificateId { get; set; }

    public string? Reason { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual Certificate? Certificate { get; set; }
}
