using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage01;

namespace WindBarrierReinforcement.StaticModel
{
    public interface IGlobalDataModelsPage01
    {
        DataModel_Global_Formwork DataModel_Global_Formwork { get; }
        DataModel_Global_Coordinations_GroundPoint DataModel_Global_Coordinations_GroundPoint { get; }
        DataModel_Global_Materials DataModel_Global_Materials { get; }
    }

    public partial class GlobalDataModels
    {
        private class _GlobalDataModelsPage01 : IGlobalDataModelsPage01
        {

            public DataModel_Global_Formwork DataModel_Global_Formwork { get; private set; }

            public DataModel_Global_Coordinations_GroundPoint DataModel_Global_Coordinations_GroundPoint{ get; private set; }

            public DataModel_Global_Materials DataModel_Global_Materials { get; private set; }

            public _GlobalDataModelsPage01(GlobalDataModels global)
            {
                DataModel_Global_Formwork = new DataModel_Global_Formwork(global);
                DataModel_Global_Coordinations_GroundPoint = new DataModel_Global_Coordinations_GroundPoint(global);
                DataModel_Global_Materials = new DataModel_Global_Materials();
            }
        }
    }
}
