using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class MapMdaserviceMdaserviceItem
{
    public int Msmsiid { get; set; }

    public int? MdaserviceId { get; set; }

    public int? MdaserviceItemId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual MdaService? Mdaservice { get; set; }

    public virtual MdaServiceItem? MdaserviceItem { get; set; }
}
