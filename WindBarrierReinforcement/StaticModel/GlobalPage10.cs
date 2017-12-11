using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage10;

namespace WindBarrierReinforcement.StaticModel
{
    public interface IGlobalPage10
    {
        DataModel_CHR_General DataModel_CHR_General { get; }
        DataModel_CHR_Zones DataModel_CHR_Zones { get; }
    }
    public partial class Global
    {
        private class _GlobalPage10 : IGlobalPage10
        {
            private DataModel_CHR_General dataModel_CHR_General;
            public DataModel_CHR_General DataModel_CHR_General => dataModel_CHR_General ?? (dataModel_CHR_General = new DataModel_CHR_General());

            private DataModel_CHR_Zones dataModel_CHR_Zones;
            public DataModel_CHR_Zones DataModel_CHR_Zones => dataModel_CHR_Zones ?? (dataModel_CHR_Zones = new DataModel_CHR_Zones());
        }

    }
}
