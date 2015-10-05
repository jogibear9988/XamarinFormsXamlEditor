using System.Windows.Data;
using ICSharpCode.WpfDesign;
using ICSharpCode.WpfDesign.Extensions;
using Xamarin.Forms;

namespace XamarinFormsClasses.Pages
{
    /// <summary>
    /// Interaktionslogik für ContentPageView.xaml
    /// </summary>
    public partial class ContentPageView
    {
        public ContentPageView()
        {
            InitializeComponent();
        }
    }

    [ExtensionFor(typeof(ContentPage))]
    public class ContentPageViewExtension : DesignItemInitializer
    {
        public override void InitializeDesignItem(DesignItem item)
        {
            var view = new ContentPageView();

            view.SetBinding(ContentPageView.ContentProperty, new Binding("ContentProperty.ValueOnInstanceOrView") { Source = item });
            
            item.SetView(view);
        }
    }   
}
