﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage10;
using WindBarrierReinforcement.Writer;

namespace WindBarrierReinforcement.StaticModel
{
    public interface IGlobalDataModelsPage10
    {
        DataModel_CHR_General DataModel_CHR_General { get; }
        DataModel_CHR_Zones DataModel_CHR_Zones { get; }
    }
    public partial class GlobalDataModels
    {
        private class _GlobalDataModelsPage10 : IGlobalDataModelsPage10
        {
            [SaveKeyCode(KeyCode = "DataModel_CHR_General", SaveDataType = SaveDataType.Class)]
            public DataModel_CHR_General DataModel_CHR_General { get; private set; }

            [SaveKeyCode(KeyCode = "DataModel_CHR_Zones", SaveDataType = SaveDataType.Class)]
            public DataModel_CHR_Zones DataModel_CHR_Zones { get; private set; }

            public _GlobalDataModelsPage10(GlobalDataModels global)
            {
                DataModel_CHR_General = new DataModel_CHR_General(global);
                DataModel_CHR_Zones  = new DataModel_CHR_Zones(global);
            }
        }
    }
}
