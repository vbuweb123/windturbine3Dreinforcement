using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage08;

namespace WindBarrierReinforcement.StaticModel
{
    public static class GlobalPage08
    {
        private static DataModel_ARExtUBars dataModel_ARExtUBars;
        public static DataModel_ARExtUBars DataModel_ARExtUBars => dataModel_ARExtUBars ?? (dataModel_ARExtUBars = new DataModel_ARExtUBars());

        private static DataModel_ARExteriorCircularTop dataModel_ARExteriorCircularTop;
        public static DataModel_ARExteriorCircularTop DataModel_ARExteriorCircularTop => (dataModel_ARExteriorCircularTop = new DataModel_ARExteriorCircularTop());

        private static DataModel_ARExteriorCircularLateral dataModel_ARExteriorCircularLateral;
        public static DataModel_ARExteriorCircularLateral DataModel_ARExteriorCircularLateral 
            => dataModel_ARExteriorCircularLateral ?? (dataModel_ARExteriorCircularLateral = new DataModel_ARExteriorCircularLateral());

        private static DataModel_ARExteriorCircularBottom dataModel_ARExteriorCircularBottom;
        public static DataModel_ARExteriorCircularBottom DataModel_ARExteriorCircularBottom 
            => dataModel_ARExteriorCircularBottom ?? (dataModel_ARExteriorCircularBottom = new DataModel_ARExteriorCircularBottom());

        private static DataModel_ARIntUBars dataModel_ARIntUBars;
        public static DataModel_ARIntUBars DataModel_ARIntUBars => dataModel_ARIntUBars ?? (dataModel_ARIntUBars = new DataModel_ARIntUBars());

        private static DataModel_ARIntCircularTop dataModel_ARIntCircularTop;
        public static DataModel_ARIntCircularTop DataModel_ARIntCircularTop => dataModel_ARIntCircularTop ?? (dataModel_ARIntCircularTop = new DataModel_ARIntCircularTop());

        private static DataModel_ARIntCircularBottom dataModel_ARIntCircularBottom;
        public static DataModel_ARIntCircularBottom DataModel_ARIntCircularBottom => dataModel_ARIntCircularBottom ?? (dataModel_ARIntCircularBottom = new DataModel_ARIntCircularBottom());

        private static DataModel_ARIntCircularLateral dataModel_ARIntCircularLateral;
        public static DataModel_ARIntCircularLateral DataModel_ARIntCircularLateral => dataModel_ARIntCircularLateral ?? (dataModel_ARIntCircularLateral = new DataModel_ARIntCircularLateral());
    }
}
