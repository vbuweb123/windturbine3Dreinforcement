﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.Attributes;

namespace WindBarrierReinforcement.Common.Eng
{
    public enum EConsistenceTolerance
    {
        [DisplayByResourceKey(ResourceKey = "ConsistenceTolerance_S1")]
        S1,
        [DisplayByResourceKey(ResourceKey = "ConsistenceTolerance_S2")]
        S2,
        [DisplayByResourceKey(ResourceKey = "ConsistenceTolerance_S3")]
        S3,
        [DisplayByResourceKey(ResourceKey = "ConsistenceTolerance_S4")]
        S4
    }
}
