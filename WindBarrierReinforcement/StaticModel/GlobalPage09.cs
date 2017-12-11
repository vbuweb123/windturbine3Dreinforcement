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
            private DataModelUBABCollection dataModelUBABCollection;
            public DataModelUBABCollection DataModelUBABCollection => dataModelUBABCollection ?? (dataModelUBABCollection = new DataModelUBABCollection());
        }
    }
}
