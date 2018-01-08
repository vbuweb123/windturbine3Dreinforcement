using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBR_Common.Common.Attributes;
using WBR_Common.DataModels.NSPage06;
using WBR_Common.Writer;

namespace WBR_Common.StaticModel
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
            [SaveKeyCode(KeyCode = "DataModel_BR_D1", SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "BR_D1", AddNavKey = true)]
            public DataModel_BR_D1 DataModel_BR_D1 { get; private set; }

            [SaveKeyCode(KeyCode = "DataModel_BR_D2", SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "BR_D2", AddNavKey = true)]
            public DataModel_BR_D2 DataModel_BR_D2 { get; private set; }

            [SaveKeyCode(KeyCode = "DataModel_BR_L", SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "BR_L", AddNavKey = true)]
            public DataModel_BR_L DataModel_BR_L { get; private set; }

            [SaveKeyCode(KeyCode = "DataModel_TB_D1" , SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "TB_D1", AddNavKey = true)]
            public DataModel_TB_D1 DataModel_TB_D1 { get; private set; }

            [SaveKeyCode(KeyCode = "DataModel_TB_D2", SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "TB_D2", AddNavKey = true)]
            public DataModel_TB_D2 DataModel_TB_D2 { get; private set; }

            [SaveKeyCode(KeyCode = "DataModel_Circular_EdgeOfL", SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "EdgeOfL", AddNavKey = true)]
            public DataModel_Circular_EdgeOfL DataModel_Circular_EdgeOfL { get; private set; }

            [SaveKeyCode(KeyCode = "DataModel_Generalities", SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "General", AddNavKey = true)]
            public DataModel_Generalities DataModel_Generalities { get; private set; }

            public _GlobalDataModelsPage06(GlobalDataModels global)
            {
                DataModel_BR_D1 = new DataModel_BR_D1(global);
                DataModel_BR_D2 = new DataModel_BR_D2(global);
                DataModel_BR_L = new DataModel_BR_L(global);
                DataModel_TB_D1 = new DataModel_TB_D1(global);
                DataModel_TB_D2 = new DataModel_TB_D2(global);
                DataModel_Circular_EdgeOfL = new DataModel_Circular_EdgeOfL(global);
                DataModel_Generalities = new DataModel_Generalities();
            }
        }
    }
   
}
