using Autodesk.DesignScript.Runtime;
using System.Collections.Generic;

namespace WBR_Dyn
{
    public static class Testname2
    {
        [IsVisibleInDynamoLibrary(false)]
        static Testname2() { }

        [MultiReturn(new[] { "Test" })]
        [IsVisibleInDynamoLibrary(true)]
        public static Dictionary<string, object> Get(string filepath)
        {
            return new Dictionary<string, object>
            {
                { "Test", 111 }
            };
        }
        //[MultiReturn(new[] { "CollectedDictionary" })]
        //[IsVisibleInDynamoLibrary(true)]
        //public static Dictionary<string, CollectedDictionary> Get(string filepath)
        //{
        //    return new Dictionary<string, CollectedDictionary>
        //    {
        //        { "CollectedDictionary", Helper.GetDictionary(filepath) }
        //    };
        //}

        //[MultiReturn(new[] { "Keys" })]
        //[IsVisibleInDynamoLibrary(true)]
        //public static Dictionary<string, List<string>> GetKeys(CollectedDictionary collectedDictionary)
        //{
        //    return new Dictionary<string, List<string>>
        //    {
        //        { "Keys", collectedDictionary.GetKeys() }
        //    };
        //}
        //[MultiReturn(new[] { "Values" })]
        //[IsVisibleInDynamoLibrary(true)]
        //public static Dictionary<string, List<object>> GetValues(CollectedDictionary collectedDictionary)
        //{
        //    return new Dictionary<string, List<object>>
        //    {
        //        { "Values", collectedDictionary.GetValues() }
        //    };
        //}

        //[MultiReturn(new[] { "ValueByKey" })]
        //[IsVisibleInDynamoLibrary(true)]
        //public static Dictionary<string, List<object>> GetValueByKey(CollectedDictionary collectedDictionary, string Key)
        //{
        //    return new Dictionary<string, List<object>>
        //    {
        //        { "ValueByKey", collectedDictionary.GetValueByKey(Key) }
        //    };
        //}
    }
}
