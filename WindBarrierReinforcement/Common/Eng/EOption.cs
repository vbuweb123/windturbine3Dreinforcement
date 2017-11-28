using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.Attributes;

namespace WindBarrierReinforcement.Common.Eng
{
    public enum EOption
    {
        [DisplayByResourceKey(ResourceKey = "EOption_NoOfBars")]
        NoOfBars,
        [DisplayByResourceKey(ResourceKey = "EOption_Spacing")]
        Spacing
    };
  


}
