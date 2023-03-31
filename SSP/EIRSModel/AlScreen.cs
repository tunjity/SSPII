using System;
using System.Collections.Generic;

namespace SSP.EIRSModel;

public partial class AlScreen
{
    public int Aslid { get; set; }

    public string? Aslname { get; set; }

    public virtual ICollection<AuditLog> AuditLogs { get; } = new List<AuditLog>();
}
