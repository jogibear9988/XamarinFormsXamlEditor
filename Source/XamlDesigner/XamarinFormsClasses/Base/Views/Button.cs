﻿using System.ComponentModel;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;
using XamarinFormsClasses.Base;
using XamarinFormsClasses.Converters;
using XamarinFormsClasses.Enums;
using TextAlignment = XamarinFormsClasses.Enums.TextAlignment;

[assembly: XmlnsDefinition("http://xamarin.com/schemas/2014/forms", "XamarinFormsClasses.Controls")]

namespace XamarinFormsClasses.Controls
{
    [ContentProperty("Text")]
    public class Button : View
    {
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(Label), new PropertyMetadata(null));

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
            DependencyProperty.Register("FontAttributes", typeof(FontAttributes), typeof(Label), new PropertyMetadata(Enums.FontAttributes.None));

        public Color TextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        public static readonly DependencyProperty TextColorProperty =
            DependencyProperty.Register("TextColor", typeof(Color), typeof(Label), new PropertyMetadata(Colors.Black));

    }
}
