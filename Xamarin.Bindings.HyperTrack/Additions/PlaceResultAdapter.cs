using System;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;

namespace Com.Hypertrack.Lib.Internal.Consumer.View.SelectExpectedPlace
{
    /*
    
    public partial class PlaceResultAdapter
    {
        static Delegate cb_onBindViewHolder_Lcom_hypertrack_lib_internal_consumer_view_SelectExpectedPlace_PlaceResultAdapter_SearchViewHolder_I;
#pragma warning disable 0169
        static Delegate GetOnBindViewHolder_Lcom_hypertrack_lib_internal_consumer_view_SelectExpectedPlace_PlaceResultAdapter_SearchViewHolder_IHandler()
        {
            if (cb_onBindViewHolder_Lcom_hypertrack_lib_internal_consumer_view_SelectExpectedPlace_PlaceResultAdapter_SearchViewHolder_I == null)
                cb_onBindViewHolder_Lcom_hypertrack_lib_internal_consumer_view_SelectExpectedPlace_PlaceResultAdapter_SearchViewHolder_I = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, int>)n_OnBindViewHolder_Lcom_hypertrack_lib_internal_consumer_view_SelectExpectedPlace_PlaceResultAdapter_SearchViewHolder_I);
            return cb_onBindViewHolder_Lcom_hypertrack_lib_internal_consumer_view_SelectExpectedPlace_PlaceResultAdapter_SearchViewHolder_I;
        }

        static void n_OnBindViewHolder_Lcom_hypertrack_lib_internal_consumer_view_SelectExpectedPlace_PlaceResultAdapter_SearchViewHolder_I(IntPtr jnienv, IntPtr native__this, IntPtr native_holder, int position)
        {
            global::Com.Hypertrack.Lib.Internal.Consumer.View.SelectExpectedPlace.PlaceResultAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Hypertrack.Lib.Internal.Consumer.View.SelectExpectedPlace.PlaceResultAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Hypertrack.Lib.Internal.Consumer.View.SelectExpectedPlace.PlaceResultAdapter.SearchViewHolder holder = global::Java.Lang.Object.GetObject<global::Com.Hypertrack.Lib.Internal.Consumer.View.SelectExpectedPlace.PlaceResultAdapter.SearchViewHolder>(native_holder, JniHandleOwnership.DoNotTransfer);
            __this.OnBindViewHolder(holder, position);
        }
#pragma warning restore 0169

        static IntPtr id_onBindViewHolder_Lcom_hypertrack_lib_internal_consumer_view_SelectExpectedPlace_PlaceResultAdapter_SearchViewHolder_I;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.hypertrack.lib.internal.consumer.view.SelectExpectedPlace']/class[@name='PlaceResultAdapter']/method[@name='onBindViewHolder' and count(parameter)=2 and parameter[1][@type='com.hypertrack.lib.internal.consumer.view.SelectExpectedPlace.PlaceResultAdapter.SearchViewHolder'] and parameter[2][@type='int']]"
        [Register("onBindViewHolder", "(Lcom/hypertrack/lib/internal/consumer/view/SelectExpectedPlace/PlaceResultAdapter$SearchViewHolder;I)V", "GetOnBindViewHolder_Lcom_hypertrack_lib_internal_consumer_view_SelectExpectedPlace_PlaceResultAdapter_SearchViewHolder_IHandler")]
        public override unsafe void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            if (id_onBindViewHolder_Lcom_hypertrack_lib_internal_consumer_view_SelectExpectedPlace_PlaceResultAdapter_SearchViewHolder_I == IntPtr.Zero)
                id_onBindViewHolder_Lcom_hypertrack_lib_internal_consumer_view_SelectExpectedPlace_PlaceResultAdapter_SearchViewHolder_I = JNIEnv.GetMethodID(class_ref, "onBindViewHolder", "(Lcom/hypertrack/lib/internal/consumer/view/SelectExpectedPlace/PlaceResultAdapter$SearchViewHolder;I)V");
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(holder);
                __args[1] = new JValue(position);

                if (((object)this).GetType() == ThresholdType)
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onBindViewHolder_Lcom_hypertrack_lib_internal_consumer_view_SelectExpectedPlace_PlaceResultAdapter_SearchViewHolder_I, __args);
                else
                    JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "onBindViewHolder", "(Lcom/hypertrack/lib/internal/consumer/view/SelectExpectedPlace/PlaceResultAdapter$SearchViewHolder;I)V"), __args);
            }
            finally
            {
            }
        }

        static Delegate cb_onCreateViewHolder_Landroid_view_ViewGroup_I;
#pragma warning disable 0169
        static Delegate GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler()
        {
            if (cb_onCreateViewHolder_Landroid_view_ViewGroup_I == null)
                cb_onCreateViewHolder_Landroid_view_ViewGroup_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>)n_OnCreateViewHolder_Landroid_view_ViewGroup_I);
            return cb_onCreateViewHolder_Landroid_view_ViewGroup_I;
        }

        static IntPtr n_OnCreateViewHolder_Landroid_view_ViewGroup_I(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, int viewType)
        {
            global::Com.Hypertrack.Lib.Internal.Consumer.View.SelectExpectedPlace.PlaceResultAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Hypertrack.Lib.Internal.Consumer.View.SelectExpectedPlace.PlaceResultAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Android.Views.ViewGroup parent = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup>(native_parent, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.OnCreateViewHolder(parent, viewType));
            return __ret;
        }
#pragma warning restore 0169

        static IntPtr id_onCreateViewHolder_Landroid_view_ViewGroup_I;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.hypertrack.lib.internal.consumer.view.SelectExpectedPlace']/class[@name='PlaceResultAdapter']/method[@name='onCreateViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
        [Register("onCreateViewHolder", "(Landroid/view/ViewGroup;I)Lcom/hypertrack/lib/internal/consumer/view/SelectExpectedPlace/PlaceResultAdapter$SearchViewHolder;", "GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler")]
        public override unsafe RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            if (id_onCreateViewHolder_Landroid_view_ViewGroup_I == IntPtr.Zero)
                id_onCreateViewHolder_Landroid_view_ViewGroup_I = JNIEnv.GetMethodID(class_ref, "onCreateViewHolder", "(Landroid/view/ViewGroup;I)Lcom/hypertrack/lib/internal/consumer/view/SelectExpectedPlace/PlaceResultAdapter$SearchViewHolder;");
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(parent);
                __args[1] = new JValue(viewType);

                global::Com.Hypertrack.Lib.Internal.Consumer.View.SelectExpectedPlace.PlaceResultAdapter.SearchViewHolder __ret;
                if (((object)this).GetType() == ThresholdType)
                    __ret = global::Java.Lang.Object.GetObject<global::Com.Hypertrack.Lib.Internal.Consumer.View.SelectExpectedPlace.PlaceResultAdapter.SearchViewHolder>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_onCreateViewHolder_Landroid_view_ViewGroup_I, __args), JniHandleOwnership.TransferLocalRef);
                else
                    __ret = global::Java.Lang.Object.GetObject<global::Com.Hypertrack.Lib.Internal.Consumer.View.SelectExpectedPlace.PlaceResultAdapter.SearchViewHolder>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "onCreateViewHolder", "(Landroid/view/ViewGroup;I)Lcom/hypertrack/lib/internal/consumer/view/SelectExpectedPlace/PlaceResultAdapter$SearchViewHolder;"), __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }
    } */
}
