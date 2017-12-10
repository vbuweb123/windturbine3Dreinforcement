using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPAge03;

namespace WindBarrierReinforcement.StaticModel
{
    public static class GlobalPage03
    {
        private static DataModel_ScrewPiles dataModel_ScrewPile;
        public static DataModel_ScrewPiles DataModel_ScrewPile => dataModel_ScrewPile ?? (dataModel_ScrewPile = new DataModel_ScrewPiles());
    }
}
