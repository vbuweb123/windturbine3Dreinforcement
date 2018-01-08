using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBR_Common.DynGenerateData
{
    public class CollectedDictionary
    {
        private Dictionary<string, object> collection;

        public CollectedDictionary()
        {
            collection = new Dictionary<string, object>();
        }
        public void Add(string key, object value) => collection.Add(key, value);

        public List<string> GetKeys()
        {
            return collection.Select(x => x.Key).ToList();
        }
        public List<object> GetValues()
        {
            return collection.Select(x => x.Value).ToList();
        }
        public List<object> GetValueByKey(string key)
        {
            return collection.Where(x => x.Key == key).Select(x => x.Value).ToList();
        }
        public object GetSingleValueByKey(string key)
        {
            var @return = collection.Where(x => x.Key == key).Select(x => x.Value).ToList().SingleOrDefault();
            return @return;
        }
        public Dictionary<string, object> GetData() => this.collection;
    }
}
