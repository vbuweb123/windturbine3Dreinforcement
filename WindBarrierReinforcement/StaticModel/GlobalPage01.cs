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
            private DataModel_Global_Formwork dataModel_Global_Formwork;
            public DataModel_Global_Formwork DataModel_Global_Formwork
                => dataModel_Global_Formwork ?? (dataModel_Global_Formwork = new DataModel_Global_Formwork());

            private DataModel_Global_Coordinations_GroundPoint dataModel_Global_Coordinations_GroundPoint;
            public DataModel_Global_Coordinations_GroundPoint DataModel_Global_Coordinations_GroundPoint
                => dataModel_Global_Coordinations_GroundPoint ?? (dataModel_Global_Coordinations_GroundPoint = new DataModel_Global_Coordinations_GroundPoint());

            private DataModel_Global_Materials dataModel_Global_Materials;
            public DataModel_Global_Materials DataModel_Global_Materials
                => dataModel_Global_Materials ?? (dataModel_Global_Materials = new DataModel_Global_Materials());
        }
    }
}
