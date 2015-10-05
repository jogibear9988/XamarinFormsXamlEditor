using System.Windows;
using System.Windows.Data;
using ICSharpCode.WpfDesign;
using ICSharpCode.WpfDesign.Extensions;
using Xamarin.Forms;
using XamarinFormsClasses.Base;
using XamarinFormsClasses.Converters;

namespace XamarinFormsClasses.Controls
{
    public class LabelView : System.Windows.Controls.Label
    {
        public LabelView()
        {
            this.HorizontalAlignment = HorizontalAlignment.Center;
            this.VerticalAlignment = VerticalAlignment.Top;
        }
    }

    [ExtensionFor(typeof(Label))]
    public class LabelViewExtension : ViewExtension
    {
        public override FrameworkElement CreateView(DesignItem item)
        {
            return new LabelView();
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
