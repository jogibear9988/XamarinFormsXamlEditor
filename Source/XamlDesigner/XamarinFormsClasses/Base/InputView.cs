using System.Windows;
using XamarinFormsClasses.Enums;

namespace Xamarin.Forms
{
    public class InputView : View
    {
		public Keyboard Keyboard
		{
			get { return (Keyboard)GetValue(KeyboardProperty); }
			set { SetValue(KeyboardProperty, value); }
		}

		public static readonly DependencyProperty KeyboardProperty =
			DependencyProperty.Register("Keyboard", typeof(Keyboard), typeof(InputView), new PropertyMetadata(null));

	}
}
