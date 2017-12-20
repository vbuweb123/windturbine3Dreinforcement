using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WindBarrierReinforcement.Common.Reflected;
using System.Reflection;
using WindBarrierReinforcement.Common.Attributes;
using System.Xml;
using WindBarrierReinforcement.StaticModel;
using System.Collections;
using System.Xml.Serialization;

namespace WindBarrierReinforcement.Writer
{
    public static partial class Writer
    {
        //static List<PropertyDataInfo> properties;

        //private static string currentDirectory;

        //private static GlobalDataModels GlobalDataModels;

        private static Registry Registry;

        public static void Open(GlobalDataModels global)
        {

            //Registry
            Registry = new Registry();
            Registry.Register<GlobalDataModels, GlobalDataModels>(global);
            //Registry
            var currentDirectory = Directory.GetCurrentDirectory();
            //FileStream fs = new FileStream(currentDirectory + "\\temp.xml", FileMode.Open);
            string xml = System.IO.File.ReadAllText(currentDirectory + "\\temp.xml");
            //XmlTextReader xmlTextReader = new XmlTextReader(fs);
            //xmlTextReader.read();

            XmlDocument doc = new XmlDocument();

            doc.LoadXml(xml);

            EvaluateOpenedXML(doc);

        }

        public static void EvaluateOpenedXML(XmlDocument xmlDocument)
        {
            //first child node is 
            var root = xmlDocument.GetElementsByTagName(RootNodeName)[0];

            KeyCodeDictionary dictionary = new KeyCodeDictionary();

            GlobalDataModels globalDataModels = Registry.Demand<GlobalDataModels>();

            PropertyInfo[] propertiesInfo = typeof(GlobalDataModels).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo pinfo in propertiesInfo)
            {
                Match(pinfo, root, globalDataModels);
            }
        }

        private static void Match(PropertyInfo pInfo, XmlNode xmlNode, object context)
        {
            SaveKeyCodeAttribute Attribute = pInfo.GetCustomAttribute<SaveKeyCodeAttribute>();
            if (Attribute != null)
            {
                foreach (XmlElement node in xmlNode.ChildNodes)
                {
                    if (node.Name == Attribute.KeyCode)
                    {
                        SetUpData(node, pInfo, context);
                        break;
                    }
                }
            }
        }
        public static void SetUpData(XmlElement element, PropertyInfo pInfo, object Context)
        {
            SaveKeyCodeAttribute Attribute = pInfo.GetCustomAttribute<SaveKeyCodeAttribute>();
            string KeyCode = Attribute.KeyCode;
            SaveDataType SaveDataType = Attribute.SaveDataType;
            Type CollectionType = Attribute.CollectionElementType;

            if (SaveDataType == SaveDataType.Class)
            {
                object PropertyValue = pInfo.GetValue(Context);

                //iterate through properties of this class
                PropertyInfo[] propertiesInfo = PropertyValue.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

                foreach (PropertyInfo pInfoInContext in propertiesInfo)
                {
                    Match(pInfoInContext, element, PropertyValue);
                }
            }
            else if (SaveDataType == SaveDataType.ListOfClass)
            {
                IList collection = (IList)pInfo.GetValue(Context);
                //because we are working with the existing global - reset the collection
                collection.Clear();
                //iterate through items of collection
                foreach (XmlElement xmlItem in element.ChildNodes)
                {
                    var classItem = SolveConstructor(CollectionType);
                    if (classItem == null) throw new Exception(string.Format("Unable to create class item {0}", CollectionType.FullName));
                   

                    //iterate through properties of this class
                    PropertyInfo[] propertiesInfo = classItem.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

                    foreach (PropertyInfo pInfoInContext in propertiesInfo)
                    {
                        Match(pInfoInContext, xmlItem, classItem);
                    }

                    collection.Add(classItem);
                }
            }
            else if (SaveDataType == SaveDataType.List)
            {
                IList collection = (IList)pInfo.GetValue(Context);
                //because we are working with the existing global - reset the collection
                collection.Clear();
                //iterate through items of collection
                foreach (XmlElement xmlItem in element.ChildNodes)
                {
                    collection.Add(TrySolveConverter(xmlItem.InnerText, Attribute.CollectionElementType));
                }
            }
            else if (SaveDataType == SaveDataType.Default)
            {
                string value = element.InnerText;
                object solvedValue = TrySolveConverter(value, pInfo.PropertyType);
                if (solvedValue == null) throw new Exception("Unable to solve request");
                pInfo.SetValue(Context, solvedValue);
            }
        }
        public static object TrySolveConverter(string value, Type Req)
        {
            if (Req == typeof(int))
            {
                int.TryParse(value, out int result);
                return result;
            }
            if (Req == typeof(string))
                return value;
            if (Req == typeof(double))
            {
                double.TryParse(value, out double result);
                return result;
            }
            if (Req == typeof(bool))
            {
                bool.TryParse(value, out bool result);
                return result;
            }
            
            return null;
        }
        public static object SolveConstructor(Type type)
        {
            ConstructorInfo constructor = type.GetConstructors().FirstOrDefault();
            if (constructor == null)
                return null;

            var arguments = constructor.GetParameters();
            List<object> argumentFullfilment = new List<object>();

            foreach (var argument in arguments)
            {
                var obj = Registry.Demand(argument.ParameterType);
                if (obj == null) throw new Exception(string.Format("Unable to fullfill requirement Argument {0} for type {1} not found in registry ", argument.Name, type.FullName));

                argumentFullfilment.Add(obj);
            }
            return Activator.CreateInstance(type, argumentFullfilment.ToArray());
        }
    }
}
