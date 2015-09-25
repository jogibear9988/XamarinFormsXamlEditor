using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using TextAlignment = XamarinFormsClasses.Enums.TextAlignment;

namespace XamarinFormsClasses.Converters
{
    public class YAlignToVerticalAlignmentConverter : IValueConverter
    {
        public static YAlignToVerticalAlignmentConverter Instance = new YAlignToVerticalAlignmentConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (Equals(value, TextAlignment.Start))
                return VerticalAlignment.Top;
            if (Equals(value, TextAlignment.Center))
                return VerticalAlignment.Center;
            return VerticalAlignment.Bottom;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
