using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage04;
using WindBarrierReinforcement.Writer;

namespace WindBarrierReinforcement.StaticModel
{
    public interface IGlobalDataModelsPage04
    {
        DataModelCircularGeneral DataModelCircularGeneral { get; }
        DataModelRadial1 DataModelRadial1 { get; }
        DataModelRadial2 DataModelRadial2 { get; }
        DataModelRadialGeneral DataModelRadialGeneral { get; }
        DataModelCircular_ZoneCollection DataModelCircular_ZoneCollection { get; }
    }

    public partial class GlobalDataModels {
        private class _GlobalDataModelsPage04:IGlobalDataModelsPage04
        {
            [SaveKeyCode(KeyCode = "DataModelCircularGeneral", SaveDataType = SaveDataType.Class)]
            public DataModelCircularGeneral DataModelCircularGeneral { get; private set; }

            [SaveKeyCode(KeyCode = "DataModelRadial1", SaveDataType = SaveDataType.Class)]
            public DataModelRadial1 DataModelRadial1 { get; private set; }

            [SaveKeyCode(KeyCode = "DataModelRadial2", SaveDataType = SaveDataType.Class)]
            public DataModelRadial2 DataModelRadial2 { get; private set; }

            [SaveKeyCode(KeyCode = "DataModelRadialGeneral", SaveDataType = SaveDataType.Class)]
            public DataModelRadialGeneral DataModelRadialGeneral { get;private set; }

            [SaveKeyCode(KeyCode = "DataModelCircular_ZoneCollection", SaveDataType = SaveDataType.Class)]
            public DataModelCircular_ZoneCollection DataModelCircular_ZoneCollection { get; private set; }

            public _GlobalDataModelsPage04(GlobalDataModels global)
            {
                DataModelCircularGeneral = new DataModelCircularGeneral(global);
                DataModelRadial1 = new DataModelRadial1(global);
                DataModelRadial2 = new DataModelRadial2(global);
                DataModelRadialGeneral = new DataModelRadialGeneral(global);
                DataModelCircular_ZoneCollection = new DataModelCircular_ZoneCollection(global);
            }
        }
    }
}
