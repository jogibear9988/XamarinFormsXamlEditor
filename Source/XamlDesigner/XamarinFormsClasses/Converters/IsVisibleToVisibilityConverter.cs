using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace XamarinFormsClasses.Converters
{
    public class IsVisibleToVisibilityConverter : IValueConverter
    {
        public static IsVisibleToVisibilityConverter Instance = new IsVisibleToVisibilityConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (Equals(value, true))
                return Visibility.Visible;
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
