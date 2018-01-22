using Android.App;
using Android.Widget;
using Android.OS;
using Com.Hypertrack.Lib;
using Com.Hypertrack.Lib.Callbacks;
using System;
using Android.Runtime;
using Com.Hypertrack.Lib.Models;
using System.Threading.Tasks;
using Java.Interop;

namespace TestProject
{
    [Activity(Label = "TestProject", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        private HyperTrackCallbackListener testt;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            HyperTrack.Initialize(this, "KEy");
            testt = new HyperTrackCallbackListener();


            button.Click += delegate { button.Text = $"{count++} clicks!"; };
        }
    }
 

    public class HyperTrackCallbackTest : HyperTrackCallback{
        public HyperTrackCallbackTest()
        {

        }

        public HyperTrackCallbackTest(IntPtr ptr, JniHandleOwnership transfer) : base(ptr, transfer)
        {

        }

        public override void OnError(ErrorResponse p0)
        {
            throw new NotImplementedException();
        }

        public override void OnSuccess(SuccessResponse p0)
        {
            throw new NotImplementedException();
        }
    }

    class Test : Java.Lang.Object {
        
    }

    class Response<T> {
        
    }

    class HyperTrackCallbackListener : HyperTrackCallback
    {
        readonly TaskCompletionSource<Response<Test>> _responseSubject
        = new TaskCompletionSource<Response<Test>>();

        public HyperTrackCallbackListener()
        {

        }

        protected HyperTrackCallbackListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }


        public Task<Response<Test>> GetCallbackResponse()
        {
            return _responseSubject.Task;
        }


        public override void OnError(ErrorResponse p0)
        {
       //     if (_responseSubject.Task.IsCompleted)
        //        return;
       //     _responseSubject.SetResult(new Response<TResponseObject>());
        }

        public override void OnSuccess(SuccessResponse p0)
        {
        //    if (_responseSubject.Task.IsCompleted)
        //        return;
        //    var responseObject = JavaObjectExtensions.JavaCast<TResponseObject>(p0.ResponseObject);
        //    _responseSubject.SetResult(new Response<TResponseObject>());
        }
    }
}

