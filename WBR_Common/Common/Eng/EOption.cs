using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBR_Common.Common.Attributes;

namespace WBR_Common.Common.Eng
{
    public enum EOption
    {
        [DisplayByResourceKey(ResourceKey = "EOption_NoOfBars")]
        NoOfBars,
        [DisplayByResourceKey(ResourceKey = "EOption_Spacing")]
        Spacing
    };
  }
