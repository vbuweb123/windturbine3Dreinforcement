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

            this.Collection.CollectionChanged += (o, e) => {
                for (var i = 0; i < Collection.Count; i++)
                {
                    Collection[i].ZoneName = "zone " + i;
                    Collection[i].IndexInList = i;
                }
            };
        }

        public void Add()
        {
            if (Collection.Count < _maxzones)
            {
                var dataModelUBAB = new DataModelUBAB(global);
                this.Collection.Add(dataModelUBAB);
                dataModelUBAB.AddEvents();
            }
        }

        public void RemoveLast()
        {
            if (Collection.Count == 1) return;

            this.Collection.RemoveAt(this.Collection.Count - 1);
        }
    }
}
