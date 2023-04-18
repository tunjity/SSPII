using System;
using System.Collections.Generic;

namespace SSP.Payee;

public partial class AssessmentItemSubCategory
{
    public int ItemCategoryId { get; set; }

    public int? ItemCategoryCreateBy { get; set; }

    public DateTime? ItemCategoryCreateAt { get; set; }

    public int? ItemCategory { get; set; }

    public string? ItemSubCategory { get; set; }

    public string? ItemCategoryStatus { get; set; }
}
