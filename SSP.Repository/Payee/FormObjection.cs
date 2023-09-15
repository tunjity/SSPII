using System;
using System.Collections.Generic;

namespace SSP.Repository.Payee;

public partial class FormObjection
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int BusinessId { get; set; }

    public DateTime Date { get; set; }
}
