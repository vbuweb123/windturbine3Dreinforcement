using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindBarrierReinforcement.Common.Reflected
{
        public static class Reflected
        {
            /// <summary>
            /// Returns the last property name accessed as string. 
            /// Exp : X=>X.ABC.DEF ==> DEF
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="expression"></param>
            /// <returns></returns>
            public static string ObjGetLastPropertyName<T>(Expression<Func<T, object>> expression)
            {
                if (expression.Body is MemberExpression)
                {
                    var member = expression.Body as MemberExpression;
                    if (member != null)
                    {
                        return member.Member.Name;
                    }
                }
                else if (expression.Body is UnaryExpression)
                {
                    var member = expression.Body as UnaryExpression;
                    if (member != null)
                    {
                        return ((MemberExpression)member.Operand).Member.Name;
                    }
                }
                return String.Empty;
            }

            public static string ObjGetPropertyPath<T>(Expression<Func<T, object>> expression)
            {
                var unformatted = expression.Body.ToString();
                if (unformatted.Contains("("))
                {
                    int startRemoveIndex = unformatted.IndexOf("(");
                    int endRemoveIndex = unformatted.IndexOf(")");
                    unformatted = unformatted.Substring(startRemoveIndex + 1, endRemoveIndex - startRemoveIndex - 1);
                }

                if (!unformatted.Contains("."))
                    return null;
                //just extra
                var removeparts = unformatted.TakeWhile((ch) => ch != '}' && ch != ')' && ch != '{' && ch != '(').ToList();

                StringBuilder listvalues = new StringBuilder();
                //first is the object short name x in x=>x.hey
                //second is the point .
                for (var index = 2; index < removeparts.Count; index++)
                    listvalues.Append(removeparts[index]);

                return listvalues.ToString();
            }

            public static object ObjGetDataValue<T>(this object _object, Expression<Func<T, object>> expression)
            {
                DataInfo dataInfo = Reflected.ObjGetDataInfo<T>(_object, expression);
                return dataInfo.GetValue();
            }

            public static void ObjSetDataValue<T>(this T _object, Expression<Func<T, object>> expression, object value)
            {
                DataInfo dataInfo = Reflected.ObjGetDataInfo<T>(_object, expression);
                dataInfo.SetValue(value);
            }

            public static DataInfo ObjGetDataInfo<T>(this object _object, Expression<Func<T, object>> expression)
            {
                return ObjGetDataInfo(_object, Reflected.ObjGetPropertyPath<T>(expression));
            }

            public static DataInfo ObjGetDataInfo(this object _object, string binding)
            {
                string[] _params = binding.Split('.');

                object LastContext = _object;
                object LastObject = _object;

                PropertyInfo propertyInfo = null, LastPropertyInfo = null;
                FieldInfo fieldInfo = null, LastFieldInfo = null;

                for (var i = 0; i < _params.Count(); i++)
                {
                    string _param = _params[i];

                    Type t = LastObject.GetType();
                    propertyInfo = t.GetProperty(_param, BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
                    fieldInfo = t.GetField(_param, BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);

                    if (propertyInfo != null)
                    {
                        LastPropertyInfo = propertyInfo;
                        LastContext = LastObject;
                        LastObject = LastPropertyInfo.GetValue(LastObject);
                        LastFieldInfo = null;
                    }
                    else if (fieldInfo != null)
                    {
                        LastPropertyInfo = null;
                        LastFieldInfo = fieldInfo;
                        LastContext = LastObject;
                        LastObject = LastFieldInfo.GetValue(LastObject);
                    }
                    else
                    {
                        throw new Exception("Field/Property not found");
                    }
                }

                if (LastPropertyInfo != null)
                    return new DataInfo(LastContext, LastPropertyInfo);
                else
                    return new DataInfo(LastContext, LastFieldInfo);
            }
        }
    }

