using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBR_Common.Common.Attributes
{
    public class DynNav : System.Attribute
    {
        public string Key { get; set; }
        public bool AddNavKey { get; set; }
    }
}
