using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindBarrierReinforcement.Common.Attributes
{
    public class ValueAttribute : System.Attribute
    {
        public object Value { get; set; }
        public Type Type { get; set; }
    }
}
