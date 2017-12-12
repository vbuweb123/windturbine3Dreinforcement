﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPAge03;

namespace WindBarrierReinforcement.StaticModel
{
    public interface IGlobalDataModelsPage03
    {
        DataModel_ScrewPiles DataModel_ScrewPile { get; }
    }
    public partial class GlobalDataModels {
        private class _GlobalDataModelsPage03 : IGlobalDataModelsPage03
        {
            public DataModel_ScrewPiles DataModel_ScrewPile { get; private set; }

            public _GlobalDataModelsPage03(GlobalDataModels global)
            {
                DataModel_ScrewPile = new DataModel_ScrewPiles(global);
            }
        }
    }
   
}
