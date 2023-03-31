using System;
using System.Collections.Generic;

namespace SSP.EIRSModel;

public partial class MapServiceBillMdaservice
{
    public long Sbsid { get; set; }

    public long? ServiceBillId { get; set; }

    public int? MdaserviceId { get; set; }

    public int? ServiceBillYear { get; set; }

    public decimal? ServiceAmount { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<MapServiceBillMdaserviceItem> MapServiceBillMdaserviceItems { get; } = new List<MapServiceBillMdaserviceItem>();

    public virtual MdaService? Mdaservice { get; set; }

    public virtual ServiceBill? ServiceBill { get; set; }
}
