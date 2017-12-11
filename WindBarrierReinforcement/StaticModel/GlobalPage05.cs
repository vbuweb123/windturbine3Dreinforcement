using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage05;

namespace WindBarrierReinforcement.StaticModel
{
    public class GlobalPage05
    {
        private DataModel_Top_Reinforcement dataModel_Top_Reinforcement1;
        public DataModel_Top_Reinforcement DataModel_Top_Reinforcement1
            => dataModel_Top_Reinforcement1 ?? (dataModel_Top_Reinforcement1 = new DataModel_Top_Reinforcement());

        private DataModel_Top_Reinforcement dataModel_Top_Reinforcement2;
        public DataModel_Top_Reinforcement DataModel_Top_Reinforcement2
            => dataModel_Top_Reinforcement2 ?? (dataModel_Top_Reinforcement2 = new DataModel_Top_Reinforcement());

    }
}
