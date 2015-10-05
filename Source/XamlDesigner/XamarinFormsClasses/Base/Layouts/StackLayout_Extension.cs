using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using ICSharpCode.WpfDesign;
using ICSharpCode.WpfDesign.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Helper;
using XamarinFormsClasses.Base;
using XamarinFormsClasses.Converters;

namespace XamarinFormsClasses.Controls
{
	[ExtensionFor(typeof(StackLayout))]
	public class StackLayout_Extension : ViewExtension
    {
        public override FrameworkElement CreateView(DesignItem item)
        {
            var stackPanel = new System.Windows.Controls.StackPanel();
			stackPanel.Background = TransparentBrush.GetTransparentBrush();

	        foreach (var collectionElement in item.ContentProperty.CollectionElements)
	        {
				stackPanel.Children.Add(collectionElement.View);
	        }

            item.ContentProperty.CollectionElements.CollectionChanged += (sender, args) =>
            {
                if (args.Action == NotifyCollectionChangedAction.Add)
                {
                    foreach (DesignItem newItem in args.NewItems)
                    {
						stackPanel.Children.Add(newItem.View);
                    }
                }
                else if (args.Action == NotifyCollectionChangedAction.Remove)
                {
                    foreach (DesignItem oldItem in args.OldItems)
                    {
						stackPanel.Children.Remove(oldItem.View);
                    }
                }
            };

			return stackPanel;
        }

        
        public override void SetBindings(DesignItem item, FrameworkElement view)
        {
            base.SetBindings(item, view);

	        view.SetBinding(StackPanel.OrientationProperty, new Binding("Component.Orientation")
	        {
		        Converter = new LambdaConverter<StackOrientation, Orientation>(
			        value =>
			        {
				        if (value == StackOrientation.Horizontal)
					        return Orientation.Horizontal;
				        return Orientation.Vertical;
			        }),
		        Source = item,
	        });
        }        
    }
}
