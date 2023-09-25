using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class SftpDataSubmissionType
{
    public int DataSubmissionTypeId { get; set; }

    public string? DataSubmissionTypeName { get; set; }

    public string? TemplateFilePath { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<SftpDataSubmission> SftpDataSubmissions { get; } = new List<SftpDataSubmission>();

    public virtual ICollection<SftpMapDataSubmitterDataSubmissionType> SftpMapDataSubmitterDataSubmissionTypes { get; } = new List<SftpMapDataSubmitterDataSubmissionType>();
}
