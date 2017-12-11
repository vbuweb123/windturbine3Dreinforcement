using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage07;

namespace WindBarrierReinforcement.StaticModel
{
    public class GlobalPage07
    {
        private DataModel_StraightBars dataModel_StraightBars_Dir1;
        public DataModel_StraightBars DataModel_StraightBars_Dir1 => dataModel_StraightBars_Dir1 ?? (dataModel_StraightBars_Dir1 = new DataModel_StraightBars());

        private DataModel_StraightBars dataModel_StraightBars_Dir2;
        public DataModel_StraightBars DataModel_StraightBars_Dir2 => dataModel_StraightBars_Dir2 ?? (dataModel_StraightBars_Dir2 = new DataModel_StraightBars());

        private DataModel_RadialEdgeConcrete dataModel_RadialEdgeConcrete;
        public DataModel_RadialEdgeConcrete DataModel_RadialEdgeConcrete => dataModel_RadialEdgeConcrete ?? (dataModel_RadialEdgeConcrete = new DataModel_RadialEdgeConcrete());

        private DataModel_CircularBarsTop dataModel_CircularBarsTop;
        public DataModel_CircularBarsTop DataModel_CircularBarsTop => dataModel_CircularBarsTop ?? (dataModel_CircularBarsTop = new DataModel_CircularBarsTop());

        private DataModel_CircularBarsExteriorSide dataModel_CircularBarsExteriorSide;
        public DataModel_CircularBarsExteriorSide DataModel_CircularBarsExteriorSide 
            => dataModel_CircularBarsExteriorSide ?? (dataModel_CircularBarsExteriorSide = new DataModel_CircularBarsExteriorSide());

        private DataModel_StraightBars_Extra dataModel_StraightBars_Extra;
        public DataModel_StraightBars_Extra DataModel_StraightBars_Extra => dataModel_StraightBars_Extra ?? (dataModel_StraightBars_Extra = new DataModel_StraightBars_Extra());
    }
}
