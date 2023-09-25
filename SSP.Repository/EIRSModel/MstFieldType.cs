using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class MstFieldType
{
    public int FieldTypeId { get; set; }

    public string? FieldTypeName { get; set; }

    public virtual ICollection<MapCertificateTypeField> MapCertificateTypeFields { get; } = new List<MapCertificateTypeField>();
}
