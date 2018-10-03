using Android.App;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;
using Java.Interop;
using Com.Hypertrack.Lib;
using Com.Hypertrack.Lib.Models;
using System;
using Android.Runtime;

namespace TestProject
{
    [Activity(Label = "TestProject", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Android.App.Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            HyperTrack.Initialize(this, "test");
              
            button.Click += async delegate {
                HyperTrack.GetOrCreateUser(new UserParams()
                                           .SetName("test12345")
                                           .SetLookupId("222"));
            };
        }
    }
  
     
}

