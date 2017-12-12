using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage04;

namespace WindBarrierReinforcement.StaticModel
{
    public interface IGlobalDataModelsPage04
    {
        DataModelCircularGeneral DataModelCircularGeneral { get; }
        DataModelRadial1 DataModelRadial1 { get; }
        DataModelRadial2 DataModelRadial2 { get; }
        DataModelRadialGeneral DataModelRadialGeneral { get; }
    }
    public partial class GlobalDataModels {
        private class _GlobalDataModelsPage04:IGlobalDataModelsPage04
        {
            public DataModelCircularGeneral DataModelCircularGeneral { get; private set; }

            public DataModelRadial1 DataModelRadial1 { get; private set; }

            public DataModelRadial2 DataModelRadial2 { get; private set; }

            public DataModelRadialGeneral DataModelRadialGeneral { get;private set; }

            public _GlobalDataModelsPage04(GlobalDataModels global)
            {
                DataModelCircularGeneral = new DataModelCircularGeneral();
                DataModelRadial1 = new DataModelRadial1(global);
                DataModelRadial2 = new DataModelRadial2(global);
                DataModelRadialGeneral = new DataModelRadialGeneral(global);
            }
        }
    }
}
