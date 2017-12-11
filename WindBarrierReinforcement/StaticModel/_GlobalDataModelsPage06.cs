using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage06;

namespace WindBarrierReinforcement.StaticModel
{
    public interface IGlobalDataModelsPage06
    {
        DataModel_BR_D1 DataModel_BR_D1 { get; }
        DataModel_BR_D2 DataModel_BR_D2 { get; }
        DataModel_BR_L DataModel_BR_L { get; }
        DataModel_TB_D1 DataModel_TB_D1 { get; }
        DataModel_TB_D2 DataModel_TB_D2 { get; }
        DataModel_Circular_EdgeOfL DataModel_Circular_EdgeOfL { get; }
        DataModel_Generalities DataModel_Generalities { get; }
    }
    public partial class GlobalDataModels
    {
        private class _GlobalDataModelsPage06 : IGlobalDataModelsPage06
        {
            public DataModel_BR_D1 DataModel_BR_D1 { get; private set; }

            public DataModel_BR_D2 DataModel_BR_D2 { get; private set; }

            public DataModel_BR_L DataModel_BR_L { get; private set; }

            public DataModel_TB_D1 DataModel_TB_D1 { get; private set; }

            public DataModel_TB_D2 DataModel_TB_D2 { get; private set; }

            public DataModel_Circular_EdgeOfL DataModel_Circular_EdgeOfL { get; private set; }

            public DataModel_Generalities DataModel_Generalities { get; private set; }

            public _GlobalDataModelsPage06(GlobalDataModels global)
            {
                DataModel_BR_D1 = new DataModel_BR_D1();
                DataModel_BR_D2 = new DataModel_BR_D2();
                DataModel_BR_L = new DataModel_BR_L();
                DataModel_TB_D1 = new DataModel_TB_D1();
                DataModel_TB_D2 = new DataModel_TB_D2();
                DataModel_Circular_EdgeOfL = new DataModel_Circular_EdgeOfL();
                DataModel_Generalities = new DataModel_Generalities();
            }
        }
    }
   
}
