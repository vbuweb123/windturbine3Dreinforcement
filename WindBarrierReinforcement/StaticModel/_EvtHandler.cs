using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WindBarrierReinforcement.StaticModel
{
    public interface IEvtStore
    {
        void Add(Action EvtAction);
        void AddPostEvtAction(Action EvtAction);
    }
    public partial class GlobalDataModels
    {
        public class _EvtHandler : IEvtStore
        {
            private List<Action> evts;
            public List<Action> Evts => evts ?? (evts = new List<Action>());

            private List<Action> evtsPostRegister;
            public List<Action> EvtsPostRegister => evtsPostRegister ?? (evtsPostRegister = new List<Action>());

            public void Add(Action EvtAction)
            {
                Evts.Add(EvtAction);
            }
            public void RegisterAll()
            {
                Evts.ForEach((action) => action());
            }

            public void AddPostEvtAction(Action EvtAction)
            {
                EvtsPostRegister.Add(EvtAction);
            }
            public void CallPostEvtActions()
            {
                EvtsPostRegister.ForEach((action) => action());
            }

        }
    }
}
