using System;
using System.Collections.Generic;

namespace SSP.EIRSModel;

public partial class NotificationMethod
{
    public int NotificationMethodId { get; set; }

    public string? NotificationMethodName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Company> Companies { get; } = new List<Company>();

    public virtual ICollection<Government> Governments { get; } = new List<Government>();

    public virtual ICollection<Individual> Individuals { get; } = new List<Individual>();

    public virtual ICollection<Notification> Notifications { get; } = new List<Notification>();

    public virtual ICollection<Special> Specials { get; } = new List<Special>();
}
