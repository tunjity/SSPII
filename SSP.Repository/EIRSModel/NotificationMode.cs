using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class NotificationMode
{
    public int NotificationModeId { get; set; }

    public string? NotificationModeName { get; set; }

    public virtual ICollection<Notification> Notifications { get; } = new List<Notification>();
}
