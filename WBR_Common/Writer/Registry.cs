using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBR_Common.Writer
{
    public class Registry
    {
        Dictionary<string, object> collection = new Dictionary<string, object>();

        public void Register<TReq, TProv>(TProv context) 
        {
            collection.Add(typeof(TReq).FullName, context);
        }

        public TReq Demand<TReq>()
        {
            return (TReq)collection.Where(x => x.Key.Equals(typeof(TReq).FullName)).SingleOrDefault().Value;
        }
        public object Demand(Type TReq)
        {
            return collection.Where(x => x.Key.Equals(TReq.FullName)).SingleOrDefault().Value;
        }
    }
}
