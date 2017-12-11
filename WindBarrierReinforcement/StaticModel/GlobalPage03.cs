using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPAge03;

namespace WindBarrierReinforcement.StaticModel
{
    public interface IGlobalPage03
    {
        DataModel_ScrewPiles DataModel_ScrewPile { get; }
    }
    public partial class Global {
        private class _GlobalPage03 : IGlobalPage03
        {
            private DataModel_ScrewPiles dataModel_ScrewPile;
            public DataModel_ScrewPiles DataModel_ScrewPile => dataModel_ScrewPile ?? (dataModel_ScrewPile = new DataModel_ScrewPiles());
        }
    }
   
}
