using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WBR_Common.Common.Reflected
{
    public class PropertyDataInfo
    {
        public PropertyInfo PropertyInfo { get; set; }
        public object Context { get; set; }

        private PropertyDataInfo()
        {
        }

        public static PropertyDataInfo GetInfo<T>(T context, Expression<Func<T, object>> binding)
        {
            DataInfo dataInfo = Reflected.ObjGetDataInfo<T>(context, binding);
            if (dataInfo.DataInfoType == EDataInfoType.FieldInfo)
                throw new Exception("Invalid property queried");

            PropertyDataInfo result = new PropertyDataInfo();

            result.PropertyInfo = (PropertyInfo)dataInfo.PropertyFieldInfo;
            result.Context = dataInfo.Context;
            return result;
        }
        public static PropertyDataInfo GetInfo<T>(T context, string binding)
        {
            PropertyDataInfo obj = new PropertyDataInfo();
            DataInfo dataInfo = Reflected.ObjGetDataInfo(context, binding);

            if (dataInfo.DataInfoType == EDataInfoType.FieldInfo)
                throw new Exception("Invalid property queried");

            PropertyDataInfo result = new PropertyDataInfo();

            result.PropertyInfo = (PropertyInfo)dataInfo.PropertyFieldInfo;
            result.Context = dataInfo.Context;
            return result;
        }
        public object GetValue()
        {
            return this.PropertyInfo.GetValue(Context);
        }
        public T GetValue<T>()
        {
            return (T)this.PropertyInfo.GetValue(Context);
        }
        public void SetValue(object value)
        {
            this.PropertyInfo.SetValue(Context, value);
        }
        public void SetValue<T>(T value)
        {
            this.PropertyInfo.SetValue(Context, value);
        }
    }
}