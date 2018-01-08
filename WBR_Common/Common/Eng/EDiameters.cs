using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBR_Common.Common.Attributes;

namespace WBR_Common.Common.Eng
{
    public enum EDiameters
    {
        [DisplayByResourceKey(ResourceKey = "EDiameters_D6")]
        D6,
        [DisplayByResourceKey(ResourceKey = "EDiameters_D8")]
        D8,
        [DisplayByResourceKey(ResourceKey = "EDiameters_D10")]
        D10,
        [DisplayByResourceKey(ResourceKey = "EDiameters_D12")]
        D12,
        //[DisplayByResourceKey(ResourceKey = "EDiameters_D14")] -> not in table
        //D14,
        [DisplayByResourceKey(ResourceKey = "EDiameters_D16")]
        D16,
        [DisplayByResourceKey(ResourceKey = "EDiameters_D18")]
        D18,
        [DisplayByResourceKey(ResourceKey = "EDiameters_D20")]
        D20,
        [DisplayByResourceKey(ResourceKey = "EDiameters_D25")]
        D25,
        [DisplayByResourceKey(ResourceKey = "EDiameters_D32")]
        D32,
        [DisplayByResourceKey(ResourceKey = "EDiameters_D40")]
        D40,
        [DisplayByResourceKey(ResourceKey = "EDiameters_D50")]
        D50
    };
}
