using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage07;

namespace WindBarrierReinforcement.StaticModel
{
    public static class GlobalPage07
    {
        private static DataModel_StraightBars dataModel_StraightBars_Dir1;
        public static DataModel_StraightBars DataModel_StraightBars_Dir1 => dataModel_StraightBars_Dir1 ?? (dataModel_StraightBars_Dir1 = new DataModel_StraightBars());

        private static DataModel_StraightBars dataModel_StraightBars_Dir2;
        public static DataModel_StraightBars DataModel_StraightBars_Dir2 => dataModel_StraightBars_Dir2 ?? (dataModel_StraightBars_Dir2 = new DataModel_StraightBars());

        private static DataModel_RadialEdgeConcrete dataModel_RadialEdgeConcrete;
        public static DataModel_RadialEdgeConcrete DataModel_RadialEdgeConcrete => dataModel_RadialEdgeConcrete ?? (dataModel_RadialEdgeConcrete = new DataModel_RadialEdgeConcrete());

        private static DataModel_CircularBarsTop dataModel_CircularBarsTop;
        public static DataModel_CircularBarsTop DataModel_CircularBarsTop => dataModel_CircularBarsTop ?? (dataModel_CircularBarsTop = new DataModel_CircularBarsTop());

        private static DataModel_CircularBarsExteriorSide dataModel_CircularBarsExteriorSide;
        public static DataModel_CircularBarsExteriorSide DataModel_CircularBarsExteriorSide 
            => dataModel_CircularBarsExteriorSide ?? (dataModel_CircularBarsExteriorSide = new DataModel_CircularBarsExteriorSide());

        private static DataModel_StraightBars_Extra dataModel_StraightBars_Extra;
        public static DataModel_StraightBars_Extra DataModel_StraightBars_Extra => dataModel_StraightBars_Extra ?? (dataModel_StraightBars_Extra = new DataModel_StraightBars_Extra());
    }
}
