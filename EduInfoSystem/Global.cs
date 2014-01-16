﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace EduInfoSystem
{
    public static class GlobalSettings
    {
    }
    internal static class GlobalControlCache
    {
        static Dictionary<Type, Control> controlCache = new Dictionary<Type, Control>();
        public static void ReserveControl(Control c)
        {
            if (controlCache.ContainsKey(c.GetType()))
            {
            }
            else
            {
                controlCache.Add(c.GetType(), c);
            }
        }
        public static bool ExistControl(Type p)
        {
            return controlCache.ContainsKey(p);
        }
        public static T GetInstance<T>() where T : Control
        {
            return controlCache[typeof(T)] as T;
        }
    }
}
