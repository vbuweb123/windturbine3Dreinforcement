using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindBarrierReinforcement.StaticModel
{
    public partial class Global
    {
        public IGlobalPage01 GlobalPage01 { get; private set; }

        public IGlobalPage02 GlobalPage02 { get; private set; }

        public IGlobalPage03 GlobalPage03 { get; private set; }

        public IGlobalPage04 GlobalPage04 { get; private set; }

        public IGlobalPage05 GlobalPage05 { get; private set; }

        public IGlobalPage06 GlobalPage06 { get; private set; }

        public IGlobalPage07 GlobalPage07 { get; private set; }

        public IGlobalPage08 GlobalPage08 { get; private set; }

        public IGlobalPage09 GlobalPage09 { get; private set; }

        public IGlobalPage10 GlobalPage10 { get; private set; }

        public IGlobalPage11 GlobalPage11 { get; private set; }

        public IGlobalPage12 GlobalPage12 { get; private set; }

        private EvtHandler EvtHandler;

        public Global()
        {
            GlobalPage01 = new _GlobalPage01(EvtHandler);
            GlobalPage02 = new _GlobalPage02(EvtHandler);
            GlobalPage03 = new _GlobalPage03(EvtHandler);
            GlobalPage04 = new _GlobalPage04(EvtHandler);
            GlobalPage05 = new _GlobalPage05(EvtHandler);
            GlobalPage06 = new _GlobalPage06(EvtHandler);
            GlobalPage07 = new _GlobalPage07(EvtHandler);
            GlobalPage08 = new _GlobalPage08(EvtHandler);
            GlobalPage09 = new _GlobalPage09(EvtHandler);
            GlobalPage10 = new _GlobalPage10(EvtHandler);
            GlobalPage11 = new _GlobalPage11(EvtHandler);
            GlobalPage12 = new _GlobalPage12(EvtHandler);
            //calling each registered action
            Evts.ForEach((evtAction) => evtAction());
        }
    }
    public static class GlobalPageEvts
    {


        private static Global global;
        public static Global Global => global ?? (global = new Global());
    }
}
