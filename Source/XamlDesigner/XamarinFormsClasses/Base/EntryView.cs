using System.Windows;
using System.Windows.Data;
using ICSharpCode.WpfDesign;
using ICSharpCode.WpfDesign.Extensions;
using Xamarin.Forms;
using XamarinFormsClasses.Base;
using XamarinFormsClasses.Converters;

namespace XamarinFormsClasses.Controls
{
    public class EntryView : System.Windows.Controls.TextBox
    {
        public EntryView()
        {
            this.HorizontalAlignment = HorizontalAlignment.Center;
            this.VerticalAlignment = VerticalAlignment.Top;
        }
    }					   

    [ExtensionFor(typeof(Entry))]
    public class EntryViewExtension : ViewExtension
    {
        public override FrameworkElement CreateView(DesignItem item)
        {
            return new EntryView();
        }

        public override void SetBindings(DesignItem item, FrameworkElement view)
        {
            base.SetBindings(item, view);

            view.SetBinding(EntryView.TextProperty, new Binding("Component.Text") { Source = item });
            view.SetBinding(EntryView.VisibilityProperty, new Binding("Component.IsVisible") { Source = item, Converter = IsVisibleToVisibilityConverter.Instance });
            view.SetBinding(EntryView.FontSizeProperty, new Binding("Component.FontSize") { Source = item });
            view.SetBinding(EntryView.ForegroundProperty, new Binding("Component.TextColor") { Source = item, Converter = ColorToBrushConverter.Instance });
        }        
    }
}
