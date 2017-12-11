using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage09;

namespace WindBarrierReinforcement.StaticModel
{
    public class GlobalPage09
    {
        private DataModelUBABCollection dataModelUBABCollection;
        public DataModelUBABCollection DataModelUBABCollection => dataModelUBABCollection ?? (dataModelUBABCollection = new DataModelUBABCollection());
    }
}
