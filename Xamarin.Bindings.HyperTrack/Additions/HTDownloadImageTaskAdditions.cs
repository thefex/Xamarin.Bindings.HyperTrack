using System;
using Android.OS;
using Android.Runtime;

namespace Com.Hypertrack.Lib.Internal.Consumer.Utils
{
    public partial class HTDownloadImageTask
    {

        public HTDownloadImageTask()
        {
            AsyncTask t;
        }
        static Delegate cb_doInBackground_arrayLjava_lang_String_;
#pragma warning disable 0169
        static Delegate GetDoInBackground_arrayLjava_lang_String_Handler()
        {
            if (cb_doInBackground_arrayLjava_lang_String_ == null)
                cb_doInBackground_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_DoInBackground_arrayLjava_lang_String_);
            return cb_doInBackground_arrayLjava_lang_String_;
        }

        static IntPtr n_DoInBackground_arrayLjava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_urls)
        {
            global::Com.Hypertrack.Lib.Internal.Consumer.Utils.HTDownloadImageTask __this = global::Java.Lang.Object.GetObject<global::Com.Hypertrack.Lib.Internal.Consumer.Utils.HTDownloadImageTask>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            string[] urls = (string[])JNIEnv.GetArray(native_urls, JniHandleOwnership.DoNotTransfer, typeof(string));
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.DoInBackground(urls));
            if (urls != null)
                JNIEnv.CopyArray(urls, native_urls);
            return __ret;
        }
#pragma warning restore 0169

        static IntPtr id_doInBackground_arrayLjava_lang_String_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.hypertrack.lib.internal.consumer.utils']/class[@name='HTDownloadImageTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
        [Register("doInBackground", "([Ljava/lang/String;)Landroid/graphics/Bitmap;", "GetDoInBackground_arrayLjava_lang_String_Handler")]
        protected override unsafe global::Java.Lang.Object DoInBackground(params Java.Lang.Object[] urls)
        {
            if (id_doInBackground_arrayLjava_lang_String_ == IntPtr.Zero)
                id_doInBackground_arrayLjava_lang_String_ = JNIEnv.GetMethodID(class_ref, "doInBackground", "([Ljava/lang/String;)Landroid/graphics/Bitmap;");
            IntPtr native_urls = JNIEnv.NewArray(urls);
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(native_urls);

                global::Java.Lang.Object __ret;
                if (((object)this).GetType() == ThresholdType)
                    __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_doInBackground_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
                else
                    __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "doInBackground", "([Ljava/lang/String;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
                if (urls != null)
                {
                    JNIEnv.CopyArray(native_urls, urls);
                    JNIEnv.DeleteLocalRef(native_urls);
                }
            }
        }
    } 
}
