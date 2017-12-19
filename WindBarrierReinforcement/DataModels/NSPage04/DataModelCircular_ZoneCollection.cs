using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.StaticModel;
using WindBarrierReinforcement.Writer;

namespace WindBarrierReinforcement.DataModels.NSPage04
{
    public class DataModelCircular_ZoneCollection
    {
        [SaveKeyCode(KeyCode = "Zones", SaveDataType = SaveDataType.ListOfClass, CollectionElementType = typeof(DataModelCircular_Zone))]
        public ObservableCollection<DataModelCircular_Zone> Zones { get; set; }

        private GlobalDataModels _globalDataModels;

        public int Count => Zones.Count;

        public DataModelCircular_ZoneCollection(GlobalDataModels global)
        {
            _globalDataModels = global;

            Zones = new ObservableCollection<DataModelCircular_Zone>();

            //2 zones minimum
            Zones.Add(new DataModelCircular_Zone(global));
            Zones.Add(new DataModelCircular_Zone(global));

            Zones.CollectionChanged += (o, e) => {
                for (var i = 0; i < Count; i++)
                {
                    Zones[i].ListIndex = i;
                    var cc = Zones[i].ListIndex;
                    if (i == 0)
                        Zones[i].Position = EZonePosition.Start;
                    else if (i == Count - 1)
                        Zones[i].Position = EZonePosition.End;
                    else
                        Zones[i].Position = EZonePosition.Middle;
                }
            };
        }
        public void UpdateIndices()
        {
            for (var i = 0; i < Count; i++)
            {
                Zones[i].ListIndex = i;
            }
        }

        public DataModelCircular_Zone Get(int index)
        {
            return Zones[index];
        }

        public void Add()
        {
            Zones.Add(new DataModelCircular_Zone(_globalDataModels));
        }

        public void AddBeforeLast()
        {
            Zones.Insert(Count - 1, new DataModelCircular_Zone(_globalDataModels));
        }

        public bool Remove()
        {
            if (Zones.Count > 2)
            {
                Zones.RemoveAt(Zones.Count - 1);
                return true;
            }
            return false;
        }

        public bool RemoveBeforeLast()
        {
            if (Zones.Count > 2)
            {
                Zones.RemoveAt(Zones.Count - 2);
                return true;
            }
            return false;
        }
    }
}
