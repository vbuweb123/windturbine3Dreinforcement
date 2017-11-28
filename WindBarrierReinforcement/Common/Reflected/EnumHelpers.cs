using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.Attributes;
using WindBarrierReinforcement.Common.Eng;

namespace WindBarrierReinforcement.Common.Reflected
{
    public static class EnumHelpers
    {
        public static string GetDisplayTextValue(Type enumType, int enumIndex)
        {

            string fieldName = Enum.GetName(enumType, enumIndex);

            if (fieldName == null) return null;

            FieldInfo fieldInfo = enumType.GetField(fieldName);

            if (fieldInfo == null) return null;

            DisplayByResourceKeyAttribute Attribute = fieldInfo.GetCustomAttribute(typeof(DisplayByResourceKeyAttribute)) as DisplayByResourceKeyAttribute;

            if (Attribute == null)
            {
                return fieldName;
            }

            return Attribute.GetResourceValue();
        }

        public static List<string> GetEnumDisplayText(Type enumtype)
        {
            List<string> names = new List<string>();
            Array fields = Enum.GetValues(enumtype);

            foreach (object field in fields)
            {
                names.Add(GetDisplayTextValue(enumtype, (int)field));
            }
            return names;
        }

    }
}
