using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.Attributes;

namespace WindBarrierReinforcement.Common.Eng
{
    public enum EHookTypes
    {
        [DisplayByResourceKey(ResourceKey = "HookType_A")]
        A,
        [DisplayByResourceKey(ResourceKey = "HookType_B")]
        B,
        [DisplayByResourceKey(ResourceKey = "HookType_C")]
        C
    }
}
