using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBR_Common.Common.Attributes;
using WBR_Common.DataModels.NSPage09;
using WBR_Common.Writer;

namespace WBR_Common.StaticModel
{
    public interface IGlobalDataModelsPage09
    {
        DataModelUBABCollection DataModelUBABCollection { get; }
    }
    public partial class GlobalDataModels
    {
        private class _GlobalDataModelsPage09 : IGlobalDataModelsPage09
        {
            [SaveKeyCode(KeyCode = "DataModelUBABCollection", SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "", AddNavKey = false)]
            public DataModelUBABCollection DataModelUBABCollection { get; private set; }

            public _GlobalDataModelsPage09(GlobalDataModels global)
            {
                DataModelUBABCollection = new DataModelUBABCollection(global);
            }
        }
    }
}
