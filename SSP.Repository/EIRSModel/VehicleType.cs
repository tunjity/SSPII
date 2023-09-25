using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class VehicleType
{
    public int VehicleTypeId { get; set; }

    public string? VehicleTypeName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<VehicleSubType> VehicleSubTypes { get; } = new List<VehicleSubType>();

    public virtual ICollection<Vehicle> Vehicles { get; } = new List<Vehicle>();
}
