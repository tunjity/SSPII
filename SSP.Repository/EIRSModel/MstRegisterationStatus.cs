using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class MstRegisterationStatus
{
    public int RegisterationStatusId { get; set; }

    public string? RegisterationStatusName { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public virtual ICollection<Company> Companies { get; } = new List<Company>();

    public virtual ICollection<Government> Governments { get; } = new List<Government>();

    public virtual ICollection<Individual> Individuals { get; } = new List<Individual>();
}
