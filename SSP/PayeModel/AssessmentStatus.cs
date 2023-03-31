using System;
using System.Collections.Generic;

namespace SSP.PayeModel;

public partial class AssessmentStatus
{
    public int AssStId { get; set; }

    public int AssStCreateBy { get; set; }

    public DateTime AssStCreateAt { get; set; }

    public string AssessmentStatus1 { get; set; } = null!;

    public string StatusDescription { get; set; } = null!;

    public int? GroupId { get; set; }

    public int? AssNextStId { get; set; }

    public int? Active { get; set; }
}
