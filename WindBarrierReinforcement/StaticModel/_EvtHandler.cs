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
        void AddPostBuildEvents(Action EvtAction);
        void AddPostEventsRegisterAction(Action EvtAction);
        void AddPopulateDataAction(Action action);
        void RegisterPostBuildEvents();
        void CallPostEventsRegisterAction();
        void CallPopulateDataAction();

    }
    public partial class GlobalDataModels
    {
        public class _EvtHandler : IEvtStore
        {
            //Property Changed events added here. They are attached after all data models are instanciated
            private List<Action> evts;
            public List<Action> Evts => evts ?? (evts = new List<Action>());
            //Combobox and string initializers here. Called after all PropertyChanged events are set
            private List<Action> evtsPostRegister;
            public List<Action> EvtsPostRegister => evtsPostRegister ?? (evtsPostRegister = new List<Action>());
            //Initializers for textboxes here - for prepopulating data
            private List<Action> evtsPopulateData;
            public List<Action> EvtsPopulateData => evtsPopulateData ?? (evtsPopulateData = new List<Action>());

            public void AddPostBuildEvents(Action EvtAction)
            {
                Evts.Add(EvtAction);
            }
            public void RegisterPostBuildEvents()
            {
                Evts.ForEach((action) => action());
            }
           
            public void AddPostEventsRegisterAction(Action EvtAction)
            {
                EvtsPostRegister.Add(EvtAction);
            }
            public void CallPostEventsRegisterAction()
            {
                EvtsPostRegister.ForEach((action) => action());
            }

            public void AddPopulateDataAction(Action action)
            {
                EvtsPopulateData.Add(action);
            }
            public void CallPopulateDataAction()
            {
                EvtsPopulateData.ForEach((action) => action());
            }
        }
    }
}
