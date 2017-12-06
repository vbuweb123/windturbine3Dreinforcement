using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindBarrierReinforcement.DataModels.NSPage09
{
    public class DataModelUBABCollection
    {
        public ObservableCollection<DataModelUBAB> Collection { get; set; }

        private int _zoneIndexCurrent = 0;
        private int _maxzones = 10;

        public DataModelUBAB this[int index]
        {
            get => Collection[index];
        }

        public DataModelUBABCollection()
        {
            Collection = new ObservableCollection<DataModelUBAB>();
        }
        public void Add(string zoneName)
        {
            if (Collection.Count < _maxzones)
            {
                int lastPosition = this.Collection.Count;

                string zoneNameIndex = zoneName + lastPosition;

                this.Collection.Add(new DataModelUBAB(zoneNameIndex, lastPosition));
            }
        }
        public void RemoveAt(int index)
        {
            this.Collection.RemoveAt(index);
        }
        public void RemoveLast()
        {
            if (Collection.Count == 1) return;

            this.Collection.RemoveAt(this.Collection.Count - 1);
        }
    }
}
