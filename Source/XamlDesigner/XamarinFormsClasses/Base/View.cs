using System.Windows;
using XamarinFormsClasses.Enums;

namespace Xamarin.Forms
{
    public class View : VisualElement
    {
        public LayoutOptions VerticalOptions
        {
            get { return (LayoutOptions)GetValue(VerticalOptionsProperty); }
            set { SetValue(VerticalOptionsProperty, value); }
        }

        public static readonly DependencyProperty VerticalOptionsProperty =
            DependencyProperty.Register("VerticalOptions", typeof(LayoutOptions), typeof(View), new PropertyMetadata(LayoutOptions.Fill));

        public LayoutOptions HorizontalOptions
        {
            get { return (LayoutOptions)GetValue(HorizontalOptionsProperty); }
            set { SetValue(HorizontalOptionsProperty, value); }
        }

        public static readonly DependencyProperty HorizontalOptionsProperty =
            DependencyProperty.Register("HorizontalOptions", typeof(LayoutOptions), typeof(View), new PropertyMetadata(LayoutOptions.Fill));

        
        
    }
}
