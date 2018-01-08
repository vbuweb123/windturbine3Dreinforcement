using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WBR_Common.StaticModel;

namespace WBR_Common.Writer
{
    public static partial class Writer
    {
        private static readonly string RootNodeName = "ReinforcementData";

        public static void Save(GlobalDataModels globalDataModels, string filePath)
        {
            //GlobalDataModels = globalDataModels;

            XmlDocument Document = new XmlDocument();

            Document.PreserveWhitespace = true;

            XmlNode root = AppendRoot(Document);

            KeyCodeDictionary saveData = CollectGlobalDataModel(globalDataModels);

            EvaluateDictionary(saveData, Document, root);

            Document.AppendChild(root);

            SaveToFile(Document, filePath);
        }
        private static void EvaluateDictionary(KeyCodeDictionary dictionary, XmlDocument xmlDocument, XmlNode Node)
        {
            foreach (KeyValuePair<SaveKeyCodeAttribute, object> keyValuePair in dictionary)
            {
                if (keyValuePair.Key.SaveDataType == SaveDataType.Class)
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
                else if (keyValuePair.Key.SaveDataType == SaveDataType.ListOfClass)
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

        private static void SaveToFile(XmlDocument xmlDocument, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Create);

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
                    if (Attribute.SaveDataType == SaveDataType.Class)
                    {
                        /*
                         PropertyWithNavigation =>
                            PropertyAttribute :: [Properties<Attribute, value>] 
                         */
                        var item = propertyInfo.GetValue(Data);
                        object returnData = CollectGlobalDataModel(item);
                        dictionary.Add(Attribute, returnData);
                    }
                    else if (Attribute.SaveDataType == SaveDataType.ListOfClass)
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
    }
}
