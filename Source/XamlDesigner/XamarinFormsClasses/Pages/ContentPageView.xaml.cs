using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ICSharpCode.WpfDesign;
using ICSharpCode.WpfDesign.Extensions;

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
