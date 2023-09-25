﻿using System;
using System.Collections.Generic;

namespace SSP.Repository.Payee;

public partial class BusinessesApiMain
{
    public long Id { get; set; }

    public long BusinessId { get; set; }

    public string BusinessRin { get; set; } = null!;

    public int AssetTypeId { get; set; }

    public string AssetTypeName { get; set; } = null!;

    public int BusinessTypeId { get; set; }

    public string BusinessTypeName { get; set; } = null!;

    public string BusinessName { get; set; } = null!;

    public int Lgaid { get; set; }

    public string Lganame { get; set; } = null!;

    public int BusinessCategoryId { get; set; }

    public string BusinessCategoryName { get; set; } = null!;

    public int BusinessSectorId { get; set; }

    public string BusinessSectorName { get; set; } = null!;

    public int BusinessSubSectorId { get; set; }

    public string BusinessSubSectorName { get; set; } = null!;

    public int BusinessStructureId { get; set; }

    public string BusinessStructureName { get; set; } = null!;

    public int BusinessOperationId { get; set; }

    public string BusinessOperationName { get; set; } = null!;

    public int SizeId { get; set; }

    public string SizeName { get; set; } = null!;

    public string? ContactName { get; set; }

    public string? BusinessNumber { get; set; }

    public string? BusinessAddress { get; set; }

    public int? ApiId { get; set; }

    public DateTime? DateCreated { get; set; }
}
