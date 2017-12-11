using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage05;

namespace WindBarrierReinforcement.StaticModel
{
    public interface IGlobalDataModelsPage05
    {
        DataModel_Top_Reinforcement DataModel_Top_Reinforcement1 { get; }
        DataModel_Top_Reinforcement DataModel_Top_Reinforcement2 { get; }
    }
    public partial class GlobalDataModels {
        private class _GlobalDataModelsPage05 : IGlobalDataModelsPage05
        {
            public DataModel_Top_Reinforcement DataModel_Top_Reinforcement1 { get; private set; }

            public DataModel_Top_Reinforcement DataModel_Top_Reinforcement2 { get; private set; }

            public _GlobalDataModelsPage05(GlobalDataModels global)
            {
                DataModel_Top_Reinforcement1 = new DataModel_Top_Reinforcement();
                DataModel_Top_Reinforcement2 = new DataModel_Top_Reinforcement();
            }
        }
    }
    
}
