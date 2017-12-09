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

        private static DataModel_CHR_Zone dataModel_CHR_Z1;
        public static DataModel_CHR_Zone DataModel_CHR_Z1 => dataModel_CHR_Z1 ?? (dataModel_CHR_Z1 = new DataModel_CHR_Zone());

        private static DataModel_CHR_Zone dataModel_CHR_Z2;
        public static DataModel_CHR_Zone DataModel_CHR_Z2 => dataModel_CHR_Z2 ?? (dataModel_CHR_Z2 = new DataModel_CHR_Zone());
    }
}
