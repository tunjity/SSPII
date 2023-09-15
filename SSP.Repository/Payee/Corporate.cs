using System;
using System.Collections.Generic;

namespace SSP.Repository.Payee;

public partial class Corporate
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int CompanyRin { get; set; }

    public string CompanyName { get; set; } = null!;
}
