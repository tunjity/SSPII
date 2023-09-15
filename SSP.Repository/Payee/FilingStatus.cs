using System;
using System.Collections.Generic;

namespace SSP.Repository.Payee;

public partial class FilingStatus
{
    public int Id { get; set; }

    public string? Filed { get; set; }

    public string? NotFile { get; set; }

    public string? ReAssessed { get; set; }

    public string? OnObjectionReview { get; set; }

    public string? ObjectionApproved { get; set; }

    public string? ObjectionDeclined { get; set; }

    public string? Objected { get; set; }
}
