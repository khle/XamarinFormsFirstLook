using Social;
using UIKit;
using Xamarin.Forms;
using XamarinFormsFirstLook.Extension;
using XamarinFormsFirstLook.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(Twitter_iOS))]

namespace XamarinFormsFirstLook.iOS
{
    public class Twitter_iOS : ITwitter
    {
        private SLComposeViewController slComposer;

        public void SendTweet(string msg)
        {
            if (SLComposeViewController.IsAvailable(SLServiceKind.Twitter))
            {
                var window = UIApplication.SharedApplication.KeyWindow;
                UIViewController vc = window.RootViewController;

                slComposer = SLComposeViewController.FromService(SLServiceKind.Twitter);
                slComposer.SetInitialText(msg);
                slComposer.CompletionHandler += (result) =>
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        vc.DismissModalViewController(true);
                    });
                };
                vc.PresentViewController(slComposer, true, null);
            }
        }
    }
}