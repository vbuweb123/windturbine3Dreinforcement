using Autodesk.DesignScript.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBR_Common.DynGenerateData;

namespace Data
{
    public static class Read
    {
        //static Container container;
        [IsVisibleInDynamoLibrary(false)]
        
        static Read()
        {
        }

        [MultiReturn(new[] { "CollectedDictionary" })]
        [IsVisibleInDynamoLibrary(true)]
        public static Dictionary<string, object> GetCollectedDictionary(string filepath)
        {
            return new Dictionary<string, object>
            {
                { "CollectedDictionary", WBR_Common.DynGenerateData.Helper.GetDictionary(filepath) }
            };
        }

        [MultiReturn(new[] { "Keys" })]
        [IsVisibleInDynamoLibrary(true)]
        public static Dictionary<string, List<string>> GetKeys(CollectedDictionary collectedDictionary)
        {
            return new Dictionary<string, List<string>>
            {
                { "Keys", collectedDictionary.GetKeys() }
            };
        }
        [MultiReturn(new[] { "Values" })]
        [IsVisibleInDynamoLibrary(true)]
        public static Dictionary<string, List<object>> GetValues(CollectedDictionary collectedDictionary)
        {
            return new Dictionary<string, List<object>>
            {
                { "Values", collectedDictionary.GetValues() }
            };
        }

        [MultiReturn(new[] { "Value" })]
        [IsVisibleInDynamoLibrary(true)]
        public static Dictionary<string, object> GetValueByKey(CollectedDictionary collectedDictionary, string Key)
        {
            return new Dictionary<string, object>
            {
                { "Value", collectedDictionary.GetSingleValueByKey(Key) }
            };
        }

        [MultiReturn(new[] { "Values" })]
        [IsVisibleInDynamoLibrary(true)]
        public static Dictionary<string, object> GetValueByKeys(CollectedDictionary collectedDictionary, List<string> Keys)
        {
            return new Dictionary<string, object>
            {
                { "Values", Keys.Select(key => collectedDictionary.GetSingleValueByKey(key)).ToList() }
            };
        }
    }
}
