
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Calculator.View.Converters
{
    class RelationConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var target1 = (Users)values[0];
            var target2 = (Users)values[1];
            var relation = (Relation)values[2];
            return GLOBAL.FormatRelatoinString(target1, target2, relation);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }


    }
}
