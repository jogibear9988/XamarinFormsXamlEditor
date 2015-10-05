using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Xamarin.Forms.Helper
{
	public static class TransparentBrush
	{
		private static Brush transparentImageBrush;

		static TransparentBrush()
		{
			BitmapImage img = new BitmapImage();
			img.BeginInit();
			img.UriSource = new Uri("pack://application:,,,/Xamarin.Forms.Core;component/Resources/Images/transparent.png");
			img.EndInit();
			transparentImageBrush = new ImageBrush(img)
			{
				AlignmentX = AlignmentX.Left,
				AlignmentY = AlignmentY.Top,
				Stretch = Stretch.None,
				TileMode = TileMode.Tile,
				Viewport = new Rect(0,0,16,16),
				ViewportUnits = BrushMappingMode.Absolute
			};
		}

		public static Brush GetTransparentBrush()
		{
			return transparentImageBrush;
			//return Brushes.Transparent;
		}
	}
}
