using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.Attributes;
using WindBarrierReinforcement.StaticModel;
using WindBarrierReinforcement.Writer;

namespace WindBarrierReinforcement.DataModels.NSPage09
{
    public class DataModelUBABCollection
    {
        [SaveKeyCode(CollectionElementType = typeof(DataModelUBAB), KeyCode = "Collection", SaveDataType = SaveDataType.ListOfClass)]
        public ObservableCollection<DataModelUBAB> Collection { get; set; }

        [SaveKeyCode(CollectionElementType = typeof(int), KeyCode = "DADADA", SaveDataType = SaveDataType.List)]
        public List<int> DataMyData => new List<int> { 1, 2, 3 };
        //private int _zoneIndexCurrent = 0;
        private int _maxzones = 10;
        private GlobalDataModels global;


        public DataModelUBAB this[int index]
        {
            get => Collection[index];
        }

        public DataModelUBABCollection(GlobalDataModels global)
        {
            this.global = global;

            Collection = new ObservableCollection<DataModelUBAB>();
        }
        public void Add(string zoneName)
        {
            if (Collection.Count < _maxzones)
            {
                int lastPosition = this.Collection.Count;

                string zoneNameIndex = zoneName + lastPosition;

                this.Collection.Add(new DataModelUBAB(global, zoneNameIndex, lastPosition));
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
