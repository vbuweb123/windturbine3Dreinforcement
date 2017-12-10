using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage10;

namespace WindBarrierReinforcement.StaticModel
{
    public static class GlobalPage10
    {
        public static DataModel_CHR_General dataModel_CHR_General;
        public static DataModel_CHR_General DataModel_CHR_General => dataModel_CHR_General ?? (dataModel_CHR_General = new DataModel_CHR_General());

        private static DataModel_CHR_Zones dataModel_CHR_Zones;
        public static DataModel_CHR_Zones DataModel_CHR_Zones => dataModel_CHR_Zones ?? (dataModel_CHR_Zones = new DataModel_CHR_Zones());
    }
}
