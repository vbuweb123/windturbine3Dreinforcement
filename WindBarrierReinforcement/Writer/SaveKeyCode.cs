using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindBarrierReinforcement.Writer
{
    public class SaveKeyCodeAttribute : System.Attribute
    {
        public string KeyCode;
        public SaveDataType SaveDataType = SaveDataType.Default;
        public Type CollectionElementType;

        public SaveKeyCodeAttribute()
        {
        }
    }
}
