using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.Attributes;
using WindBarrierReinforcement.DataModels.NSPage09;
using WindBarrierReinforcement.Writer;

namespace WindBarrierReinforcement.StaticModel
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
            public DataModelUBABCollection DataModelUBABCollection { get; private set; }

            public _GlobalDataModelsPage09(GlobalDataModels global)
            {
                DataModelUBABCollection = new DataModelUBABCollection(global);
            }
        }
    }
}
