# Xamarin.Bindings.HyperTrack 
Xamarin Android and iOS bindings for HyperTrack -> https://www.hypertrack.com
Done by Przemysław Raciborski [thefex] @ <a href="https://www.InsaneLab.com">InsaneLab</a>


Xamarin.Bindings.HyperTrack (Android) verison 0.7.39-prerelase1 is available on Nuget. (prerelease because Google Play Services 15.0.1 is not on stable at nuget yet)
Xamarin.Bindings.HyperTrack.iOS (iOS) version 0.7.29 is available on Nuget.
 
# Installation Guide - iOS Troubleshooting
Install-Package Xamarin.Bindings.HyperTrack -Version 0.7.29

If you plan to publish your app to AppStore you have to add SwiftSupport folder to your IPA.
App Store requires Swift libraries inside IPA to validate your app. Use this scripts: https://github.com/bq/ipa-packager

# Installation Guide - Android Troubleshooting
Install-Package Xamarin.Bindings.HyperTrack -Version 0.7.39-prerelase1 

If Tracking does not works for you:

Add in your *AndroidManifest.xml* under your *application* tag as sometimes Android SDK tools (not *Xamarin fault*) do not generate services properly there (HyperTrack service might not work):



		<service
            android:name="com.hypertrack.lib.ActivityRecognitionService" />

        <service
            android:name="com.hypertrack.lib.ActivityTransitionService" />

        <service
            android:name="com.hypertrack.lib.HyperTrackService" />

        <service
            android:name="com.hypertrack.lib.BootReceiverService"
            android:exported="false" />

        <service
            android:name="com.hypertrack.lib.RegistrationService"
            android:exported="false" />

        <service
            android:name="com.hypertrack.lib.GCMIIDListenerService"
            android:exported="false">

            <intent-filter>

                <action
                    android:name="com.google.android.gms.iid.InstanceID" />
            </intent-filter>
        </service>

        <service
            android:name="com.hypertrack.lib.internal.consumer.service.FetchAddressIntentService"
            android:exported="false" />

        <service
            android:name="com.hypertrack.lib.FirebaseIIDListenerService">

            <intent-filter>

                <action
                    android:name="com.google.firebase.INSTANCE_ID_EVENT" />
            </intent-filter>
        </service>

        <receiver
            android:name="com.hypertrack.lib.internal.transmitter.HyperTrackReceiver"
            android:enabled="true"
            android:exported="false">

            <intent-filter>

                <action
                    android:name="android.intent.action.BOOT_COMPLETED" />

                <action
                    android:name="android.intent.action.ACTION_SHUTDOWN" />

                <action
                    android:name="android.intent.action.QUICKBOOT_POWEROFF" />

                <action
                    android:name="android.intent.action.QUICKBOOT_POWERON" />

                <action
                    android:name="android.intent.action.REBOOT" />
            </intent-filter>

            <intent-filter>

                <action
                    android:name="android.net.conn.CONNECTIVITY_CHANGE" />

                <action
                    android:name="android.net.wifi.WIFI_STATE_CHANGED" />
            </intent-filter>

            <intent-filter>

                <action
                    android:name="android.location.PROVIDERS_CHANGED" />

                <category
                    android:name="android.intent.category.DEFAULT" />
            </intent-filter>

            <intent-filter>

                <action
                    android:name="android.intent.action.AIRPLANE_MODE" />
            </intent-filter>

            <intent-filter>

                <action
                    android:name="android.intent.action.ACTION_POWER_CONNECTED" />

                <action
                    android:name="android.intent.action.ACTION_POWER_DISCONNECTED" />

                <action
                    android:name="android.intent.action.BATTERY_CHANGED" />

                <action
                    android:name="android.intent.action.BATTERY_LOW" />

                <action
                    android:name="android.intent.action.BATTERY_OKAY" />
            </intent-filter>

            <intent-filter>

                <action
                    android:name="android.os.action.DEVICE_IDLE_MODE_CHANGED" />

                <action
                    android:name="android.os.action.LIGHT_DEVICE_IDLE_MODE_CHANGED" />

                <action
                    android:name="android.os.action.POWER_SAVE_MODE_CHANGED" />
            </intent-filter>

            <intent-filter>

                <action
                    android:name="android.intent.action.LOCALE_CHANGED" />

                <action
                    android:name="android.intent.action.MY_PACKAGE_REPLACED" />

                <action
                    android:name="android.intent.action.TIMEZONE_CHANGED" />

                <action
                    android:name="android.intent.action.DATE_CHANGED" />
            </intent-filter>
        </receiver>

        <receiver
            android:name="com.hypertrack.lib.HyperTrackAlarmReceiver" />

        <receiver
            android:name="com.hypertrack.lib.internal.transmitter.NotificationDismissedReceiver" />

        <service
            android:name="io.hypertrack.smart_scheduler.SmartSchedulerAlarmReceiverService"
            android:exported="false" />

        <service
            android:name="io.hypertrack.smart_scheduler.SmartSchedulerPeriodicTaskService"
            android:permission="com.google.android.gms.permission.BIND_NETWORK_TASK_SERVICE"
            android:exported="true">

            <intent-filter>

                <action
                    android:name="com.google.android.gms.gcm.ACTION_TASK_READY" />
            </intent-filter>
        </service>

        <receiver
            android:name="io.hypertrack.smart_scheduler.SmartSchedulerAlarmReceiver"
            android:exported="false" />
