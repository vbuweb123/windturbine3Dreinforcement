using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.Attributes;

namespace WindBarrierReinforcement.Common.Eng
{
    public enum EOptionsCBES
    {
        [DisplayByResourceKey(ResourceKey = "EOption_NoOfBars_Spacing")]
        NoOfBars_Spacing,
        [DisplayByResourceKey(ResourceKey = "EOption_Spacing_Length")]
        Spacing_Length,
        [DisplayByResourceKey(ResourceKey = "EOption_NoOfBars_Length")]
        NoOfBars_Length
    }

}
