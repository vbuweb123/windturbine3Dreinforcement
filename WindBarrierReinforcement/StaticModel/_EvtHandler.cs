using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindBarrierReinforcement.StaticModel
{
    public interface IEvtStore
    {
        void Add(Action EvtAction);
    }
    public partial class GlobalDataModels
    {
        public class _EvtHandler : IEvtStore
        {
            private List<Action> evts;
            public List<Action> Evts => evts ?? (evts = new List<Action>());
            public static int aa = 0;
            public void Add(Action EvtAction)
            {
                Evts.Add(EvtAction);
            }
            public void RegisterAll()
            {
                Evts.ForEach((action) => action());
            }
        }
    }
}
