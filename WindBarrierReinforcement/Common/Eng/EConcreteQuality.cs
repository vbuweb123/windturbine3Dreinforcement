﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.Attributes;

namespace WindBarrierReinforcement.Common.Eng
{
    public enum  EConcreteQuality
    {
        [DisplayByResourceKey(ResourceKey = "Concrete_C35_37_GB")]
        C35_37_GB,
        [DisplayByResourceKey(ResourceKey = "Concrete_C45_55_GB")]
        C45_55_GB,
        [DisplayByResourceKey(ResourceKey = "Concrete_C12_15_OB")]
        C12_15_OB,
        [DisplayByResourceKey(ResourceKey = "Concrete_C_90_105_OB")]
        C_90_105_OB,
        [DisplayByResourceKey(ResourceKey = "Concrete_C_12_45_OB")]
        C_12_45_OB
    }
}
