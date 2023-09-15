﻿using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class SftpDataSubmitter
{
    public int DataSubmitterId { get; set; }

    public string? Rin { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<SftpDataSubmission> SftpDataSubmissions { get; } = new List<SftpDataSubmission>();

    public virtual ICollection<SftpMapDataSubmitterDataSubmissionType> SftpMapDataSubmitterDataSubmissionTypes { get; } = new List<SftpMapDataSubmitterDataSubmissionType>();
}
