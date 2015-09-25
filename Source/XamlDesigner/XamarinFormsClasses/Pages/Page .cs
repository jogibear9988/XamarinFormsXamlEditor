﻿using System.Windows;
using System.Windows.Markup;
using XamarinFormsClasses.Base;

[assembly: XmlnsDefinition("http://xamarin.com/schemas/2014/forms", "XamarinFormsClasses.Pages")]

namespace XamarinFormsClasses.Pages
{
    public class Page : VisualElement
    {
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(ContentPage), new PropertyMetadata(null));

        public Thickness Padding
        {
            get { return (Thickness)GetValue(PaddingProperty); }
            set { SetValue(PaddingProperty, value); }
        }
        
        public static readonly DependencyProperty PaddingProperty =
            DependencyProperty.Register("Padding", typeof(Thickness), typeof(Page), new PropertyMetadata(new Thickness(1)));

        
        
    }
}
