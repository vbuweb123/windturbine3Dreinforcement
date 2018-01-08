using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBR_Common.Common.Attributes;

namespace WBR_Common.Common.Eng
{
    public enum EOptionsCBES
    {
        //Name of Enum Values Hardcoded in Page07.xaml as part of style triggers.
        [DisplayByResourceKey(ResourceKey = "EOption_NoOfBars_Spacing")]
        NoOfBars_Spacing,
        [DisplayByResourceKey(ResourceKey = "EOption_Spacing_Length")]
        Spacing_Length,
        [DisplayByResourceKey(ResourceKey = "EOption_NoOfBars_Length")]
        NoOfBars_Length
    }

}
