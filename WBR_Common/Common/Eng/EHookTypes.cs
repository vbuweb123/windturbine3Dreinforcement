using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBR_Common.Common.Attributes;

namespace WBR_Common.Common.Eng
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
