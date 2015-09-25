using System;
using System.Globalization;
using System.Windows.Data;

namespace XamarinFormsClasses.Converters
{
    public class MultiBindingLambdaConverter<T>  : IMultiValueConverter
    {
        private Func<object[], T> func;

        public MultiBindingLambdaConverter(Func<object[], T> func)
        {
            this.func = func;
        }

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return func(values); 
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
