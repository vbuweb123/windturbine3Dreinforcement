using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WindBarrierReinforcement.DataModels.NSPage01;
using WindBarrierReinforcement.DataModels.NSPage02;

namespace WindBarrierReinforcement.StaticModel
{
    public static class Global
    {
        //Page 01
        public static DataModel_Global_Formwork DataModel_Global_Formwork { get; set; }
        public static DataModel_Global_Coordinations_GroundPoint DataModel_Global_Coordinations_GroundPoint { get; set; }
        public static DataModel_Global_Materials DataModel_Global_Materials { get; set; }
        //Page 02
        public static DataModel_Anchor DataModel_Anchor { get; set; }

        static Global()
        {
            Page01DM_CTOR();
            Page02DM_CTOR();
        }
        private static void Page01DM_CTOR()
        {
            DataModel_Global_Formwork = new DataModel_Global_Formwork();

            DataModel_Global_Coordinations_GroundPoint = new DataModel_Global_Coordinations_GroundPoint();

            DataModel_Global_Materials = new DataModel_Global_Materials();
        }
        private static void Page02DM_CTOR()
        {
            //Page 02
            DataModel_Anchor = new DataModel_Anchor();
        }
    }
}
