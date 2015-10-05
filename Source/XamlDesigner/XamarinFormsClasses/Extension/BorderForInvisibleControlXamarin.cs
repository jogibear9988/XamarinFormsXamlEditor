using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ICSharpCode.WpfDesign.Adorners;
using ICSharpCode.WpfDesign.Extensions;
using Xamarin.Forms;

namespace ICSharpCode.WpfDesign.Designer.Extensions
{
	[ExtensionFor(typeof(Layout))]
	public class BorderForInvisibleControlXamarin : PermanentAdornerProvider
	{
		AdornerPanel adornerPanel;
		AdornerPanel cachedAdornerPanel;

		protected override void OnInitialized()
		{
			base.OnInitialized();

			ExtendedItem.PropertyChanged += (s, e) => UpdateAdorner();

			UpdateAdorner();			
		}

		private void UpdateAdorner()
		{
			CreateAdorner();							
		}

		private void CreateAdorner()
		{
			if (adornerPanel == null)
			{

				if (cachedAdornerPanel == null)
				{
					cachedAdornerPanel = new AdornerPanel();
					cachedAdornerPanel.Order = AdornerOrder.Background;
					var border = new Border();
					border.BorderThickness = new Thickness(1);
					border.BorderBrush = new SolidColorBrush(Color.FromRgb(0xCC, 0xCC, 0xCC));
					border.IsHitTestVisible = false;
					AdornerPanel.SetPlacement(border, AdornerPlacement.FillContent);
					cachedAdornerPanel.Children.Add(border);
				}

				adornerPanel = cachedAdornerPanel;
				Adorners.Add(adornerPanel);
			}
		}
	}
}
