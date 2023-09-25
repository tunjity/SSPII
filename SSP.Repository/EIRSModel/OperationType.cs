using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class OperationType
{
    public int OperationTypesId { get; set; }

    public string? OperationTypesName { get; set; }

    public bool? Active { get; set; }
}
