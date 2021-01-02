
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace Calculator
{
    public static class GLOBAL
    {
        #region Properties
        public static double TAX = 0.13;
        public static double JNC_SERVICE_WEIGHT = 0.05;
        public static double CUSTOM_SERVICE_WEIGHT = 0;
        public static double UBEREATS_SERVICE_WEIGHT = 0.113;
        public static double HURRYPANDA_SERVICE_WEIGHT = 0;
        #endregion

        #region Methods
        public static string GetDescription(Enum value) 
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
        #endregion
    }
}
