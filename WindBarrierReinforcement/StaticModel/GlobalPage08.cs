using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage08;

namespace WindBarrierReinforcement.StaticModel
{
    public class GlobalPage08
    {
        private DataModel_ARExtUBars dataModel_ARExtUBars;
        public DataModel_ARExtUBars DataModel_ARExtUBars 
            => dataModel_ARExtUBars ?? (dataModel_ARExtUBars = new DataModel_ARExtUBars());

        private DataModel_ARExteriorCircularTop dataModel_ARExteriorCircularTop;
        public DataModel_ARExteriorCircularTop DataModel_ARExteriorCircularTop 
            => dataModel_ARExteriorCircularTop ?? (dataModel_ARExteriorCircularTop = new DataModel_ARExteriorCircularTop());

        private DataModel_ARExteriorCircularLateral dataModel_ARExteriorCircularLateral;
        public DataModel_ARExteriorCircularLateral DataModel_ARExteriorCircularLateral 
            => dataModel_ARExteriorCircularLateral ?? (dataModel_ARExteriorCircularLateral = new DataModel_ARExteriorCircularLateral());

        private DataModel_ARExteriorCircularBottom dataModel_ARExteriorCircularBottom;
        public DataModel_ARExteriorCircularBottom DataModel_ARExteriorCircularBottom 
            => dataModel_ARExteriorCircularBottom ?? (dataModel_ARExteriorCircularBottom = new DataModel_ARExteriorCircularBottom());

        private DataModel_ARIntUBars dataModel_ARIntUBars;
        public DataModel_ARIntUBars DataModel_ARIntUBars
            => dataModel_ARIntUBars ?? (dataModel_ARIntUBars = new DataModel_ARIntUBars());

        private DataModel_ARIntCircularTop dataModel_ARIntCircularTop;
        public DataModel_ARIntCircularTop DataModel_ARIntCircularTop
            => dataModel_ARIntCircularTop ?? (dataModel_ARIntCircularTop = new DataModel_ARIntCircularTop());

        private DataModel_ARIntCircularBottom dataModel_ARIntCircularBottom;
        public DataModel_ARIntCircularBottom DataModel_ARIntCircularBottom
            => dataModel_ARIntCircularBottom ?? (dataModel_ARIntCircularBottom = new DataModel_ARIntCircularBottom());

        private DataModel_ARIntCircularLateral dataModel_ARIntCircularLateral;
        public DataModel_ARIntCircularLateral DataModel_ARIntCircularLateral 
            => dataModel_ARIntCircularLateral ?? (dataModel_ARIntCircularLateral = new DataModel_ARIntCircularLateral());
    }
}
