﻿using System.Windows;
using System.Windows.Controls;
using ICSharpCode.WpfDesign;
using ICSharpCode.WpfDesign.Extensions;
using Xamarin.Forms;
using XamarinFormsClasses.Base;

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
