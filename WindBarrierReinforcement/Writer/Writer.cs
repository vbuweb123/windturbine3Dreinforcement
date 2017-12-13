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

namespace WindBarrierReinforcement.Writer
{
    public static class Writer
    {
        static List<PropertyDataInfo> properties;

        private static string currentDirectory;

        private static GlobalDataModels GlobalDataModels;

        public static void Save(GlobalDataModels globalDataModels)
        {
            XmlDocument Document = new XmlDocument();
            Document.PreserveWhitespace = true;
            //craete Root Node
            XmlNode root = Document.CreateElement("ReinforcementData");

            XmlAttribute nowDate = Document.CreateAttribute("CreatedAt");
            nowDate.Value = DateTime.Now.ToUniversalTime().ToString();
            root.Attributes.Append(nowDate);

            Document.AppendChild(root);

            currentDirectory = Directory.GetCurrentDirectory();

            FileStream fs = new FileStream(currentDirectory + "\\temp.xml", FileMode.Create);
            Document.Save(fs);
        }
        private static void CollectData()
        {

        }
        public static void WriteTexts()
        {
            string filename = currentDirectory + "\\" + "temp.txt";

            List<string> toprint = new List<string>();

            foreach (var item in properties)
            {
                StringBuilder sb = new StringBuilder();
                SaveKeyCodeAttribute attribute = item.PropertyInfo.GetCustomAttribute(typeof(SaveKeyCodeAttribute)) as SaveKeyCodeAttribute;
                if (attribute != null)
                {
                    sb.Append("{Key}");
                    sb.Append(attribute.KeyCode);
                }
                sb.Append("{Value}");
                sb.Append(item.GetValue().ToString());

                toprint.Add(sb.ToString());
            }
            //Uri path = new Uri(new Uri(currentDirectory), new Uri(filename));
            File.WriteAllLines(filename, toprint.ToArray());
        }
        public static void AddElementToDisplay(PropertyDataInfo datainfo)
        {
            properties.Add(datainfo);
        }
    }
}
