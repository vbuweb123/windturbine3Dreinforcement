using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage04;

namespace WindBarrierReinforcement.StaticModel
{
    public interface IGlobalPage04
    {
        DataModelCircularGeneral DataModelCircularGeneral { get; }
        DataModelRadial1 DataModelRadial1 { get; }
        DataModelRadial2 DataModelRadial2 { get; }
        DataModelRadialGeneral DataModelRadialGeneral { get; }
    }
    public partial class Global {
        private class _GlobalPage04:IGlobalPage04
        {
            public DataModelCircularGeneral DataModelCircularGeneral { get; private set; }

            public DataModelRadial1 DataModelRadial1 { get; private set; }

            public DataModelRadial2 DataModelRadial2 { get; private set; }

            public DataModelRadialGeneral DataModelRadialGeneral { get;private set; }

            public _GlobalPage04(EvtHandler evtHandler)
            {
                DataModelCircularGeneral = new DataModelCircularGeneral();
                DataModelRadial1 = new DataModelRadial1(evtHandler);
                DataModelRadial2 = new DataModelRadial2(evtHandler);
                DataModelRadialGeneral = new DataModelRadialGeneral(evtHandler);
            }
        }
    }
}
