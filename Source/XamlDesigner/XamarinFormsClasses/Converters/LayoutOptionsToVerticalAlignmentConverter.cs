using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using XamarinFormsClasses.Enums;

namespace XamarinFormsClasses.Converters
{
    public class LayoutOptionsToVerticalAlignmentConverter : IValueConverter
    {
        public static LayoutOptionsToVerticalAlignmentConverter Instance = new LayoutOptionsToVerticalAlignmentConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (Equals(value, LayoutOptions.Start))
                return VerticalAlignment.Top;
            if (Equals(value, LayoutOptions.StartAndExpand))
                return VerticalAlignment.Top;
            if (Equals(value, LayoutOptions.Center))
                return VerticalAlignment.Center;
            if (Equals(value, LayoutOptions.CenterAndExpand))
                return VerticalAlignment.Center;
            if (Equals(value, LayoutOptions.End))
                return VerticalAlignment.Bottom;
            if (Equals(value, LayoutOptions.EndAndExpand))
                return VerticalAlignment.Bottom;
            if (Equals(value, LayoutOptions.Fill))
                return VerticalAlignment.Stretch;
            return VerticalAlignment.Stretch;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
