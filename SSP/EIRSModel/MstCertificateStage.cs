﻿using System;
using System.Collections.Generic;

namespace SSP.EIRSModel;

public partial class MstCertificateStage
{
    public int CertificateStageId { get; set; }

    public string? CertificateStageName { get; set; }

    public string? ControllerName { get; set; }

    public string? ActionName { get; set; }
}
