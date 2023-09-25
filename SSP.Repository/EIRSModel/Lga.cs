using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class Lga
{
    public int Lgaid { get; set; }

    public string? Lganame { get; set; }

    public int? LgaclassId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Building> Buildings { get; } = new List<Building>();

    public virtual ICollection<Business> Businesses { get; } = new List<Business>();

    public virtual ICollection<Land> Lands { get; } = new List<Land>();

    public virtual Lgaclass? Lgaclass { get; set; }

    public virtual ICollection<Town> Towns { get; } = new List<Town>();

    public virtual ICollection<Vehicle> Vehicles { get; } = new List<Vehicle>();

    public virtual ICollection<Ward> Wards { get; } = new List<Ward>();
}
