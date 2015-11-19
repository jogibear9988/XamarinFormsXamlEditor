using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using XamarinFormsClasses.Enums;

using XamarinFormsClasses.Converters;
using TextAlignment = XamarinFormsClasses.Enums.TextAlignment;

namespace Xamarin.Forms
{
    public class Entry : InputView
    {
		public string Text
		{
			get { return (string)GetValue(TextProperty); }
			set { SetValue(TextProperty, value); }
		}

		public static readonly DependencyProperty TextProperty =
			DependencyProperty.Register("Text", typeof(string), typeof(Entry), new PropertyMetadata(null));

		public string Placeholder
		{
			get { return (string)GetValue(PlaceholderProperty); }
			set { SetValue(PlaceholderProperty, value); }
		}

		public static readonly DependencyProperty PlaceholderProperty =
			DependencyProperty.Register("Placeholder", typeof(string), typeof(Entry), new PropertyMetadata(null));

		public bool IsPassword
		{
			get { return (bool)GetValue(IsPasswordProperty); }
			set { SetValue(IsPasswordProperty, value); }
		}

		public static readonly DependencyProperty IsPasswordProperty =
			DependencyProperty.Register("IsPassword", typeof(bool), typeof(Entry), new PropertyMetadata(false));


		[TypeConverter(typeof(FontSizeConveter))]
		public double FontSize
		{
			get { return (double)GetValue(FontSizeProperty); }
			set { SetValue(FontSizeProperty, value); }
		}

		public static readonly DependencyProperty FontSizeProperty =
			DependencyProperty.Register("FontSize", typeof(double), typeof(Entry), new PropertyMetadata(10.0));





		public FontAttributes FontAttributes
		{
			get { return (FontAttributes)GetValue(FontAttributesProperty); }
			set { SetValue(FontAttributesProperty, value); }
		}

		public static readonly DependencyProperty FontAttributesProperty =
			DependencyProperty.Register("FontAttributes", typeof(FontAttributes), typeof(Entry), new PropertyMetadata(FontAttributes.None));





		public Color TextColor
		{
			get { return (Color)GetValue(TextColorProperty); }
			set { SetValue(TextColorProperty, value); }
		}

		public static readonly DependencyProperty TextColorProperty =
			DependencyProperty.Register("TextColor", typeof(Color), typeof(Entry), new PropertyMetadata(Colors.Black));




	}
}
