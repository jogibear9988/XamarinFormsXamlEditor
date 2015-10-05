using System.Windows;
using System.Windows.Data;
using ICSharpCode.WpfDesign;
using ICSharpCode.WpfDesign.Extensions;
using Xamarin.Forms;
using XamarinFormsClasses.Base;
using XamarinFormsClasses.Converters;

namespace XamarinFormsClasses.Controls
{
    public class ButtonView : System.Windows.Controls.Button
    {
    }

    [ExtensionFor(typeof(Button))]
	public class ButtonViewExtension : ViewExtension
    {
		public override FrameworkElement CreateView(DesignItem item)
		{
			return new ButtonView();
		}

		public override void SetBindings(DesignItem item, FrameworkElement view)
		{
			base.SetBindings(item, view);
           
            view.SetBinding(ButtonView.ContentProperty, new Binding("ContentProperty.ValueOnInstanceOrView") { Source = item });
            view.SetBinding(ButtonView.VisibilityProperty, new Binding("Component.IsVisible") { Source = item, Converter = IsVisibleToVisibilityConverter.Instance });
            view.SetBinding(ButtonView.FontSizeProperty, new Binding("Component.FontSize") { Source = item });
            view.SetBinding(ButtonView.ForegroundProperty, new Binding("Component.TextColor") { Source = item, Converter = ColorToBrushConverter.Instance });
        }
    }
}
