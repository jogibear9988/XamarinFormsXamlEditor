using System.Windows;
using System.Windows.Markup;

namespace Xamarin.Forms
{
	[ContentProperty("Content")]
    public class ContentView : Layout
    {
		public View Content
		{
			get { return (View)GetValue(ContentProperty); }
			set { SetValue(ContentProperty, value); }
		}

		public static readonly DependencyProperty ContentProperty =
			DependencyProperty.Register("Content", typeof(View), typeof(ContentView), new PropertyMetadata(null));
    }
}
