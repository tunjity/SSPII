using System;
using System.Collections.Generic;

namespace SSP.Repository.Payee;

public partial class AssessmentStatus
{
    public int Id { get; set; }

    public int AssStCreateBy { get; set; }

    public DateTime AssStCreateAt { get; set; }

    public string AssessmentStatus1 { get; set; } = null!;

    public string StatusDescription { get; set; } = null!;
}
