using System;

using UIKit;
using Xamarin.Bindings.HyperTrack;

namespace testetest
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.BackgroundColor = UIColor.Blue;
            Xamarin.Bindings.HyperTrack.HyperTrack.RequestAlwaysLocationAuthorizationWithCompletionHandler(x =>
           {
                var rez = 3;
            });
      //      HyperTrack.RequestMotionAuthorization();
            //
           var z = HyperTrack.PublishableKey;

       //     var trz = HyperTrack.IsTracking;
    //        HyperTrack.ResumeTracking();
//            var zt = HyperTrack.PublishableKey;

            var zw = 3;
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
