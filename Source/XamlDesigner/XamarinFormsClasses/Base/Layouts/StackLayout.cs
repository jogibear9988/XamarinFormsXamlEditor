using System.Windows;

namespace Xamarin.Forms
{
    public class StackLayout : Layout
    {
		public double Spacing
		{
			get { return (double)GetValue(SpacingProperty); }
			set { SetValue(SpacingProperty, value); }
		}

		public static readonly DependencyProperty SpacingProperty =
			DependencyProperty.Register("Spacing", typeof(double), typeof(StackLayout), new PropertyMetadata(0.0));
		
		public StackOrientation Orientation
		{
			get { return (StackOrientation)GetValue(OrientationProperty); }
			set { SetValue(OrientationProperty, value); }
		}

		public static readonly DependencyProperty OrientationProperty =
			DependencyProperty.Register("Orientation", typeof(StackOrientation), typeof(StackLayout), new PropertyMetadata(StackOrientation.Vertical));		
    }
}
