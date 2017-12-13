using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindBarrierReinforcement.Common.Attributes
{
    class SaveKeyCodeAttribute : System.Attribute
    {
        public string KeyCode;

        public SaveKeyCodeAttribute()
        {
        }
    }
}
