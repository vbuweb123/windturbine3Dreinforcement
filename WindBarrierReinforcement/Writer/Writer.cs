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
    public static class Writer
    {
        static List<PropertyDataInfo> properties;

        private static string currentDirectory;

        private static GlobalDataModels GlobalDataModels;

        private static readonly string RootNodeName = "ReinforcementData";

        public static void Save(GlobalDataModels globalDataModels)
        {
            GlobalDataModels = globalDataModels;

            XmlDocument Document = new XmlDocument();

            Document.PreserveWhitespace = true;

            XmlNode root = AppendRoot(Document);

            KeyCodeDictionary saveData = CollectGlobalDataModel(GlobalDataModels);

            EvaluateDictionary(saveData, Document, root);

            Document.AppendChild(root);

            Save(Document);
        }
        private static void EvaluateDictionary(KeyCodeDictionary dictionary, XmlDocument xmlDocument, XmlNode Node)
        {
            foreach (KeyValuePair<SaveKeyCodeAttribute, object> keyValuePair in dictionary)
            {
                if (keyValuePair.Key.SaveDataType == SaveDataType.Navigation)
                {
                    XmlElement children = xmlDocument.CreateElement(keyValuePair.Key.KeyCode);
                    EvaluateDictionary((KeyCodeDictionary)(keyValuePair.Value), xmlDocument, children);

                    XmlAttribute _saveTypeAttribute = xmlDocument.CreateAttribute("SaveDataType");
                    _saveTypeAttribute.Value = keyValuePair.Key.SaveDataType.ToString();

                    XmlAttribute _collectionElementTypeAttribute = xmlDocument.CreateAttribute("Type");
                    _collectionElementTypeAttribute.Value = (keyValuePair.Key.CollectionElementType != null) ? keyValuePair.Key.CollectionElementType.FullName : "";

                    children.Attributes.Append(_saveTypeAttribute);
                    children.Attributes.Append(_collectionElementTypeAttribute);

                    Node.AppendChild(children);
                }
                else if (keyValuePair.Key.SaveDataType == SaveDataType.ListAndNavigation)
                {
                    /*
                         ListNavigation translates like:
                         List<SomeClass> = [Object1, Object2, Object3] is
                            ListAttributeKeyCode :: 
                                [
                                    [ Object1Attribute, value ],
                                    [ Object2Attribute, value ],
                                    [ Object3Attribute, value ]
                                ]
                            
                         */
                    XmlElement children = xmlDocument.CreateElement(keyValuePair.Key.KeyCode);
                    List<KeyCodeDictionary> converted = (List<KeyCodeDictionary>)keyValuePair.Value;

                    XmlAttribute _saveTypeAttribute = xmlDocument.CreateAttribute("SaveDataType");
                    _saveTypeAttribute.Value = keyValuePair.Key.SaveDataType.ToString();

                    XmlAttribute _collectionElementTypeAttribute = xmlDocument.CreateAttribute("Type");
                    _collectionElementTypeAttribute.Value = (keyValuePair.Key.CollectionElementType != null) ? keyValuePair.Key.CollectionElementType.FullName : "";

                    children.Attributes.Append(_saveTypeAttribute);
                    children.Attributes.Append(_collectionElementTypeAttribute);

                    foreach (var item in converted)
                    {
                        XmlElement itemElement = xmlDocument.CreateElement(keyValuePair.Key.KeyCode + "_item");
                        EvaluateDictionary(item, xmlDocument, itemElement);
                        children.AppendChild(itemElement);
                    }
                    Node.AppendChild(children);
                }
                else if (keyValuePair.Key.SaveDataType == SaveDataType.List)
                { /*
                    List<int> = [1,2,3]  is
                    ListAttrCode :: [1,2,3] ]
                    */
                    IEnumerable converted = (IEnumerable)keyValuePair.Value;
                    XmlElement children = xmlDocument.CreateElement(keyValuePair.Key.KeyCode);

                    XmlAttribute _saveTypeAttribute = xmlDocument.CreateAttribute("SaveDataType");
                    _saveTypeAttribute.Value = keyValuePair.Key.SaveDataType.ToString();

                    XmlAttribute _collectionElementTypeAttribute = xmlDocument.CreateAttribute("Type");
                    _collectionElementTypeAttribute.Value = (keyValuePair.Key.CollectionElementType != null) ? keyValuePair.Key.CollectionElementType.FullName : "";

                    children.Attributes.Append(_saveTypeAttribute);
                    children.Attributes.Append(_collectionElementTypeAttribute);


                    foreach (var item in converted)
                    {
                        XmlElement itemElement = xmlDocument.CreateElement(keyValuePair.Key.KeyCode + "_item");
                        itemElement.InnerText = item.ToString();
                        children.AppendChild(itemElement);
                    }
                    Node.AppendChild(children);
                }
                else
                {
                    XmlElement children = xmlDocument.CreateElement(keyValuePair.Key.KeyCode);
                    children.InnerText = keyValuePair.Value.ToString();

                    XmlAttribute _saveTypeAttribute = xmlDocument.CreateAttribute("SaveDataType");
                    _saveTypeAttribute.Value = keyValuePair.Key.SaveDataType.ToString();

                    XmlAttribute _collectionElementTypeAttribute = xmlDocument.CreateAttribute("Type");
                    _collectionElementTypeAttribute.Value = (keyValuePair.Key.CollectionElementType != null) ? keyValuePair.Key.CollectionElementType.FullName : "";

                    children.Attributes.Append(_saveTypeAttribute);
                    children.Attributes.Append(_collectionElementTypeAttribute);

                    Node.AppendChild(children);
                }
            }
        }

        private static XmlNode AppendRoot(XmlDocument xmlDocument)
        {
            ////craete Root Node
            XmlNode root = xmlDocument.CreateElement(RootNodeName);

            XmlAttribute nowDate = xmlDocument.CreateAttribute("CreatedAt");
            nowDate.Value = DateTime.Now.ToUniversalTime().ToString();
            root.Attributes.Append(nowDate);
            return root;
        }

        private static void Save(XmlDocument xmlDocument)
        {
            currentDirectory = Directory.GetCurrentDirectory();
            FileStream fs = new FileStream(currentDirectory + "\\temp.xml", FileMode.Create);
            XmlTextWriter xmlTextWriter = new XmlTextWriter(fs, Encoding.Unicode) { Formatting = Formatting.Indented };

            xmlDocument.WriteContentTo(xmlTextWriter);

            xmlTextWriter.Close();

            fs.Close();

        }

        private static KeyCodeDictionary CollectGlobalDataModel(object Data)
        {
            //inquiring global
            Type globalType = Data.GetType();
            //get all properties - GDMPage01, 02, etc
            PropertyInfo[] GDMPropertiesInfo = globalType.GetProperties(BindingFlags.Instance | BindingFlags.Public);

            KeyCodeDictionary dictionary = new KeyCodeDictionary();

            foreach (PropertyInfo propertyInfo in GDMPropertiesInfo)
            {
                //get the custom attribute that makes the object saveable
                SaveKeyCodeAttribute Attribute = propertyInfo.GetCustomAttribute<SaveKeyCodeAttribute>() as SaveKeyCodeAttribute;
                if (Attribute != null)
                {
                    if (Attribute.SaveDataType == SaveDataType.Navigation)
                    {
                        /*
                         PropertyWithNavigation =>
                            PropertyAttribute :: [Properties<Attribute, value>] 
                         */
                        object returnData = CollectGlobalDataModel(propertyInfo.GetValue(Data));
                        dictionary.Add(Attribute, returnData);
                    }
                    else if (Attribute.SaveDataType == SaveDataType.ListAndNavigation)
                    {
                        //convert current object to list
                        IEnumerable<object> list = (IEnumerable<object>)propertyInfo.GetValue(Data);
                        List<KeyCodeDictionary> convertedItems = new List<KeyCodeDictionary>();
                        /*
                         ListNavigation translates like:
                         List<SomeClass> = [Object1, Object2, Object3] is
                            ListAttributeKeyCode :: 
                                [
                                    [ Object1Attribute, value == [ Attr1 :: val1; Attr2 :: val2 ] ],
                                    [ Object2Attribute, value ],
                                    [ Object3Attribute, value ]
                                ]
                            
                         */
                        foreach (var item in list)
                        {
                            convertedItems.Add(CollectGlobalDataModel(item));
                        }
                        dictionary.Add(Attribute, convertedItems);
                    }
                    else if (Attribute.SaveDataType == SaveDataType.List)
                    {
                        /*
                         List<int> = [1,2,3]  is
                            ListAttrCode :: [1,2,3] ]
                         */
                        object returnData = propertyInfo.GetValue(Data);
                        dictionary.Add(Attribute, returnData);
                    }
                    else
                    {
                        //Property => Attribute :: Value
                        dictionary.Add(Attribute, propertyInfo.GetValue(Data));
                    }
                }
            }
            return dictionary;
        }

        public static void Open(GlobalDataModels global)
        {
            GlobalDataModels = global;

            currentDirectory = Directory.GetCurrentDirectory();
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

            foreach (XmlNode node in root.ChildNodes)
            {
                string KeyCodeName = node.Name;
                var aa = 2;
            }
            var a = 1;
        }
    }
}
