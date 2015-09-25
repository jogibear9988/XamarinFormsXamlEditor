using System.Windows;
using System.Windows.Markup;
using XamarinFormsClasses.Base;

[assembly: XmlnsDefinition("http://xamarin.com/schemas/2014/forms", "XamarinFormsClasses.Pages")]

namespace XamarinFormsClasses.Pages
{
    [ContentProperty("Content")]
    public class ContentPage : Page
    {
        public View Content
        {
            get { return (View)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        public static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register("Content", typeof(View), typeof(ContentPage), new PropertyMetadata(null));        
    }
}
