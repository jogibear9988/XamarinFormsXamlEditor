using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ICSharpCode.WpfDesign.Designer;

namespace XamarinFormsClasses.Base
{
    public class VisualElement : Element
    {
        public double Rotation
        {
            get { return (double)GetValue(RotationProperty); }
            set { SetValue(RotationProperty, value); }
        }

        public static readonly DependencyProperty RotationProperty =
            DependencyProperty.Register("Rotation", typeof(double), typeof(VisualElement), new PropertyMetadata(0.0));

        public bool IsVisible
        {
            get { return (bool)GetValue(IsVisibleProperty); }
            set { SetValue(IsVisibleProperty, value); }
        }

        public static readonly DependencyProperty IsVisibleProperty =
            DependencyProperty.Register("IsVisible", typeof(bool), typeof(VisualElement), new PropertyMetadata(true));

        public double AnchorX
        {
            get { return (double)GetValue(AnchorXProperty); }
            set { SetValue(AnchorXProperty, value); }
        }

        public static readonly DependencyProperty AnchorXProperty =
            DependencyProperty.Register("AnchorX", typeof(double), typeof(VisualElement), new PropertyMetadata(0.5));

        public double AnchorY
        {
            get { return (double)GetValue(AnchorYProperty); }
            set { SetValue(AnchorYProperty, value); }
        }

        public static readonly DependencyProperty AnchorYProperty =
            DependencyProperty.Register("AnchorY", typeof(double), typeof(VisualElement), new PropertyMetadata(0.5));

        public double Scale
        {
            get { return (double)GetValue(ScaleProperty); }
            set { SetValue(ScaleProperty, value); }
        }

        public static readonly DependencyProperty ScaleProperty =
            DependencyProperty.Register("Scale", typeof(double), typeof(VisualElement), new PropertyMetadata(1.0));

        public double TranslationX
        {
            get { return (double)GetValue(TranslationXProperty); }
            set { SetValue(TranslationXProperty, value); }
        }

        public static readonly DependencyProperty TranslationXProperty =
            DependencyProperty.Register("TranslationX", typeof(double), typeof(VisualElement), new PropertyMetadata(0.0));

        public double TranslationY
        {
            get { return (double)GetValue(TranslationYProperty); }
            set { SetValue(TranslationYProperty, value); }
        }

        public static readonly DependencyProperty TranslationYProperty =
            DependencyProperty.Register("TranslationY", typeof(double), typeof(VisualElement), new PropertyMetadata(0.0));

        public double Width
        {
            get { return (double)GetValue(WidthProperty); }
            set { SetValue(WidthProperty, value); }
        }

        public static readonly DependencyProperty WidthProperty =
            DependencyProperty.Register("Width", typeof(double), typeof(VisualElement), new PropertyMetadata(double.NaN));

        public double Height
        {
            get { return (double)GetValue(HeightProperty); }
            set { SetValue(HeightProperty, value); }
        }

        public static readonly DependencyProperty HeightProperty =
            DependencyProperty.Register("Height", typeof(double), typeof(VisualElement), new PropertyMetadata(double.NaN));        
    }
}
