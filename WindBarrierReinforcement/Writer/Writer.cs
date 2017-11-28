using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WindBarrierReinforcement.Common.Reflected;
using System.Reflection;
using WindBarrierReinforcement.Common.Attributes;

namespace WindBarrierReinforcement.Writer
{
    public static class Writer
    {
        static List<PropertyDataInfo> properties;

        private static string currentDirectory;

        static Writer()
        {
            currentDirectory = Directory.GetCurrentDirectory();
            properties = new List<PropertyDataInfo>();
        }

        public static void WriteTexts()
        {
            string filename = currentDirectory + "\\" + "temp.txt";

            List<string> toprint = new List<string>();

            foreach (var item in properties)
            {
                StringBuilder sb = new StringBuilder();
                KeyNameAttribute attribute = item.PropertyInfo.GetCustomAttribute(typeof(KeyNameAttribute)) as KeyNameAttribute;
                if (attribute != null)
                {
                    sb.Append("{Key}");
                    sb.Append(attribute.KeyName);
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
