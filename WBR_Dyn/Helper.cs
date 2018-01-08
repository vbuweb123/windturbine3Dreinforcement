//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;
//using WBR_Common.Common.Attributes;
//using WBR_Common.StaticModel;
//using WBR_Common.Writer;

//namespace WBR_Dyn
//{
//    public class Helper
//    {
//        private static CollectedDictionary collectedData = new CollectedDictionary();

//        private static void GetDynGet(PropertyInfo propertyInfo, Action<bool, string> attributeResult)
//        {
//            DynGet attribute = propertyInfo.GetCustomAttribute<DynGet>() as DynGet;
//            if (attribute != null)
//            {
//                attributeResult(true, attribute.DynKey);
//            }
//            else
//            {
//                attributeResult(false, null);
//            }
//        }

//        private static void UnwrappAll(object datamodel)
//        {
//            foreach (PropertyInfo propertyInfo in datamodel.GetType().GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance))
//            {
//                var property = propertyInfo.GetValue(datamodel);

//                if (property != null)
//                {
//                    GetDynGet(propertyInfo, (hasKey, keyValue) => {
//                        if (hasKey)
//                        {
//                            collectedData.Add(keyValue, property);
//                        }
//                    });

//                    if (property is System.Object)
//                    {
//                        UnwrappAll(property);
//                    }
//                }
//            }
//        }
//        public static CollectedDictionary GetDictionary(string filePath)
//        {
//            GlobalDataModels globalDataModels = new GlobalDataModels();
//            Writer.Open(globalDataModels, filePath);
//            UnwrappAll(globalDataModels);
//            return collectedData;
//        }
//    }
//}
