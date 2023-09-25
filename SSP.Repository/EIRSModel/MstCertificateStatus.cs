using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class MstCertificateStatus
{
    public int CertificateStatusId { get; set; }

    public string? CertificateStatusName { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }
}
