using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage09;

namespace WindBarrierReinforcement.StaticModel
{
    public static class GlobalPage09
    {
        private static DataModelUBABCollection dataModelUBABCollection;
        public static DataModelUBABCollection DataModelUBABCollection => dataModelUBABCollection ?? (dataModelUBABCollection = new DataModelUBABCollection());
    }
}
