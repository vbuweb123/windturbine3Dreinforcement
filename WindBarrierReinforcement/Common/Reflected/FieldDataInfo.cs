using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindBarrierReinforcement.Common.Reflected
{
    public class FieldDataInfo
    {
        public FieldInfo FieldInfo { get; set; }
        public object Context { get; set; }

        private FieldDataInfo()
        {
        }
        public static FieldDataInfo Register<T>(T Context, Expression<Func<T, object>> binding)
        {
            FieldDataInfo obj = new FieldDataInfo();
            DataInfo dataInfo = Reflected.ObjGetDataInfo<T>(Context, binding);

            if (dataInfo.DataInfoType == EDataInfoType.PropertyInfo)
                throw new Exception("Invalid field queried");

            FieldDataInfo result = new FieldDataInfo();

            result.FieldInfo = (FieldInfo)dataInfo.PropertyFieldInfo;
            result.Context = dataInfo.Context;
            return result;
        }
        public static FieldDataInfo Register<T>(T context, string binding)
        {
            FieldDataInfo obj = new FieldDataInfo();
            DataInfo dataInfo = Reflected.ObjGetDataInfo(context, binding);

            if (dataInfo.DataInfoType == EDataInfoType.PropertyInfo)
                throw new Exception("Invalid field queried");

            FieldDataInfo result = new FieldDataInfo();

            result.FieldInfo = (FieldInfo)dataInfo.PropertyFieldInfo;
            result.Context = dataInfo.Context;
            return result;
        }
        public object GetValue()
        {
            return this.FieldInfo.GetValue(Context);
        }
        public T GetValue<T>()
        {
            return (T)this.FieldInfo.GetValue(Context);
        }
        public void SetValue(object value)
        {
            this.FieldInfo.SetValue(Context, value);
        }
        public void SetValue<T>(T value)
        {
            this.FieldInfo.SetValue(Context, value);
        }
    }
}
