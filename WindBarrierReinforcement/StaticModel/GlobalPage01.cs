using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage01;

namespace WindBarrierReinforcement.StaticModel
{
    public interface IGlobalPage01
    {
        DataModel_Global_Formwork DataModel_Global_Formwork { get; }
        DataModel_Global_Coordinations_GroundPoint DataModel_Global_Coordinations_GroundPoint { get; }
        DataModel_Global_Materials DataModel_Global_Materials { get; }
    }

    public partial class Global
    {
        private class _GlobalPage01 : IGlobalPage01
        {

            public DataModel_Global_Formwork DataModel_Global_Formwork { get; private set; }

            public DataModel_Global_Coordinations_GroundPoint DataModel_Global_Coordinations_GroundPoint{ get; private set; }

            public DataModel_Global_Materials DataModel_Global_Materials { get; private set; }

            public _GlobalPage01(EvtHandler evtHandler)
            {
                DataModel_Global_Formwork = new DataModel_Global_Formwork(evtHandler);
                DataModel_Global_Coordinations_GroundPoint = new DataModel_Global_Coordinations_GroundPoint(evtHandler);
                DataModel_Global_Materials = new DataModel_Global_Materials(evtHandler);
            }
        }
    }
}
