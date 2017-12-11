using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindBarrierReinforcement.StaticModel
{
    public class EvtHandler
    {
        private List<Action> evts;
        public List<Action> Evts => evts ?? (evts = new List<Action>());

        public void Register(Action EvtAction)
        {
            Evts.Add(EvtAction);
        }
    }
}
