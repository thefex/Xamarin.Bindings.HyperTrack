using System;
using Android.Runtime;

namespace Com.Hypertrack.Lib.Internal.Common.Util
{

    public partial class UserPreferencesImpl
    {
        public partial class GsonUTCDateAdapter
        {

            static Delegate cb_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_;
#pragma warning disable 0169
            static Delegate GetDeserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_Handler()
            {
                if (cb_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_ == null)
                    cb_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>)n_Deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_);
                return cb_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_;
            }

            static IntPtr n_Deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_jsonElement, IntPtr native_type, IntPtr native_jsonDeserializationContext)
            {
                global::Com.Hypertrack.Lib.Internal.Common.Util.UserPreferencesImpl.GsonUTCDateAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Hypertrack.Lib.Internal.Common.Util.UserPreferencesImpl.GsonUTCDateAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::GoogleGson.JsonElement jsonElement = global::Java.Lang.Object.GetObject<global::GoogleGson.JsonElement>(native_jsonElement, JniHandleOwnership.DoNotTransfer);
                global::Java.Lang.Reflect.IType type = (global::Java.Lang.Reflect.IType)global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType>(native_type, JniHandleOwnership.DoNotTransfer);
                global::GoogleGson.IJsonDeserializationContext jsonDeserializationContext = (global::GoogleGson.IJsonDeserializationContext)global::Java.Lang.Object.GetObject<global::GoogleGson.IJsonDeserializationContext>(native_jsonDeserializationContext, JniHandleOwnership.DoNotTransfer);
                IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Deserialize(jsonElement, type, jsonDeserializationContext));
                return __ret;
            }
#pragma warning restore 0169

            static IntPtr id_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_;
            // Metadata.xml XPath method reference: path="/api/package[@name='com.hypertrack.lib.internal.common.util']/class[@name='UserPreferencesImpl.GsonUTCDateAdapter']/method[@name='deserialize' and count(parameter)=3 and parameter[1][@type='com.google.gson.JsonElement'] and parameter[2][@type='java.lang.reflect.Type'] and parameter[3][@type='com.google.gson.JsonDeserializationContext']]"
            [Register("deserialize", "(Lcom/google/gson/JsonElement;Ljava/lang/reflect/Type;Lcom/google/gson/JsonDeserializationContext;)Ljava/util/Date;", "GetDeserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_Handler")]
            public virtual unsafe Java.Lang.Object Deserialize(global::GoogleGson.JsonElement jsonElement, global::Java.Lang.Reflect.IType type, global::GoogleGson.IJsonDeserializationContext jsonDeserializationContext)
            {
                if (id_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_ == IntPtr.Zero)
                    id_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_ = JNIEnv.GetMethodID(class_ref, "deserialize", "(Lcom/google/gson/JsonElement;Ljava/lang/reflect/Type;Lcom/google/gson/JsonDeserializationContext;)Ljava/util/Date;");
                try
                {
                    JValue* __args = stackalloc JValue[3];
                    __args[0] = new JValue(jsonElement);
                    __args[1] = new JValue(type);
                    __args[2] = new JValue(jsonDeserializationContext);

                    global::Java.Util.Date __ret;
                    if (((object)this).GetType() == ThresholdType)
                        __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_, __args), JniHandleOwnership.TransferLocalRef);
                    else
                        __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "deserialize", "(Lcom/google/gson/JsonElement;Ljava/lang/reflect/Type;Lcom/google/gson/JsonDeserializationContext;)Ljava/util/Date;"), __args), JniHandleOwnership.TransferLocalRef);
                    return __ret;
                }
                finally
                {
                }
            }

            static Delegate cb_serialize_Ljava_util_Date_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_;
#pragma warning disable 0169
            static Delegate GetSerialize_Ljava_util_Date_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_Handler()
            {
                if (cb_serialize_Ljava_util_Date_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_ == null)
                    cb_serialize_Ljava_util_Date_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>)n_Serialize_Ljava_util_Date_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_);
                return cb_serialize_Ljava_util_Date_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_;
            }

            static IntPtr n_Serialize_Ljava_util_Date_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_date, IntPtr native_type, IntPtr native_jsonSerializationContext)
            {
                global::Com.Hypertrack.Lib.Internal.Common.Util.UserPreferencesImpl.GsonUTCDateAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Hypertrack.Lib.Internal.Common.Util.UserPreferencesImpl.GsonUTCDateAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Java.Util.Date date = global::Java.Lang.Object.GetObject<global::Java.Util.Date>(native_date, JniHandleOwnership.DoNotTransfer);
                global::Java.Lang.Reflect.IType type = (global::Java.Lang.Reflect.IType)global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType>(native_type, JniHandleOwnership.DoNotTransfer);
                global::GoogleGson.IJsonSerializationContext jsonSerializationContext = (global::GoogleGson.IJsonSerializationContext)global::Java.Lang.Object.GetObject<global::GoogleGson.IJsonSerializationContext>(native_jsonSerializationContext, JniHandleOwnership.DoNotTransfer);
                IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Serialize(date, type, jsonSerializationContext));
                return __ret;
            }
#pragma warning restore 0169

            static IntPtr id_serialize_Ljava_util_Date_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_;
            // Metadata.xml XPath method reference: path="/api/package[@name='com.hypertrack.lib.internal.common.util']/class[@name='UserPreferencesImpl.GsonUTCDateAdapter']/method[@name='serialize' and count(parameter)=3 and parameter[1][@type='java.util.Date'] and parameter[2][@type='java.lang.reflect.Type'] and parameter[3][@type='com.google.gson.JsonSerializationContext']]"
            [Register("serialize", "(Ljava/util/Date;Ljava/lang/reflect/Type;Lcom/google/gson/JsonSerializationContext;)Lcom/google/gson/JsonElement;", "GetSerialize_Ljava_util_Date_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_Handler")]
            public virtual unsafe global::GoogleGson.JsonElement Serialize(Java.Lang.Object date, global::Java.Lang.Reflect.IType type, global::GoogleGson.IJsonSerializationContext jsonSerializationContext)
            {
                if (id_serialize_Ljava_util_Date_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_ == IntPtr.Zero)
                    id_serialize_Ljava_util_Date_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_ = JNIEnv.GetMethodID(class_ref, "serialize", "(Ljava/util/Date;Ljava/lang/reflect/Type;Lcom/google/gson/JsonSerializationContext;)Lcom/google/gson/JsonElement;");
                try
                {
                    JValue* __args = stackalloc JValue[3];
                    __args[0] = new JValue(date);
                    __args[1] = new JValue(type);
                    __args[2] = new JValue(jsonSerializationContext);

                    global::GoogleGson.JsonElement __ret;
                    if (((object)this).GetType() == ThresholdType)
                        __ret = global::Java.Lang.Object.GetObject<global::GoogleGson.JsonElement>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_serialize_Ljava_util_Date_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_, __args), JniHandleOwnership.TransferLocalRef);
                    else
                        __ret = global::Java.Lang.Object.GetObject<global::GoogleGson.JsonElement>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "serialize", "(Ljava/util/Date;Ljava/lang/reflect/Type;Lcom/google/gson/JsonSerializationContext;)Lcom/google/gson/JsonElement;"), __args), JniHandleOwnership.TransferLocalRef);
                    return __ret;
                }
                finally
                {
                }
            }
        }
   }
}