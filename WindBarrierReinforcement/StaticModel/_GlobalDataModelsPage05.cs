using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage05;

namespace WindBarrierReinforcement.StaticModel
{
    public interface IGlobalDataModelsPage05
    {
        DataModelCircularGeneral DataModelCircularGeneral { get; }
        DataModelRadial1 DataModelRadial1 { get; }
        DataModelRadial2 DataModelRadial2 { get; }
        DataModelRadialGeneral DataModelRadialGeneral { get; }
        DataModelCircular_ZoneCollection DataModelCircular_ZoneCollection { get; }
    }
    public partial class GlobalDataModels {
        private class _GlobalDataModelsPage05 : IGlobalDataModelsPage05
        {
            public DataModelCircularGeneral DataModelCircularGeneral { get; private set; }

            public DataModelRadial1 DataModelRadial1 { get; private set; }

            public DataModelRadial2 DataModelRadial2 { get; private set; }

            public DataModelRadialGeneral DataModelRadialGeneral { get; private set; }

            public DataModelCircular_ZoneCollection DataModelCircular_ZoneCollection { get; private set; }

            public _GlobalDataModelsPage05(GlobalDataModels global)
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
