using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using TextAlignment = XamarinFormsClasses.Enums.TextAlignment;

namespace XamarinFormsClasses.Converters
{
    public class XAlignToHorizontalAlignmentConverter : IValueConverter
    {
        public static XAlignToHorizontalAlignmentConverter Instance = new XAlignToHorizontalAlignmentConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (Equals(value, TextAlignment.Start))
                return HorizontalAlignment.Left;
            if (Equals(value, TextAlignment.Center))
                return HorizontalAlignment.Center;
            return HorizontalAlignment.Right;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
