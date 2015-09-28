using System.Collections.Generic;
using System.Windows;
using System.Windows.Markup;

namespace XamarinFormsClasses.Base
{
    [ContentProperty("Children")]
    public class Layout : View
    {
        public bool IsClippedToBounds
        {
            get { return (bool)GetValue(IsClippedToBoundsProperty); }
            set { SetValue(IsClippedToBoundsProperty, value); }
        }

        public static readonly DependencyProperty IsClippedToBoundsProperty =
            DependencyProperty.Register("IsClippedToBounds", typeof(bool), typeof(Layout), new PropertyMetadata(false));

        public Thickness Padding
        {
            get { return (Thickness)GetValue(PaddingProperty); }
            set { SetValue(PaddingProperty, value); }
        }

        public static readonly DependencyProperty PaddingProperty =
            DependencyProperty.Register("Padding", typeof(Thickness), typeof(Layout), new PropertyMetadata(new Thickness()));

        private List<View> _children = new List<View>();
        public List<View> Children
        {
            get { return _children; }
        }
    }
}
