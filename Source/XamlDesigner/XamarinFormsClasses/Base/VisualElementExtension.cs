using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using ICSharpCode.WpfDesign;
using ICSharpCode.WpfDesign.Extensions;
using XamarinFormsClasses.Controls;
using XamarinFormsClasses.Converters;

namespace XamarinFormsClasses.Base
{
    public abstract class VisualElementExtension : DesignItemInitializer
    {
        public override void InitializeDesignItem(DesignItem item)
        {
            var view = CreateView(item);
            SetBindings(item, view);
            item.SetView(view);
        }

        public abstract FrameworkElement CreateView(DesignItem item);

        public virtual void SetBindings(DesignItem item, FrameworkElement view)
        {
            view.SetBinding(FrameworkElement.WidthProperty, new Binding("Component.Width") { Source = item, Converter = YAlignToVerticalAlignmentConverter.Instance });
            view.SetBinding(FrameworkElement.HeightProperty, new Binding("Component.Height") { Source = item });
            
            var rotateTransform = new RotateTransform();
            var scaleTransform = new ScaleTransform();
            var translateTransform = new TranslateTransform();
            var tg = new TransformGroup() { Children = new TransformCollection(new Transform[] { rotateTransform, scaleTransform, translateTransform }) };
            view.RenderTransform = tg;

            var mb = new MultiBinding()
            {
                Bindings =
                {
                    new Binding("Component.Rotation")
                    {
                        Source = item,
                        Converter = new LambdaConverter<double, TransformGroup>((s) =>
                        {
                            rotateTransform.Angle = s;
                            return tg;
                        })
                    },
                    new Binding("Component.Scale")
                    {
                        Source = item,
                        Converter = new LambdaConverter<double, TransformGroup>((s) =>
                        {
                            scaleTransform.ScaleX = s;
                            scaleTransform.ScaleY = s;
                            return tg;
                        })
                    },   
                    new Binding("Component.TranslationX")
                    {
                        Source = item,
                        Converter = new LambdaConverter<double, TransformGroup>((s) =>
                        {
                            translateTransform.X = s;                            
                            return tg;
                        })
                    },   
                    new Binding("Component.TranslationY")
                    {
                        Source = item,
                        Converter = new LambdaConverter<double, TransformGroup>((s) =>
                        {
                            translateTransform.Y = s;
                            return tg;
                        })
                    },   
                },
                Converter = new MultiBindingLambdaConverter<TransformGroup>((s) => tg) 
            };
            view.SetBinding(LabelView.RenderTransformProperty, mb);

            var mb2 = new MultiBinding()
            {
                Bindings =
                {
                    new Binding("Component.AnchorX")
                    {
                        Source = item,
                    },
                    new Binding("Component.AnchorY")
                    {
                        Source = item,
                    }
                },
                Converter = new MultiBindingLambdaConverter<Point>((s) => new Point((double) s[0], (double) s[1]))
            };
            view.SetBinding(LabelView.RenderTransformOriginProperty, mb2);       
        }
    }
}