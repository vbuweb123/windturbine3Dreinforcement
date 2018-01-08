//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace WBR_Dyn
//{
//    public class CollectedDictionary : Dictionary<string, object>
//    {
//        public CollectedDictionary()
//        {
//        }
//        public List<string> GetKeys()
//        {
//            return this.Select(x => x.Key).ToList();
//        }
//        public List<object> GetValues()
//        {
//            return this.Select(x => x.Value).ToList();
//        }
//        public List<object> GetValueByKey(string key)
//        {
//            return this.Where(x => x.Key == key).Select(x=>x.Value).ToList();
//        }
//        public object GetSingleValueByKey(string key)
//        {
//            return this.Where(x => x.Key == key).Select(x => x.Value).SingleOrDefault();
//        }
//    }
//}
