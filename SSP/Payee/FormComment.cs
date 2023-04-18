using System;
using System.Collections.Generic;

namespace SSP.Payee;

public partial class FormComment
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int BusinessId { get; set; }

    public int CommenterId { get; set; }

    public string CommenterType { get; set; } = null!;

    public string Comment { get; set; } = null!;

    public DateTime FormYear { get; set; }
}
