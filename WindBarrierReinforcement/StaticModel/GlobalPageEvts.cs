using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindBarrierReinforcement.StaticModel
{
    public class Global
    {
        private GlobalPage01 globalPage01;
        public GlobalPage01 GlobalPage01 => globalPage01 ??(globalPage01 = new GlobalPage01());

        private GlobalPage02 globalPage02;
        public GlobalPage02 GlobalPage02 => globalPage02 ?? (globalPage02 = new GlobalPage02());

        private GlobalPage03 globalPage03;
        public GlobalPage03 GlobalPage03 => globalPage03 ?? (globalPage03 = new GlobalPage03());

        private GlobalPage04 globalPage04;
        public GlobalPage04 GlobalPage04 => globalPage04 ?? (globalPage04 = new GlobalPage04());

        private GlobalPage05 globalPage05;
        public GlobalPage05 GlobalPage05 => globalPage05 ?? (globalPage05 = new GlobalPage05());

        private GlobalPage06 globalPage06;
        public GlobalPage06 GlobalPage06 => globalPage06 ?? (globalPage06 = new GlobalPage06());

        private GlobalPage07 globalPage07;
        public GlobalPage07 GlobalPage07 => globalPage07 ?? (globalPage07 = new GlobalPage07());

        private GlobalPage08 globalPage08;
        public GlobalPage08 GlobalPage08 => globalPage08 ?? (globalPage08 = new GlobalPage08());

        private GlobalPage09 globalPage09;
        public GlobalPage09 GlobalPage09 => globalPage09 ?? (globalPage09 = new GlobalPage09());

        private GlobalPage10 globalPage10;
        public GlobalPage10 GlobalPage10 => globalPage10 ?? (globalPage10 = new GlobalPage10());

        private GlobalPage11 globalPage11;
        public GlobalPage11 GlobalPage11 => globalPage11 ?? (globalPage11 = new GlobalPage11());

        private GlobalPage12 globalPage12;
        public GlobalPage12 GlobalPage12 => globalPage12 ?? (globalPage12 = new GlobalPage12());
    }
    public static class GlobalPageEvts
    {
        private static List<Action> evts;
        public static List<Action> Evts => evts ?? (evts = new List<Action>());

        private static Global global;
        public static Global Global => global ?? (global = new Global());
    }
}
