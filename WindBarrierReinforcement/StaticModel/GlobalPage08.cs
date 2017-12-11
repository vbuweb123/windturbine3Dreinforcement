using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage08;

namespace WindBarrierReinforcement.StaticModel
{
    public interface IGlobalPage08
    {
        DataModel_ARExtUBars DataModel_ARExtUBars { get; }
        DataModel_ARExteriorCircularTop DataModel_ARExteriorCircularTop { get; }
        DataModel_ARExteriorCircularLateral DataModel_ARExteriorCircularLateral { get; }
        DataModel_ARExteriorCircularBottom DataModel_ARExteriorCircularBottom { get; }
        DataModel_ARIntUBars DataModel_ARIntUBars { get; }
        DataModel_ARIntCircularTop DataModel_ARIntCircularTop { get; }
        DataModel_ARIntCircularBottom DataModel_ARIntCircularBottom { get; }
        DataModel_ARIntCircularLateral DataModel_ARIntCircularLateral { get; }
    }
    public partial class Global
    {
        private class _GlobalPage08 : IGlobalPage08
        {
            public DataModel_ARExtUBars DataModel_ARExtUBars { get; private set; }

            public DataModel_ARExteriorCircularTop DataModel_ARExteriorCircularTop { get; private set; }

            public DataModel_ARExteriorCircularLateral DataModel_ARExteriorCircularLateral { get; private set; }

            public DataModel_ARExteriorCircularBottom DataModel_ARExteriorCircularBottom { get; private set; }

            public DataModel_ARIntUBars DataModel_ARIntUBars { get; private set; }

            public DataModel_ARIntCircularTop DataModel_ARIntCircularTop { get; private set; }

            public DataModel_ARIntCircularBottom DataModel_ARIntCircularBottom { get; private set; }

            public DataModel_ARIntCircularLateral DataModel_ARIntCircularLateral { get; private set; }

            public _GlobalPage08(EvtHandler evtHandler)
            {
                DataModel_ARExtUBars = new DataModel_ARExtUBars();
                DataModel_ARExteriorCircularTop = new DataModel_ARExteriorCircularTop();
                DataModel_ARExteriorCircularLateral = new DataModel_ARExteriorCircularLateral();
                DataModel_ARExteriorCircularBottom = new DataModel_ARExteriorCircularBottom();
                DataModel_ARIntUBars = new DataModel_ARIntUBars(evtHandler);
                DataModel_ARIntCircularTop = new DataModel_ARIntCircularTop();
                DataModel_ARIntCircularBottom = new DataModel_ARIntCircularBottom();
                DataModel_ARIntCircularLateral = new DataModel_ARIntCircularLateral();
            }
        }
    }

}
