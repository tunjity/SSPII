using System;
using System.Collections.Generic;

namespace SSP.Payee;

public partial class ScheduleComment
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public int CompanyId { get; set; }

    public int BusinessId { get; set; }

    public int CommenterType { get; set; }

    public int CommenterId { get; set; }

    public int Commenter { get; set; }
}
