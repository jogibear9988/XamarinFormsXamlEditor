using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using ICSharpCode.WpfDesign;
using ICSharpCode.WpfDesign.Extensions;
using Xamarin.Forms;
using XamarinFormsClasses.Base;

namespace XamarinFormsClasses.Controls
{
	[ExtensionFor(typeof(ContentView))]
	public class ContentView_Extension : ViewExtension
    {
        public override FrameworkElement CreateView(DesignItem item)
        {
            var contentControl = new System.Windows.Controls.ContentControl();
			
			return contentControl;
        }

        
        public override void SetBindings(DesignItem item, FrameworkElement view)
        {
			base.SetBindings(item, view);

			view.SetBinding(ContentControl.PaddingProperty, new Binding("Component.Padding") { Source = item });			
        }        
    }
}
