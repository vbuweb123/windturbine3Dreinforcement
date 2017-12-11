using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage06;

namespace WindBarrierReinforcement.StaticModel
{
    public static class GlobalPage06
    {
        private static DataModel_BR_D1 dataModel_BR_D1;
        public static DataModel_BR_D1 DataModel_BR_D1 => dataModel_BR_D1 ?? (dataModel_BR_D1 = new DataModel_BR_D1());

        private static DataModel_BR_D2 dataModel_BR_D2;
        public static DataModel_BR_D2 DataModel_BR_D2 => dataModel_BR_D2 ?? (dataModel_BR_D2 = new DataModel_BR_D2());

        private static DataModel_BR_L dataModel_BR_L;
        public static DataModel_BR_L DataModel_BR_L => dataModel_BR_L ?? (dataModel_BR_L = new DataModel_BR_L());

        private static DataModel_TB_D1 dataModel_TB_D1;
        public static DataModel_TB_D1 DataModel_TB_D1 => dataModel_TB_D1 ?? (dataModel_TB_D1 = new DataModel_TB_D1());

        private static DataModel_TB_D2 dataModel_TB_D2;
        public static DataModel_TB_D2 DataModel_TB_D2 => dataModel_TB_D2 ?? (dataModel_TB_D2 = new DataModel_TB_D2());

        private static DataModel_Circular_EdgeOfL dataModel_Circular_EdgeOfL;
        public static DataModel_Circular_EdgeOfL DataModel_Circular_EdgeOfL => dataModel_Circular_EdgeOfL ?? (dataModel_Circular_EdgeOfL = new DataModel_Circular_EdgeOfL());

        private static DataModel_Generalities dataModel_Generalities;
        public static DataModel_Generalities DataModel_Generalities => dataModel_Generalities ?? (dataModel_Generalities = new DataModel_Generalities());
    }
}
