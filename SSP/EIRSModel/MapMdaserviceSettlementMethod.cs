using System;
using System.Collections.Generic;

namespace SSP.EIRSModel;

public partial class MapMdaserviceSettlementMethod
{
    public int Arsmid { get; set; }

    public int? MdaserviceId { get; set; }

    public int? SettlementMethodId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual MdaService? Mdaservice { get; set; }

    public virtual SettlementMethod? SettlementMethod { get; set; }
}
