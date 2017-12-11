using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage09;

namespace WindBarrierReinforcement.StaticModel
{
    public interface IGlobalPage09
    {
        DataModelUBABCollection DataModelUBABCollection { get; }
    }
    public partial class Global
    {
        private class _GlobalPage09 : IGlobalPage09
        {
            public DataModelUBABCollection DataModelUBABCollection { get; private set; }

            public _GlobalPage09(EvtHandler eventHandler)
            {
                DataModelUBABCollection = new DataModelUBABCollection(eventHandler);
            }
        }
    }
}
