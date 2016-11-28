using System.Reflection;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinFormsFirstLook;
using XamarinFormsFirstLook.iOS;

[assembly:ExportRendererAttribute(typeof(GLabButton), typeof(GLabButtonRenderer))]

namespace XamarinFormsFirstLook.iOS
{
    public class GLabButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BackgroundColor = UIColor.Red;
            }
        }
    }
}