using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage08;
using WindBarrierReinforcement.Writer;

namespace WindBarrierReinforcement.StaticModel
{
    public interface IGlobalDataModelsPage08
    {
        DataModel_ARExtUBars DataModel_ARExtUBars { get; }
        DataModel_ARExteriorCircularTop DataModel_ARExteriorCircularTop { get; }
        DataModel_ARExteriorCircularLateral DataModel_ARExteriorCircularLateral { get; }
        DataModel_ARExteriorCircularBottom DataModel_ARExteriorCircularBottom { get; }
        DataModel_ARIntUBars DataModel_ARIntUBars { get; }
        DataModel_ARIntCircularTop DataModel_ARIntCircularTop { get; }
        DataModel_ARIntCircularBottom DataModel_ARIntCircularBottom { get; }
        DataModel_ARIntCircularLateral DataModel_ARIntCircularLateral { get; }
    }
    public partial class GlobalDataModels
    {
        private class _GlobalDataModelsPage08 : IGlobalDataModelsPage08
        {
            [SaveKeyCode(KeyCode = "DataModel_ARExtUBars", SaveDataType = SaveDataType.Class)]
            public DataModel_ARExtUBars DataModel_ARExtUBars { get; private set; }

            [SaveKeyCode(KeyCode = "DataModel_ARExteriorCircularTop", SaveDataType = SaveDataType.Class)]
            public DataModel_ARExteriorCircularTop DataModel_ARExteriorCircularTop { get; private set; }

            [SaveKeyCode(KeyCode = "DataModel_ARExteriorCircularLateral", SaveDataType = SaveDataType.Class)]
            public DataModel_ARExteriorCircularLateral DataModel_ARExteriorCircularLateral { get; private set; }

            [SaveKeyCode(KeyCode = "DataModel_ARExteriorCircularBottom", SaveDataType = SaveDataType.Class)]
            public DataModel_ARExteriorCircularBottom DataModel_ARExteriorCircularBottom { get; private set; }

            [SaveKeyCode(KeyCode = "DataModel_ARIntUBars", SaveDataType = SaveDataType.Class)]
            public DataModel_ARIntUBars DataModel_ARIntUBars { get; private set; }

            [SaveKeyCode(KeyCode = "DataModel_ARIntCircularTop", SaveDataType = SaveDataType.Class)]
            public DataModel_ARIntCircularTop DataModel_ARIntCircularTop { get; private set; }

            [SaveKeyCode(KeyCode = "DataModel_ARIntCircularBottom", SaveDataType = SaveDataType.Class)]
            public DataModel_ARIntCircularBottom DataModel_ARIntCircularBottom { get; private set; }

            [SaveKeyCode(KeyCode = "DataModel_ARIntCircularLateral", SaveDataType = SaveDataType.Class)]
            public DataModel_ARIntCircularLateral DataModel_ARIntCircularLateral { get; private set; }

            public _GlobalDataModelsPage08(GlobalDataModels global)
            {
                DataModel_ARExtUBars = new DataModel_ARExtUBars(global);
                DataModel_ARExteriorCircularTop = new DataModel_ARExteriorCircularTop(global);
                DataModel_ARExteriorCircularLateral = new DataModel_ARExteriorCircularLateral(global);
                DataModel_ARExteriorCircularBottom = new DataModel_ARExteriorCircularBottom(global);
                DataModel_ARIntUBars = new DataModel_ARIntUBars(global);
                DataModel_ARIntCircularTop = new DataModel_ARIntCircularTop(global);
                DataModel_ARIntCircularBottom = new DataModel_ARIntCircularBottom(global);
                DataModel_ARIntCircularLateral = new DataModel_ARIntCircularLateral(global);
            }
        }
    }

}
