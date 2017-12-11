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
            public DataModel_CHR_General DataModel_CHR_General { get; private set; }

            public DataModel_CHR_Zones DataModel_CHR_Zones { get; private set; }

            public _GlobalPage10(EvtHandler eventHandler)
            {
                DataModel_CHR_General = new DataModel_CHR_General(eventHandler);
                DataModel_CHR_Zones  = new DataModel_CHR_Zones(eventHandler);
            }
        }
    }
}
