using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace XamarinFormsClasses.Converters
{
    public class RotationToAngleInTransFormGroupConverter : IValueConverter
    {
        public static RotationToAngleInTransFormGroupConverter Instance = new RotationToAngleInTransFormGroupConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                var rotateTransform = ((TransformGroup)parameter).Children[0] as RotateTransform;
                rotateTransform.Angle = ((double) value);
            }

            return parameter;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
