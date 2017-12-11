using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.Attributes;

namespace WindBarrierReinforcement.Common.Eng
{
    public enum EExposureClass
    {
        [DisplayByResourceKey(ResourceKey = "ExposureClass_X0")]
        X0,
        [DisplayByResourceKey(ResourceKey = "ExposureClass_XC1")]
        XC1,
        [DisplayByResourceKey(ResourceKey = "ExposureClass_XC2")]
        XC2,
        [DisplayByResourceKey(ResourceKey = "ExposureClass_XC3")]
        XC3,
        [DisplayByResourceKey(ResourceKey = "ExposureClass_XC4")]
        XC4,
        [DisplayByResourceKey(ResourceKey = "ExposureClass_XD1")]
        XD1,
        [DisplayByResourceKey(ResourceKey = "ExposureClass_XD2")]
        XD2,
        [DisplayByResourceKey(ResourceKey = "ExposureClass_XD3")]
        XD3
    }
}
