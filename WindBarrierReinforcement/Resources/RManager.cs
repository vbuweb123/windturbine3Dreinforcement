using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.Attributes;

namespace WindBarrierReinforcement.Resources
{
    public static class RManager
    {
        public static ResourceManager Manager { get; set; }

        public static ResourceManager CultureManager {get;set;}

        static RManager()
        {
            Manager = new ResourceManager( typeof(Resource));

            LoadCultureResourceFile(CurrentLanguage.Langugage);
        }
        //Loading Language File based on Attribute description
        
        public static void LoadCultureResourceFile(CultureLanguages Language)
        {
            Type t = typeof(CultureLanguages);
            FieldInfo fieldInfo = t.GetField(Enum.GetName(t, Language));
            if (fieldInfo == null) return;

            QualifiedTypeAttribute Attribute = fieldInfo.GetCustomAttribute(typeof(QualifiedTypeAttribute)) as QualifiedTypeAttribute;
            if (Attribute == null) return;

            Type Resourcetype = Type.GetType(Attribute.StringType);
            if (Resourcetype == null) return;

            ResourceManager rm = new ResourceManager(Resourcetype);
            if (rm == null) return;
            CultureManager = rm;
        }
        public static string GetWord(string Key)
        {
            return Manager.GetString(Key);
        }

        public static string GetCultureWord(string Key)
        {
            //return Ma
            if (CultureManager != null)
                return CultureManager.GetString(Key);
            else
                throw new InvalidProgramException("Culture Resource File Not Found");
        }
    }
}
