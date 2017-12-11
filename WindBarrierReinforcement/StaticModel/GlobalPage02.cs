using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage02;

namespace WindBarrierReinforcement.StaticModel
{
    public interface IGlobalPage02
    {
        DataModel_Anchor DataModel_Anchor { get; }
    }
    public partial class Global {
        private class _GlobalPage02 : IGlobalPage02
        {
            private DataModel_Anchor dataModel_Anchor;
            public DataModel_Anchor DataModel_Anchor => dataModel_Anchor ?? (dataModel_Anchor = new DataModel_Anchor());
        }
    }
}
