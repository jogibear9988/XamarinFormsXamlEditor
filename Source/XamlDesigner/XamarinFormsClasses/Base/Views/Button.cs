﻿using System.ComponentModel;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;
using XamarinFormsClasses.Converters;
using XamarinFormsClasses.Enums;

namespace Xamarin.Forms
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
            DependencyProperty.Register("Text", typeof(string), typeof(Button), new PropertyMetadata(null));

        [TypeConverter(typeof(FontSizeConveter))]
        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        public static readonly DependencyProperty FontSizeProperty =
            DependencyProperty.Register("FontSize", typeof(double), typeof(Button), new PropertyMetadata(10.0));

        public FontAttributes FontAttributes
        {
            get { return (FontAttributes)GetValue(FontAttributesProperty); }
            set { SetValue(FontAttributesProperty, value); }
        }

        public static readonly DependencyProperty FontAttributesProperty =
            DependencyProperty.Register("FontAttributes", typeof(FontAttributes), typeof(Button), new PropertyMetadata(FontAttributes.None));

        public Color TextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        public static readonly DependencyProperty TextColorProperty =
            DependencyProperty.Register("TextColor", typeof(Color), typeof(Button), new PropertyMetadata(Colors.Black));

		public ICommand Command
		{
			get { return (ICommand)GetValue(CommandProperty); }
			set { SetValue(CommandProperty, value); }
		}

		public static readonly DependencyProperty CommandProperty =
			DependencyProperty.Register("Command", typeof(ICommand), typeof(Button), new PropertyMetadata());

	}
}
