using System.Windows;
using System.Windows.Media;

namespace Xamarin.Forms
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

		public double WidthRequest
		{
			get { return (double)GetValue(WidthRequestProperty); }
			set { SetValue(WidthRequestProperty, value); }
		}

		public static readonly DependencyProperty WidthRequestProperty =
			DependencyProperty.Register("WidthRequest", typeof(double), typeof(VisualElement), new PropertyMetadata(0.0));

		public double HeightRequest
		{
			get { return (double)GetValue(HeightRequestProperty); }
			set { SetValue(HeightRequestProperty, value); }
		}

		public static readonly DependencyProperty HeightRequestProperty =
			DependencyProperty.Register("HeightRequest", typeof(double), typeof(VisualElement), new PropertyMetadata(0.0));
		
		public Color BackgroundColor
		{
			get { return (Color)GetValue(BackgroundColorProperty); }
			set { SetValue(BackgroundColorProperty, value); }
		}

		public static readonly DependencyProperty BackgroundColorProperty =
			DependencyProperty.Register("BackgroundColor", typeof(Color), typeof(VisualElement), new PropertyMetadata(Colors.Transparent));			
    }
}
