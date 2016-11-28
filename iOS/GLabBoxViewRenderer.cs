using Xamarin.Forms.Platform.iOS;
using UIKit;
using System.ComponentModel;
using CoreGraphics;
using Xamarin.Forms;
using XamarinFormsFirstLook;
using XamarinFormsFirstLook.iOS;

[assembly:ExportRendererAttribute(typeof(GLabBoxView), typeof(GLabBoxViewRenderer))]

namespace XamarinFormsFirstLook.iOS
{
    public class GLabBoxViewRenderer : BoxRenderer
    {
        public override void Draw(CGRect rect)
        {
            GLabBoxView boxView = (GLabBoxView) Element;
            using (var context = UIGraphics.GetCurrentContext())
            {
                context.SetFillColor(boxView.Color.ToCGColor());
                context.SetStrokeColor(boxView.BorderColor.ToCGColor());
                context.SetLineWidth((float) boxView.BorderThickness);

                var rectangle = Bounds.Inset((int) boxView.BorderThickness, (int) boxView.BorderThickness);

                var path = CGPath.FromRect(rectangle);
                context.AddPath(path);
                context.DrawPath((CGPathDrawingMode.FillStroke));
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == GLabBoxView.BorderThicknessProperty.PropertyName)
            {
                SetNeedsDisplay();
            }
        }
    }
}