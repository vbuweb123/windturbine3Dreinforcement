using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBR_Common.Common.Attributes;

namespace WBR_Common.Common.Eng
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
        XD3,
        [DisplayByResourceKey(ResourceKey = "ExposureClass_XS1")]
        XS1,
        [DisplayByResourceKey(ResourceKey = "ExposureClass_XS2")]
        XS2,
        [DisplayByResourceKey(ResourceKey = "ExposureClass_XS3")]
        XS3,
        [DisplayByResourceKey(ResourceKey = "ExposureClass_XF1")]
        XF1,
        [DisplayByResourceKey(ResourceKey = "ExposureClass_XF2")]
        XF2,
        [DisplayByResourceKey(ResourceKey = "ExposureClass_XF3")]
        XF3,
        [DisplayByResourceKey(ResourceKey = "ExposureClass_XF4")]
        XF4,
        [DisplayByResourceKey(ResourceKey = "ExposureClass_XA1")]
        XA1,
        [DisplayByResourceKey(ResourceKey = "ExposureClass_XA2")]
        XA2,
        [DisplayByResourceKey(ResourceKey = "ExposureClass_XA3")]
        XA3
    }
}
