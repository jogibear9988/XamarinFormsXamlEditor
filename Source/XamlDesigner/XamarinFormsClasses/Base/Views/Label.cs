using System.ComponentModel;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;
using XamarinFormsClasses.Converters;
using XamarinFormsClasses.Enums;
using TextAlignment = XamarinFormsClasses.Enums.TextAlignment;

namespace Xamarin.Forms
{
    [ContentProperty("Text")]
    public class Label : View
    {
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(Label), new PropertyMetadata(null));



        public TextAlignment XAlign
        {
            get { return (TextAlignment)GetValue(XAlignProperty); }
            set { SetValue(XAlignProperty, value); }
        }

        public static readonly DependencyProperty XAlignProperty =
            DependencyProperty.Register("XAlign", typeof(TextAlignment), typeof(Label), new PropertyMetadata(TextAlignment.Start));




        public TextAlignment YAlign
        {
            get { return (TextAlignment)GetValue(YAlignProperty); }
            set { SetValue(YAlignProperty, value); }
        }

        public static readonly DependencyProperty YAlignProperty =
            DependencyProperty.Register("YAlign", typeof(TextAlignment), typeof(Label), new PropertyMetadata(TextAlignment.Start));


        [TypeConverter(typeof(FontSizeConveter))]
        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        public static readonly DependencyProperty FontSizeProperty =
            DependencyProperty.Register("FontSize", typeof(double), typeof(Label), new PropertyMetadata(10.0));





        public FontAttributes FontAttributes
        {
            get { return (FontAttributes)GetValue(FontAttributesProperty); }
            set { SetValue(FontAttributesProperty, value); }
        }

        public static readonly DependencyProperty FontAttributesProperty =
            DependencyProperty.Register("FontAttributes", typeof(FontAttributes), typeof(Label), new PropertyMetadata(FontAttributes.None));





        public Color TextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        public static readonly DependencyProperty TextColorProperty =
            DependencyProperty.Register("TextColor", typeof(Color), typeof(Label), new PropertyMetadata(Colors.Black));

                
        
        
    }
}
