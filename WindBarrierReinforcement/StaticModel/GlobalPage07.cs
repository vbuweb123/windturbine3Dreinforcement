using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage07;

namespace WindBarrierReinforcement.StaticModel
{
    public interface IGlobalPage07
    {
        DataModel_StraightBars DataModel_StraightBars_Dir1 { get; }
        DataModel_StraightBars DataModel_StraightBars_Dir2 { get; }
        DataModel_RadialEdgeConcrete DataModel_RadialEdgeConcrete { get; }
        DataModel_CircularBarsTop DataModel_CircularBarsTop { get; }
        DataModel_CircularBarsExteriorSide DataModel_CircularBarsExteriorSide { get; }
        DataModel_StraightBars_Extra DataModel_StraightBars_Extra { get; }
    }
    public partial class Global
    {
        private class _GlobalPage07 : IGlobalPage07
        {
            public DataModel_StraightBars DataModel_StraightBars_Dir1 { get; private set; }

            public DataModel_StraightBars DataModel_StraightBars_Dir2 { get; private set; }

            public DataModel_RadialEdgeConcrete DataModel_RadialEdgeConcrete { get; private set; }

            public DataModel_CircularBarsTop DataModel_CircularBarsTop { get; private set; }

            public DataModel_CircularBarsExteriorSide DataModel_CircularBarsExteriorSide { get; private set; }

            public DataModel_StraightBars_Extra DataModel_StraightBars_Extra { get; private set; }

            public _GlobalPage07(EvtHandler evtHandler)
            {
                DataModel_StraightBars_Dir1 = new DataModel_StraightBars();
                DataModel_StraightBars_Dir2 = new DataModel_StraightBars();
                DataModel_RadialEdgeConcrete = new DataModel_RadialEdgeConcrete();
                DataModel_CircularBarsTop = new DataModel_CircularBarsTop();
                DataModel_CircularBarsExteriorSide = new DataModel_CircularBarsExteriorSide();
                DataModel_StraightBars_Extra = new DataModel_StraightBars_Extra();
            }
        }
    }

}
