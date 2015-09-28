using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using ICSharpCode.WpfDesign;
using ICSharpCode.WpfDesign.Extensions;
using XamarinFormsClasses.Base;
using XamarinFormsClasses.Base.Layouts;
using XamarinFormsClasses.Converters;

namespace XamarinFormsClasses.Controls
{  
    [ExtensionFor(typeof(Grid))]
    public class Grid_Extension : ViewExtension
    {
        public override FrameworkElement CreateView(DesignItem item)
        {
            var grid = new System.Windows.Controls.Grid();

	        foreach (var collectionElement in item.ContentProperty.CollectionElements)
	        {
		        grid.Children.Add(collectionElement.View);
	        }

            item.ContentProperty.CollectionElements.CollectionChanged += (sender, args) =>
            {
                if (args.Action == NotifyCollectionChangedAction.Add)
                {
                    foreach (DesignItem newItem in args.NewItems)
                    {
                        grid.Children.Add(newItem.View);
                    }
                }
                else if (args.Action == NotifyCollectionChangedAction.Remove)
                {
                    foreach (DesignItem oldItem in args.OldItems)
                    {
                        grid.Children.Remove(oldItem.View);
                    }
                }
            };

            return grid;
        }

        
        public override void SetBindings(DesignItem item, FrameworkElement view)
        {
            base.SetBindings(item, view);
        }        
    }
}
