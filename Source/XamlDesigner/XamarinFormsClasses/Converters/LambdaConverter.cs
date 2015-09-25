using System;
using System.Globalization;
using System.Windows.Data;

namespace XamarinFormsClasses.Converters
{
    public class LambdaConverter<S, T> : IValueConverter
    {
        private Func<S, T> func; 

        public LambdaConverter(Func<S, T> func )
        {
            this.func = func;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return func((S)value);                
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
