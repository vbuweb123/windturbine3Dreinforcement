using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage06;

namespace WindBarrierReinforcement.StaticModel
{
    public interface IGlobalPage06
    {
        DataModel_BR_D1 DataModel_BR_D1 { get; }
        DataModel_BR_D2 DataModel_BR_D2 { get; }
        DataModel_BR_L DataModel_BR_L { get; }
        DataModel_TB_D1 DataModel_TB_D1 { get; }
        DataModel_TB_D2 DataModel_TB_D2 { get; }
        DataModel_Circular_EdgeOfL DataModel_Circular_EdgeOfL { get; }
        DataModel_Generalities DataModel_Generalities { get; }
    }
    public partial class Global
    {
        private class _GlobalPage06 : IGlobalPage06
        {
            private DataModel_BR_D1 dataModel_BR_D1;
            public DataModel_BR_D1 DataModel_BR_D1 => dataModel_BR_D1 ?? (dataModel_BR_D1 = new DataModel_BR_D1());

            private DataModel_BR_D2 dataModel_BR_D2;
            public DataModel_BR_D2 DataModel_BR_D2 => dataModel_BR_D2 ?? (dataModel_BR_D2 = new DataModel_BR_D2());

            private DataModel_BR_L dataModel_BR_L;
            public DataModel_BR_L DataModel_BR_L => dataModel_BR_L ?? (dataModel_BR_L = new DataModel_BR_L());

            private DataModel_TB_D1 dataModel_TB_D1;
            public DataModel_TB_D1 DataModel_TB_D1 => dataModel_TB_D1 ?? (dataModel_TB_D1 = new DataModel_TB_D1());

            private DataModel_TB_D2 dataModel_TB_D2;
            public DataModel_TB_D2 DataModel_TB_D2 => dataModel_TB_D2 ?? (dataModel_TB_D2 = new DataModel_TB_D2());

            private DataModel_Circular_EdgeOfL dataModel_Circular_EdgeOfL;
            public DataModel_Circular_EdgeOfL DataModel_Circular_EdgeOfL => dataModel_Circular_EdgeOfL ?? (dataModel_Circular_EdgeOfL = new DataModel_Circular_EdgeOfL());

            private DataModel_Generalities dataModel_Generalities;
            public DataModel_Generalities DataModel_Generalities => dataModel_Generalities ?? (dataModel_Generalities = new DataModel_Generalities());
        }
    }
   
}
