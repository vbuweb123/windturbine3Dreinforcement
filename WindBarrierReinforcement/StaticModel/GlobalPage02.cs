using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage02;

namespace WindBarrierReinforcement.StaticModel
{
    public static class GlobalPage02
    {
        private static DataModel_Anchor dataModel_Anchor;
        public static DataModel_Anchor DataModel_Anchor => dataModel_Anchor ?? (dataModel_Anchor = new DataModel_Anchor());
    }
}
