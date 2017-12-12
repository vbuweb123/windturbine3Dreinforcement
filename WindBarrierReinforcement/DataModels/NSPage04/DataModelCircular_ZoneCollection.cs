using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement.DataModels.NSPage04
{
    public class DataModelCircular_ZoneCollection
    {
        public ObservableCollection<IDataModelCircularZone> Zones { get; set; }
        private GlobalDataModels _globalDataModels;
        public int Count => Zones.Count;

        public DataModelCircular_ZoneCollection(GlobalDataModels global)
        {
            _globalDataModels = global;
            Zones = new ObservableCollection<IDataModelCircularZone>();
            //fixed 2 zones
            Zones.Add(new DataModelCircular_ZoneBegining(global));
            Zones.Add(new DataModelCircular_ZoneEnd(global, 1));

            //add 2 in the middle
            this.Add();
            this.Add();
            UpdateIndices();
        }
        public void UpdateIndices()
        {
            for (var i = 0; i < Count; i++)
            {
                Zones[i].ListIndex = i;
            }
        }
        public IDataModelCircularZone Get(int index)
        {
            return Zones[index];
        }
        public void Add()
        {
            Zones.Insert(Zones.Count - 2, new DataModelCircular_ZoneMiddle(_globalDataModels));

            UpdateIndices();
        }

        public void RemoveNearEnd()
        {
            if (Zones.Count > 2)
            {
                Zones.RemoveAt(Zones.Count - 2);
                UpdateIndices();
            }
        }
    }
}
