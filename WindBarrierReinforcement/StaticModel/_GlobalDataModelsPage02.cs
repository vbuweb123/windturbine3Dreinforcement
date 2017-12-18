using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage02;
using WindBarrierReinforcement.Writer;

namespace WindBarrierReinforcement.StaticModel
{
    public interface IGlobalDataModelsPage02
    {
        DataModel_Anchor DataModel_Anchor { get; }
    }
    public partial class GlobalDataModels {

        private class _GlobalDataModelsPage02 : IGlobalDataModelsPage02
        {
            [SaveKeyCode(KeyCode = "DataModel_Anchor", SaveDataType = SaveDataType.Class)]
            public DataModel_Anchor DataModel_Anchor { get; private set; }

            public _GlobalDataModelsPage02(GlobalDataModels global)
            {
                DataModel_Anchor = new DataModel_Anchor(global);
            }
        }
    }
}
