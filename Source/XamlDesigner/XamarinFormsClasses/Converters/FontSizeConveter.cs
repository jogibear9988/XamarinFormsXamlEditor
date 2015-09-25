using System;
using System.ComponentModel;
using System.Globalization;
using XamarinFormsClasses.Enums;

namespace XamarinFormsClasses.Converters
{
    public class FontSizeConveter : TypeConverter
    {
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            return Convert.ToDouble(Enum.Parse(typeof (FontSize), value as string));
        }      
    }
}
