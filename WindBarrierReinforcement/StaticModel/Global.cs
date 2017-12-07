using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WindBarrierReinforcement.DataModels.NSPage01;
using WindBarrierReinforcement.DataModels.NSPage02;
using WindBarrierReinforcement.DataModels.NSPage08;

namespace WindBarrierReinforcement.StaticModel
{
    public static class GlobalDataModelsPage08
    {
        public static DataModel_ARExtUBars DataModel_ARExtUBars { get; set; }
        public static DataModel_ARExteriorCircularTop DataModel_ARExteriorCircularTop { get; set; }
        public static DataModel_ARExteriorCircularLateral DataModel_ARExteriorCircularLateral { get; set; }
        public static DataModel_ARExteriorCircularBottom DataModel_ARExteriorCircularBottom { get; set; }
        public static DataModel_ARIntUBars DataModel_ARIntUBars { get; set; }
        public static DataModel_ARIntCircularTop DataModel_ARIntCircularTop { get; set; }
        public static DataModel_ARIntCircularBottom DataModel_ARIntCircularBottom { get; set; }
        public static DataModel_ARIntCircularLateral DataModel_ARIntCircularLateral { get; set; }

        static GlobalDataModelsPage08() {
            DataModel_ARExtUBars = new DataModel_ARExtUBars();
            DataModel_ARExteriorCircularTop = new DataModel_ARExteriorCircularTop();
            DataModel_ARExteriorCircularLateral = new DataModel_ARExteriorCircularLateral();
            DataModel_ARExteriorCircularBottom = new DataModel_ARExteriorCircularBottom();
            DataModel_ARIntUBars = new DataModel_ARIntUBars();
            DataModel_ARIntCircularTop = new DataModel_ARIntCircularTop();
            DataModel_ARIntCircularBottom = new DataModel_ARIntCircularBottom();
            DataModel_ARIntCircularLateral = new DataModel_ARIntCircularLateral();
        }
    }

    public static class Global
    {
        //Page 01
        public static DataModel_Global_Formwork DataModel_Global_Formwork { get; set; }
        public static DataModel_Global_Coordinations_GroundPoint DataModel_Global_Coordinations_GroundPoint { get; set; }
        public static DataModel_Global_Materials DataModel_Global_Materials { get; set; }
        //Page 02
        public static DataModel_Anchor DataModel_Anchor { get; set; }
        //Page 08
       
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
