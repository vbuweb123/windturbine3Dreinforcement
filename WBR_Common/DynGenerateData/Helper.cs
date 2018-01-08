using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WBR_Common.Common.Attributes;
using WBR_Common.StaticModel;
using WBR_Common.Writer;

namespace WBR_Common.DynGenerateData
{
    public class Helper
    {
        public CollectedDictionary CollectedData { get; set; }

        public Helper()
        {
            CollectedData = new CollectedDictionary();
        }

        internal void HasDynKey(PropertyInfo propertyInfo, Action<string> actionIfTrue)
        {
            DynGet attribute = propertyInfo.GetCustomAttribute<DynGet>() as DynGet;
            if (attribute != null)
            {
                if (!string.IsNullOrEmpty(attribute.DynKey))
                    actionIfTrue(attribute.DynKey);
            }
        }

        internal void HasPropertyDynNav(PropertyInfo propertyInfo, object dataCotnext, Action<bool, string> actionIfTrue)
        {
            if (propertyInfo != null)
            {
                var property = propertyInfo.GetValue(dataCotnext);
                if (property != null)
                {
                    if (property is System.Object)
                    {
                        DynNav attributePI = propertyInfo.GetCustomAttribute<DynNav>() as DynNav;

                        if (attributePI != null)
                            actionIfTrue(attributePI.AddNavKey, attributePI.Key);
                    }
                }

            }

        }

        internal void UnwrappAll(object datamodel, string prefix = "")
        {

            foreach (PropertyInfo propertyInfo in datamodel.GetType().GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance))
            {
                //ignore any indexers
                if (propertyInfo.GetMethod.Name == "get_Item")
                    return;

                var property = propertyInfo.GetValue(datamodel);

                if (property != null)
                {
                    HasDynKey(propertyInfo, (keyValue) =>
                    {
                        CollectedData.Add(string.Format("{0}/{1}", prefix, keyValue), property);
                    });

                    HasPropertyDynNav(propertyInfo, datamodel, (AddNavKey, Key) =>
                    {
                        string postFix = prefix;

                        if (AddNavKey)
                            postFix += "/" + Key;

                        if (property is IEnumerable)
                        {
                            IEnumerable enumerable = (IEnumerable)property;
                            int index = 0;
                            Helper helperMaster = new Helper();

                            foreach (var item in enumerable)
                            {
                                Helper helper = new Helper();
                                helper.UnwrappAll(item);
                                helperMaster.CollectedData.Add(string.Format("{0}/item_{1}", Key, index), helper.CollectedData);
                                //duplicate
                                CollectedData.Add(string.Format("{0}/{1}/item_{2}", prefix, Key, index++), helper.CollectedData);
                            }
                            CollectedData.Add(postFix, helperMaster.CollectedData);
                        }
                        else
                        {
                            UnwrappAll(property, postFix);
                        }
                    });
                }
            }
        }

        public static CollectedDictionary GetDictionary(string filePath)
        {
            Helper helper = new Helper();

            GlobalDataModels globalDataModels = new GlobalDataModels();
            WBR_Common.Writer.Writer.Open(globalDataModels, filePath);

            helper.UnwrappAll(globalDataModels);

            return helper.CollectedData;
        }

        public static Dictionary<string, object> GetData(CollectedDictionary dictionary)
        {
            return dictionary.GetData();
        }
    }
}
