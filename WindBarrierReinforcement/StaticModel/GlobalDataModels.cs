using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindBarrierReinforcement.StaticModel
{
    public partial class GlobalDataModels
    {
        public IGlobalDataModelsPage01 GDMPage01 { get; private set; }

        public IGlobalDataModelsPage02 GDMPage02 { get; private set; }

        public IGlobalDataModelsPage03 GDMPage03 { get; private set; }

        public IGlobalDataModelsPage04 GDMPage04 { get; private set; }

        public IGlobalDataModelsPage05 GDMPage05 { get; private set; }

        public IGlobalDataModelsPage06 GDMPage06 { get; private set; }

        public IGlobalDataModelsPage07 GDMPage07 { get; private set; }

        public IGlobalDataModelsPage08 GDMPage08 { get; private set; }

        public IGlobalDataModelsPage09 GDMPage09 { get; private set; }

        public IGlobalDataModelsPage10 GDMPage10 { get; private set; }

        public IGlobalDataModelsPage11 GDMPage11 { get; private set; }

        public IGlobalDataModelsPage12 GDMPage12 { get; private set; }

        public IEvtStore EvtHandler { get; private set; }

        public GlobalDataModels()
        {
            var evtHandler = new _EvtHandler();
            EvtHandler = evtHandler;

            GDMPage01 = new _GlobalDataModelsPage01(this);
            GDMPage02 = new _GlobalDataModelsPage02(this);
            GDMPage03 = new _GlobalDataModelsPage03(this);
            GDMPage04 = new _GlobalDataModelsPage04(this);
            GDMPage05 = new _GlobalDataModelsPage05(this);
            GDMPage06 = new _GlobalDataModelsPage06(this);
            GDMPage07 = new _GlobalDataModelsPage07(this);
            GDMPage08 = new _GlobalDataModelsPage08(this);
            GDMPage09 = new _GlobalDataModelsPage09(this);
            GDMPage10 = new _GlobalDataModelsPage10(this);
            GDMPage11 = new _GlobalDataModelsPage11(this);
            GDMPage12 = new _GlobalDataModelsPage12(this);

            evtHandler.RegisterAll(); // hide this method to the outside world to avoind caling it from other places
        }
    }
}
