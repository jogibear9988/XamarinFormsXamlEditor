using System.Collections.Specialized;
using System.Windows;
using System.Windows.Data;
using ICSharpCode.WpfDesign;
using ICSharpCode.WpfDesign.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Helper;
using XamarinFormsClasses.Base;
using XamarinFormsClasses.Converters;

namespace XamarinFormsClasses.Controls
{
    public class TabbedPageView : System.Windows.Controls.Label
    {
        public TabbedPageView()
        {
            this.HorizontalAlignment = HorizontalAlignment.Center;
            this.VerticalAlignment = VerticalAlignment.Top;
        }
    }

    [ExtensionFor(typeof(TabbedPage))]
    public class TabbedPageViewExtension : ViewExtension
    {
		public override FrameworkElement CreateView(DesignItem item)
		{
			var tabcontrol = new System.Windows.Controls.TabControl();
			tabcontrol.Background = TransparentBrush.GetTransparentBrush();

			foreach (var collectionElement in item.ContentProperty.CollectionElements)
			{
				tabcontrol.Items.Add(collectionElement.View);
			}

			item.ContentProperty.CollectionElements.CollectionChanged += (sender, args) =>
			{
				if (args.Action == NotifyCollectionChangedAction.Add)
				{
					foreach (DesignItem newItem in args.NewItems)
					{
						tabcontrol.Items.Add(newItem.View);
					}
				}
				else if (args.Action == NotifyCollectionChangedAction.Remove)
				{
					foreach (DesignItem oldItem in args.OldItems)
					{
						tabcontrol.Items.Remove(oldItem.View);
					}
				}
			};

			return tabcontrol;
		}

		public override void SetBindings(DesignItem item, FrameworkElement view)
        {
            base.SetBindings(item, view);

            view.SetBinding(LabelView.ContentProperty, new Binding("ContentProperty.ValueOnInstanceOrView") { Source = item });
            view.SetBinding(LabelView.VisibilityProperty, new Binding("Component.IsVisible") { Source = item, Converter = IsVisibleToVisibilityConverter.Instance });
            view.SetBinding(LabelView.HorizontalContentAlignmentProperty, new Binding("Component.XAlign") { Source = item, Converter = XAlignToHorizontalAlignmentConverter.Instance });
            view.SetBinding(LabelView.VerticalContentAlignmentProperty, new Binding("Component.YAlign") { Source = item, Converter = YAlignToVerticalAlignmentConverter.Instance });
            view.SetBinding(LabelView.FontSizeProperty, new Binding("Component.FontSize") { Source = item });
            view.SetBinding(LabelView.ForegroundProperty, new Binding("Component.TextColor") { Source = item, Converter = ColorToBrushConverter.Instance });
        }        
    }
}
