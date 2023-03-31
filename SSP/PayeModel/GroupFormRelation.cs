using System;
using System.Collections.Generic;

namespace SSP.PayeModel;

public partial class GroupFormRelation
{
    public int GroupFormId { get; set; }

    public int GroupId { get; set; }

    public int FormId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }
}
