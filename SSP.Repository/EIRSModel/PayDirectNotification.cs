using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class PayDirectNotification
{
    public long PdinotificationId { get; set; }

    public string? RequestParameter { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }
}
