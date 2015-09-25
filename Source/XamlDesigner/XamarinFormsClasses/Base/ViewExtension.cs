using System.Windows;
using System.Windows.Data;
using ICSharpCode.WpfDesign;
using XamarinFormsClasses.Converters;

namespace XamarinFormsClasses.Base
{
    public abstract class ViewExtension : VisualElementExtension
    {
        public override void SetBindings(DesignItem item, FrameworkElement view)
        {
            base.SetBindings(item, view);

            view.SetBinding(FrameworkElement.VerticalAlignmentProperty, new Binding("Component.VerticalOptions") { Source = item, Converter = LayoutOptionsToVerticalAlignmentConverter.Instance });
            view.SetBinding(FrameworkElement.HorizontalAlignmentProperty, new Binding("Component.HorizontalOptions") { Source = item, Converter = LayoutOptionsToHorizontalAlignmentConverter.Instance });            
        }
    }
}
