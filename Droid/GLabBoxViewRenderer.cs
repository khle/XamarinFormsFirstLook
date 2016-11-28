using System.ComponentModel;
using Android.Graphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinFormsFirstLook;
using XamarinFormsFirstLook.Droid;

[assembly:ExportRendererAttribute(typeof(GLabBoxView), typeof(GLabBoxViewRenderer))]

namespace XamarinFormsFirstLook.Droid
{
    public class GLabBoxViewRenderer : BoxRenderer
    {
        public GLabBoxViewRenderer()
        {
            SetWillNotDraw(false);
        }

        public override void Draw(Android.Graphics.Canvas canvas)
        {
            base.Draw(canvas);

            GLabBoxView boxView = (GLabBoxView) Element;

            Rect rect = new Rect();
            GetDrawingRect(rect);

            Rect inside = rect;
            inside.Inset(
                (int) boxView.BorderThickness,
                (int) boxView.BorderThickness
            );

            Paint p = new Paint();
            p.Color = boxView.Color.ToAndroid();

            canvas.DrawRect(inside, p);

            p.Color = boxView.BorderColor.ToAndroid();
            p.StrokeWidth = (float) boxView.BorderThickness;
            p.SetStyle(Paint.Style.FillAndStroke);

            canvas.DrawRect(rect, p);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            Invalidate();
        }
    }
}