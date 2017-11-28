using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindBarrierReinforcement.Common.Reflected
{
    public class DataInfo
    {
        public object Context { get; set; }

        public object PropertyFieldInfo
        {
            get; private set;
        }

        public EDataInfoType DataInfoType { get; private set; }

        public DataInfo(object Context, object DataInfo)
        {
            if (DataInfo is PropertyInfo)
                this.DataInfoType = EDataInfoType.PropertyInfo;
            else if (DataInfo is FieldInfo)
                this.DataInfoType = EDataInfoType.FieldInfo;
            else
                throw new Exception("Invalid Data info type");
            this.PropertyFieldInfo = DataInfo;
            this.Context = Context;
        }

        public object GetValue()
        {
            if (this.DataInfoType == EDataInfoType.FieldInfo)
                return ((FieldInfo)this.PropertyFieldInfo).GetValue(Context);
            else
                return ((PropertyInfo)this.PropertyFieldInfo).GetValue(Context);
        }

        public T GetValue<T>()
        {
            if (this.DataInfoType == EDataInfoType.FieldInfo)
                return (T)((FieldInfo)this.PropertyFieldInfo).GetValue(Context);
            else
                return (T)((PropertyInfo)this.PropertyFieldInfo).GetValue(Context);
        }
        public void SetValue(object value)
        {
            if (this.DataInfoType == EDataInfoType.FieldInfo)
                ((FieldInfo)this.PropertyFieldInfo).SetValue(Context, value);
            else
                ((PropertyInfo)this.PropertyFieldInfo).SetValue(Context, value);
        }
        public void SetValue<T>(T value)
        {
            if (this.DataInfoType == EDataInfoType.FieldInfo)
                ((FieldInfo)this.PropertyFieldInfo).SetValue(Context, value);
            else
                ((PropertyInfo)this.PropertyFieldInfo).SetValue(Context, value);
        }
    }
}

