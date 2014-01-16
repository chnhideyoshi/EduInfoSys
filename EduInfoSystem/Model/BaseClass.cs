using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace EduInfoSystem.Model
{
    public class BaseObject
    {
        public void SetValue(string propertyName, object value)
        {
            this.GetType().GetProperty(propertyName).SetValue(this, value,null);
        }
        public object GetValue(string propertyName)
        {
            return this.GetType().GetProperty(propertyName).GetValue(this, null);
        }
        public static void SetValue(object obj,string propertyName, object value)
        {
             obj.GetType().GetProperty(propertyName).SetValue(obj, value,null);
        }
        public static object GetValue(object obj,string propertyName)
        {
             return obj.GetType().GetProperty(propertyName).GetValue(obj, null);
        }
        public static string[] GetProperties(object obj)
        {
            System.Reflection.PropertyInfo[] fields = obj.GetType().GetProperties();
            string[] ps=new string[fields.Length];
            for (int i = 0; i < fields.Length; i++)
            {
                ps[i] = fields[i].Name;
            }
            return ps;
        }
        public static string[] GetProperties(Type type)
        {
            System.Reflection.PropertyInfo[] fields = type.GetProperties();
            string[] ps = new string[fields.Length];
            for (int i = 0; i < fields.Length; i++)
            {
                ps[i] = fields[i].Name;
            }
            return ps;
        }
        public static SortModes GetSortMode(Type type, string propertyName)
        {
            try
            {
                PropertyInfo info = type.GetProperty(propertyName);
                object[] objAttrs = info.GetCustomAttributes(typeof(SortModeAttribute), true);
                if (objAttrs.Length > 0)
                {
                    SortModeAttribute attr = objAttrs[0] as SortModeAttribute;
                    return attr.SortMode;
                }
                return SortModes.String;
            }
            catch
            {
                return SortModes.String;
            }
        }
        public static string[] GetRealNames(Type type)
        {
            string[] pros=GetProperties(type);
            string[] rns=new string[pros.Length];
            for (int i = 0; i < pros.Length; i++)
            {
                rns[i] = GetRealName(type, pros[i]);
            }
            return rns;
        }
        public static string GetRealName(Type type, string propertyName)
        {
            try
            {
                PropertyInfo info = type.GetProperty(propertyName);
                object[] objAttrs = info.GetCustomAttributes(typeof(RealNameAttribute), true);
                if (objAttrs.Length > 0)
                {
                    RealNameAttribute attr = objAttrs[0] as RealNameAttribute;
                    return attr.RealName;
                }
                return "未定义";
            }
            catch
            {
                return "未定义";
            }
        }
        public static string GetNullDescription(PropertyInfo info)
        {
            try
            {
                object[] objAttrs = info.GetCustomAttributes(typeof(NullDescriptionAttribute), true);
                if (objAttrs.Length > 0)
                {
                    NullDescriptionAttribute attr = objAttrs[0] as NullDescriptionAttribute;
                    return attr.NullDescription;
                }
                return "无";
            }
            catch
            {
                return "无";
            }
        }
        public static T GetClone<T>(T obj)
        {
            if (obj == null)
                throw new Exception();
            T newObj = Activator.CreateInstance<T>();
            PropertyInfo[] ps = typeof(T).GetProperties();
            for (int i = 0; i < ps.Length; i++)
            {
                ps[i].SetValue(newObj, BaseObject.GetValue(obj, ps[i].Name),null);
            }
            return newObj;
        }
        public static void SetSameValue<T>(T target, T template)
        {
            if (template == null||target==null)
                throw new Exception();
            T newObj = Activator.CreateInstance<T>();
            PropertyInfo[] ps = typeof(T).GetProperties();
            for (int i = 0; i < ps.Length; i++)
            {
                ps[i].SetValue(target, BaseObject.GetValue(template, ps[i].Name), null);
            }
        }
        public static List<T1> GetPropertySet<T1, T2>(List<T2> objlist,string propertyName)
        {
            List<T1> list = new List<T1>();
            for (int i = 0; i < objlist.Count; i++)
            {
                list.Add((T1)(BaseObject.GetValue(objlist[i], propertyName)));
            }
            return list;
        }
    }
    public class RealNameAttribute : Attribute
    {
        public string RealName { get; set; }
    }
    public class NullDescriptionAttribute : Attribute
    {
        public string NullDescription { get; set; }
    }
    public class SortModeAttribute : Attribute
    {
       
        public SortModes SortMode{get;set;}
    }
     public enum SortModes
        {
            String=0,Number=1,Date=2
        }
}
