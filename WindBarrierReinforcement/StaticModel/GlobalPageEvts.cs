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

        public Global()
        {
            GlobalPage01 = new _GlobalPage01();
            GlobalPage02 = new _GlobalPage02();
            GlobalPage03 = new _GlobalPage03();
            GlobalPage04 = new _GlobalPage04();
            GlobalPage05 = new _GlobalPage05();
            GlobalPage06 = new _GlobalPage06();
            GlobalPage07 = new _GlobalPage07();
            GlobalPage08 = new _GlobalPage08();
            GlobalPage09 = new _GlobalPage09();
            GlobalPage10 = new _GlobalPage10();
            GlobalPage11 = new _GlobalPage11();
            GlobalPage12 = new _GlobalPage12();
            //calling each registered action
            GlobalPageEvts.Evts.ForEach((evtAction) => evtAction());
        }
    }
    public static class GlobalPageEvts
    {
        private static List<Action> evts;
        public static List<Action> Evts => evts ?? (evts = new List<Action>());

        private static Global global;
        public static Global Global => global ?? (global = new Global());
    }
}
