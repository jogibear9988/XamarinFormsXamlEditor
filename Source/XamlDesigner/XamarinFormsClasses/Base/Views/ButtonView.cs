using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using ICSharpCode.WpfDesign;
using ICSharpCode.WpfDesign.Extensions;
using XamarinFormsClasses.Converters;

namespace XamarinFormsClasses.Controls
{
    public class ButtonView : System.Windows.Controls.Button
    {
    }

    [ExtensionFor(typeof(Label))]
    public class ButtonViewExtension : DesignItemInitializer
    {
        public override void InitializeDesignItem(DesignItem item)
        {
            var view = new ButtonView();

            view.SetBinding(ButtonView.ContentProperty, new Binding("ContentProperty.ValueOnInstanceOrView") { Source = item });
            view.SetBinding(ButtonView.VisibilityProperty, new Binding("Component.IsVisible") { Source = item, Converter = IsVisibleToVisibilityConverter.Instance });
            view.SetBinding(ButtonView.FontSizeProperty, new Binding("Component.FontSize") { Source = item });
            view.SetBinding(ButtonView.ForegroundProperty, new Binding("Component.TextColor") { Source = item, Converter = ColorToBrushConverter.Instance });
            
            item.SetView(view);
        }
    }
}
