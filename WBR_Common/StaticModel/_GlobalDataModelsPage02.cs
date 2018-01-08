using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBR_Common.Common.Attributes;
using WBR_Common.DataModels.NSPage02;
using WBR_Common.Writer;

namespace WBR_Common.StaticModel
{
    public interface IGlobalDataModelsPage02
    {
        DataModel_Anchor DataModel_Anchor { get; }
    }
    public partial class GlobalDataModels {

        private class _GlobalDataModelsPage02 : IGlobalDataModelsPage02
        {
            [SaveKeyCode(KeyCode = "DataModel_Anchor", SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "", AddNavKey = false)]
            public DataModel_Anchor DataModel_Anchor { get; private set; }

            public _GlobalDataModelsPage02(GlobalDataModels global)
            {
                DataModel_Anchor = new DataModel_Anchor(global);
            }
        }
    }
}
