using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using ICSharpCode.WpfDesign;
using ICSharpCode.WpfDesign.Extensions;
using XamarinFormsClasses.Base;
using XamarinFormsClasses.Base.Layouts;
using XamarinFormsClasses.Converters;

namespace XamarinFormsClasses.Controls
{  
    [ExtensionFor(typeof(AbsoluteLayout))]
    public class AbsoluteLayout_Extension : ViewExtension
    {
        public override FrameworkElement CreateView(DesignItem item)
        {
            return new Canvas();
        }

        public override void SetBindings(DesignItem item, FrameworkElement view)
        {
            base.SetBindings(item, view);
        }        
    }
}
