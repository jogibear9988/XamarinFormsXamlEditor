using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using XamarinFormsClasses.Enums;

namespace XamarinFormsClasses.Converters
{
    public class LayoutOptionsToHorizontalAlignmentConverter : IValueConverter
    {
        public static LayoutOptionsToHorizontalAlignmentConverter Instance = new LayoutOptionsToHorizontalAlignmentConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (Equals(value, LayoutOptions.Start))
                return HorizontalAlignment.Left;
            if (Equals(value, LayoutOptions.StartAndExpand))
                return HorizontalAlignment.Left;
            if (Equals(value, LayoutOptions.Center))
                return HorizontalAlignment.Center;
            if (Equals(value, LayoutOptions.CenterAndExpand))
                return HorizontalAlignment.Center;
            if (Equals(value, LayoutOptions.End))
                return HorizontalAlignment.Right;
            if (Equals(value, LayoutOptions.EndAndExpand))
                return HorizontalAlignment.Right;
            if (Equals(value, LayoutOptions.Fill))
                return HorizontalAlignment.Stretch;
            return HorizontalAlignment.Stretch;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
