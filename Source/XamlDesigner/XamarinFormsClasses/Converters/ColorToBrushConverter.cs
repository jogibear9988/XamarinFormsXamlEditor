using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace XamarinFormsClasses.Converters
{
    public class ColorToBrushConverter : IValueConverter
    {
        public static ColorToBrushConverter Instance = new ColorToBrushConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                return new SolidColorBrush((Color)value);
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
