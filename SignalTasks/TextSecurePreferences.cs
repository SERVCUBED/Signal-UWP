/** 
 * Copyright (C) 2015 smndtrl
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace SignalTasks
{
    public sealed class TextSecurePreferences
    {
        /*internal static readonly String INSTALL_NUMBER_PREF = "pref_install_number";
        internal static readonly String INSTALL_PASSWORD_PREF = "pref_install_password";
        internal static readonly String ACCOUNT_VERIFIED_PREF = "pref_account_verified";
        private static readonly String LOCAL_REGISTRATION_ID_PREF = "pref_local_registration_id";
        private static readonly String SIGNED_PREKEY_REGISTERED_PREF = "pref_signed_prekey_registered";

        internal static string getLocalNumber()
        {
            return (string)ApplicationData.Current.LocalSettings.Values[INSTALL_NUMBER_PREF];
        }

        internal static string getPushServerPassword()
        {
            return (string)ApplicationData.Current.LocalSettings.Values[INSTALL_PASSWORD_PREF];
        }

        internal static void setVerified()
        {
            ApplicationData.Current.LocalSettings.Values[ACCOUNT_VERIFIED_PREF] = true;
        }

        internal static bool isVerified()
        {
            if (ApplicationData.Current.LocalSettings.Values[ACCOUNT_VERIFIED_PREF] != null)
            {
                return (bool)ApplicationData.Current.LocalSettings.Values[ACCOUNT_VERIFIED_PREF];
            }
            else
            {
                return false;
            }

        }*/

        internal static readonly String IDENTITY_PREF = "pref_choose_identity";
        internal static readonly String CHANGE_PASSPHRASE_PREF = "pref_change_passphrase";
        internal static readonly String DISABLE_PASSPHRASE_PREF = "pref_disable_passphrase";
        internal static readonly String THEME_PREF = "pref_theme";
        internal static readonly String LANGUAGE_PREF = "pref_language";
        private static readonly String MMSC_CUSTOM_HOST_PREF = "pref_apn_mmsc_custom_host";
        internal static readonly String MMSC_HOST_PREF = "pref_apn_mmsc_host";
        private static readonly String MMSC_CUSTOM_PROXY_PREF = "pref_apn_mms_custom_proxy";
        internal static readonly String MMSC_PROXY_HOST_PREF = "pref_apn_mms_proxy";
        private static readonly String MMSC_CUSTOM_PROXY_PORT_PREF = "pref_apn_mms_custom_proxy_port";
        internal static readonly String MMSC_PROXY_PORT_PREF = "pref_apn_mms_proxy_port";
        private static readonly String MMSC_CUSTOM_USERNAME_PREF = "pref_apn_mmsc_custom_username";
        internal static readonly String MMSC_USERNAME_PREF = "pref_apn_mmsc_username";
        private static readonly String MMSC_CUSTOM_PASSWORD_PREF = "pref_apn_mmsc_custom_password";
        internal static readonly String MMSC_PASSWORD_PREF = "pref_apn_mmsc_password";
        internal static readonly String THREAD_TRIM_LENGTH = "pref_trim_length";
        internal static readonly String THREAD_TRIM_NOW = "pref_trim_now";
        internal static readonly String ENABLE_MANUAL_MMS_PREF = "pref_enable_manual_mms";

        private static readonly String LAST_VERSION_CODE_PREF = "last_version_code";
        internal static readonly String RINGTONE_PREF = "pref_key_ringtone";
        private static readonly String VIBRATE_PREF = "pref_key_vibrate";
        private static readonly String NOTIFICATION_PREF = "pref_key_enable_notifications";
        internal static readonly String LED_COLOR_PREF = "pref_led_color";
        internal static readonly String LED_BLINK_PREF = "pref_led_blink";
        private static readonly String LED_BLINK_PREF_CUSTOM = "pref_led_blink_custom";
        internal static readonly String ALL_MMS_PREF = "pref_all_mms";
        internal static readonly String ALL_SMS_PREF = "pref_all_sms";
        internal static readonly String PASSPHRASE_TIMEOUT_INTERVAL_PREF = "pref_timeout_interval";
        private static readonly String PASSPHRASE_TIMEOUT_PREF = "pref_timeout_passphrase";
        internal static readonly String SCREEN_SECURITY_PREF = "pref_screen_security";
        private static readonly String ENTER_SENDS_PREF = "pref_enter_sends";
        private static readonly String ENTER_PRESENT_PREF = "pref_enter_key";
        private static readonly String SMS_DELIVERY_REPORT_PREF = "pref_delivery_report_sms";
        internal static readonly String MMS_USER_AGENT = "pref_mms_user_agent";
        private static readonly String MMS_CUSTOM_USER_AGENT = "pref_custom_mms_user_agent";
        private static readonly String THREAD_TRIM_ENABLED = "pref_trim_threads";
        private static readonly String LOCAL_NUMBER_PREF = "pref_local_number";
        private static readonly String VERIFYING_STATE_PREF = "pref_verifying";
        internal static readonly String REGISTERED_GCM_PREF = "pref_gcm_registered";
        private static readonly String GCM_PASSWORD_PREF = "pref_gcm_password";
        private static readonly String PROMPTED_PUSH_REGISTRATION_PREF = "pref_prompted_push_registration";
        private static readonly String PROMPTED_DEFAULT_SMS_PREF = "pref_prompted_default_sms";
        private static readonly String SIGNALING_KEY_PREF = "pref_signaling_key";
        private static readonly String DIRECTORY_FRESH_TIME_PREF = "pref_directory_refresh_time";
        private static readonly String IN_THREAD_NOTIFICATION_PREF = "pref_key_inthread_notifications";

        private static readonly String LOCAL_REGISTRATION_ID_PREF = "pref_local_registration_id";
        private static readonly String SIGNED_PREKEY_REGISTERED_PREF = "pref_signed_prekey_registered";
        private static readonly String WIFI_SMS_PREF = "pref_wifi_sms";

        private static readonly String WNS_REGISTRATION_ID_PREF = "pref_gcm_registration_id";
        private static readonly String GCM_REGISTRATION_ID_VERSION_PREF = "pref_gcm_registration_id_version";
        private static readonly String WEBSOCKET_REGISTERED_PREF = "pref_websocket_registered";
        private static readonly String RATING_LATER_PREF = "pref_rating_later";
        private static readonly String RATING_ENABLED_PREF = "pref_rating_enabled";

        internal static readonly String REPEAT_ALERTS_PREF = "pref_repeat_alerts";

        internal static long getRatingLaterTimestamp()
        {
            return GetValueOrDefault<long>(RATING_LATER_PREF, 0);
        }

        internal static void setRatingLaterTimestamp(long timestamp)
        {
            AddOrUpdateValue(RATING_LATER_PREF, timestamp);
        }

        internal static bool isRatingEnabled()
        {
            return GetValueOrDefault<bool>(RATING_ENABLED_PREF, true);
        }

        internal static void setRatingEnabled(bool enabled)
        {
            AddOrUpdateValue(RATING_ENABLED_PREF, enabled);
        }

        internal static bool isWebsocketRegistered()
        {
            return GetValueOrDefault<bool>(WEBSOCKET_REGISTERED_PREF, false);
        }

        internal static void setWebsocketRegistered(bool registered)
        {
            AddOrUpdateValue(WEBSOCKET_REGISTERED_PREF, registered);
        }

        internal static bool isWifiSmsEnabled()
        {
            return GetValueOrDefault<bool>(WIFI_SMS_PREF, false);
        }

        /*internal static int getRepeatAlertsCount()
        {
            try
            {
                return Integer.parseInt(GetValueOrDefault<string>(REPEAT_ALERTS_PREF, "0"));
            }
            catch (NumberFormatException e)
            {
                Log.w(TAG, e);
                return 0;
            }
        }*/

        internal static void setRepeatAlertsCount(int count)
        {
            AddOrUpdateValue(REPEAT_ALERTS_PREF, Convert.ToString(count));
        }

        internal static bool isSignedPreKeyRegistered()
        {
            return GetValueOrDefault<bool>(SIGNED_PREKEY_REGISTERED_PREF, false);
        }

        internal static void setSignedPreKeyRegistered(bool value)
        {
            AddOrUpdateValue(SIGNED_PREKEY_REGISTERED_PREF, value);
        }

        internal static void setWnsRegistrationId(String registrationId)
        {
            AddOrUpdateValue(WNS_REGISTRATION_ID_PREF, registrationId);
            //AddOrUpdateValue(GCM_REGISTRATION_ID_VERSION_PREF, Util.getCurrentApkReleaseVersion(context));
        }

        internal static String getWnsRegistrationId()
        {
            /*int storedRegistrationIdVersion = GetValueOrDefault<int>(GCM_REGISTRATION_ID_VERSION_PREF, 0);

            if (storedRegistrationIdVersion != Util.getCurrentApkReleaseVersion(context))
            {
                return null;
            }
            else
            {*/
            return GetValueOrDefault<string>(WNS_REGISTRATION_ID_PREF, string.Empty);
            //}
        }

        /*internal static bool isSmsEnabled()
        {
            if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.KITKAT)
            {
                return Util.isDefaultSmsProvider(context);
            }
            else
            {
                return isInterceptAllSmsEnabled(context);
            }
        }*/

        internal static int GetLocalRegistrationId()
        {
            return GetValueOrDefault<int>(LOCAL_REGISTRATION_ID_PREF, -1);
        }

        internal static void setLocalRegistrationId(int registrationId)
        {
            AddOrUpdateValue(LOCAL_REGISTRATION_ID_PREF, registrationId);
        }

        internal static bool isInThreadNotifications()
        {
            return GetValueOrDefault<bool>(IN_THREAD_NOTIFICATION_PREF, true);
        }

        internal static long getDirectoryRefreshTime()
        {
            return GetValueOrDefault<long>(DIRECTORY_FRESH_TIME_PREF, 0L);
        }

        internal static void setDirectoryRefreshTime(long value)
        {
            AddOrUpdateValue(DIRECTORY_FRESH_TIME_PREF, value);
        }

        internal static String getLocalNumber()
        {
            return GetValueOrDefault<string>(LOCAL_NUMBER_PREF, string.Empty);
        }

        internal static void setLocalNumber(String localNumber)
        {
            AddOrUpdateValue(LOCAL_NUMBER_PREF, localNumber);
        }

        internal static String getPushServerPassword()
        {
            return GetValueOrDefault<string>(GCM_PASSWORD_PREF, string.Empty);
        }

        internal static void setPushServerPassword(String password)
        {
            AddOrUpdateValue(GCM_PASSWORD_PREF, password);
        }

        internal static void setSignalingKey(String signalingKey)
        {
            AddOrUpdateValue(SIGNALING_KEY_PREF, signalingKey);
        }

        internal static String getSignalingKey()
        {
            return GetValueOrDefault<string>(SIGNALING_KEY_PREF, string.Empty);
        }

        internal static bool isEnterImeKeyEnabled()
        {
            return GetValueOrDefault<bool>(ENTER_PRESENT_PREF, false);
        }

        internal static bool isEnterSendsEnabled()
        {
            return GetValueOrDefault<bool>(ENTER_SENDS_PREF, false);
        }

        internal static bool isPasswordDisabled()
        {
            return GetValueOrDefault<bool>(DISABLE_PASSPHRASE_PREF, false);
        }

        internal static void setPasswordDisabled(bool disabled)
        {
            AddOrUpdateValue(DISABLE_PASSPHRASE_PREF, disabled);
        }

        /*internal static bool getUseCustomMmsc()
        {
            bool legacy = TextSecurePreferences.isLegacyUseLocalApnsEnabled();
            return GetValueOrDefault<bool>(MMSC_CUSTOM_HOST_PREF, legacy);
        }

        internal static void setUseCustomMmsc(bool value)
        {
            AddOrUpdateValue(MMSC_CUSTOM_HOST_PREF, value);
        }

        internal static String getMmscUrl()
        {
            return GetValueOrDefault<string>(MMSC_HOST_PREF, "");
        }

        internal static void setMmscUrl(String mmsc)
        {
            AddOrUpdateValue(MMSC_HOST_PREF, mmsc);
        }

        internal static bool getUseCustomMmscProxy()
        {
            bool legacy = TextSecurePreferences.isLegacyUseLocalApnsEnabled();
            return GetValueOrDefault<bool>(MMSC_CUSTOM_PROXY_PREF, legacy);
        }

        internal static void setUseCustomMmscProxy(bool value)
        {
            AddOrUpdateValue(MMSC_CUSTOM_PROXY_PREF, value);
        }

        internal static String getMmscProxy()
        {
            return GetValueOrDefault<string>(MMSC_PROXY_HOST_PREF, "");
        }

        internal static void setMmscProxy(String value)
        {
            AddOrUpdateValue(MMSC_PROXY_HOST_PREF, value);
        }

        internal static bool getUseCustomMmscProxyPort()
        {
            bool legacy = TextSecurePreferences.isLegacyUseLocalApnsEnabled();
            return GetValueOrDefault<bool>(MMSC_CUSTOM_PROXY_PORT_PREF, legacy);
        }

        internal static void setUseCustomMmscProxyPort(bool value)
        {
            AddOrUpdateValue(MMSC_CUSTOM_PROXY_PORT_PREF, value);
        }

        internal static String getMmscProxyPort()
        {
            return GetValueOrDefault<string>(MMSC_PROXY_PORT_PREF, "");
        }

        internal static void setMmscProxyPort(String value)
        {
            AddOrUpdateValue(MMSC_PROXY_PORT_PREF, value);
        }

        internal static bool getUseCustomMmscUsername()
        {
            bool legacy = TextSecurePreferences.isLegacyUseLocalApnsEnabled();
            return GetValueOrDefault<bool>(MMSC_CUSTOM_USERNAME_PREF, legacy);
        }

        internal static void setUseCustomMmscUsername(bool value)
        {
            AddOrUpdateValue(MMSC_CUSTOM_USERNAME_PREF, value);
        }

        internal static String getMmscUsername()
        {
            return GetValueOrDefault<string>(MMSC_USERNAME_PREF, "");
        }

        internal static void setMmscUsername(String value)
        {
            AddOrUpdateValue(MMSC_USERNAME_PREF, value);
        }

        internal static bool getUseCustomMmscPassword()
        {
            bool legacy = TextSecurePreferences.isLegacyUseLocalApnsEnabled();
            return GetValueOrDefault<bool>(MMSC_CUSTOM_PASSWORD_PREF, legacy);
        }

        internal static void setUseCustomMmscPassword(bool value)
        {
            AddOrUpdateValue(MMSC_CUSTOM_PASSWORD_PREF, value);
        }

        internal static String getMmscPassword()
        {
            return GetValueOrDefault<string>(MMSC_PASSWORD_PREF, "");
        }

        internal static void setMmscPassword(String value)
        {
            AddOrUpdateValue(MMSC_PASSWORD_PREF, value);
        }

        internal static String getMmsUserAgent(String defaultUserAgent)
        {
            bool useCustom = GetValueOrDefault<bool>(MMS_CUSTOM_USER_AGENT, false);

            if (useCustom) return GetValueOrDefault<string>(MMS_USER_AGENT, defaultUserAgent);
            else return defaultUserAgent;
        }*/

        internal static String getIdentityContactUri()
        {
            return GetValueOrDefault<string>(IDENTITY_PREF, null);
        }

        internal static void setIdentityContactUri(String identityUri)
        {
            AddOrUpdateValue(IDENTITY_PREF, identityUri);
        }

        internal static bool isScreenSecurityEnabled()
        {
            return GetValueOrDefault<bool>(SCREEN_SECURITY_PREF, true);
        }

        internal static bool isLegacyUseLocalApnsEnabled()
        {
            return GetValueOrDefault<bool>(ENABLE_MANUAL_MMS_PREF, false);
        }

        internal static int getLastVersionCode()
        {
            return GetValueOrDefault<int>(LAST_VERSION_CODE_PREF, 0);
        }

        internal static void setLastVersionCode(int versionCode)// throws IOException
        {
            if (!AddOrUpdateValue(LAST_VERSION_CODE_PREF, versionCode))
            {
                throw new Exception("couldn't write version code to sharedpreferences");
            }
        }

        internal static String getTheme()
        {
            return GetValueOrDefault<string>(THEME_PREF, "light");
        }

        internal static bool isVerifying()
        {
            return GetValueOrDefault<bool>(VERIFYING_STATE_PREF, false);
        }

        internal static void setVerifying(bool verifying)
        {
            AddOrUpdateValue(VERIFYING_STATE_PREF, verifying);
        }

        internal static bool isPushRegistered()
        {
            return GetValueOrDefault<bool>(REGISTERED_GCM_PREF, false);
        }

        internal static void setPushRegistered(bool registered)
        {
            //Log.w("TextSecurePreferences", "Setting push registered: " + registered);
            AddOrUpdateValue(REGISTERED_GCM_PREF, registered);
        }

        internal static bool isPassphraseTimeoutEnabled()
        {
            return GetValueOrDefault<bool>(PASSPHRASE_TIMEOUT_PREF, false);
        }

        internal static int getPassphraseTimeoutInterval()
        {
            return GetValueOrDefault<int>(PASSPHRASE_TIMEOUT_INTERVAL_PREF, 5 * 60);
        }

        internal static void setPassphraseTimeoutInterval(int interval)
        {
            AddOrUpdateValue(PASSPHRASE_TIMEOUT_INTERVAL_PREF, interval);
        }

        internal static String getLanguage()
        {
            return GetValueOrDefault<string>(LANGUAGE_PREF, "zz");
        }

        internal static void setLanguage(String language)
        {
            AddOrUpdateValue(LANGUAGE_PREF, language);
        }

        internal static bool isSmsDeliveryReportsEnabled()
        {
            return GetValueOrDefault<bool>(SMS_DELIVERY_REPORT_PREF, false);
        }

        internal static bool hasPromptedPushRegistration()
        {
            return GetValueOrDefault<bool>(PROMPTED_PUSH_REGISTRATION_PREF, false);
        }

        internal static void setPromptedPushRegistration(bool value)
        {
            AddOrUpdateValue(PROMPTED_PUSH_REGISTRATION_PREF, value);
        }

        internal static bool hasPromptedDefaultSmsProvider()
        {
            return GetValueOrDefault<bool>(PROMPTED_DEFAULT_SMS_PREF, false);
        }

        internal static void setPromptedDefaultSmsProvider(bool value)
        {
            AddOrUpdateValue(PROMPTED_DEFAULT_SMS_PREF, value);
        }

        internal static bool isInterceptAllMmsEnabled()
        {
            return GetValueOrDefault<bool>(ALL_MMS_PREF, true);
        }

        internal static bool isInterceptAllSmsEnabled()
        {
            return GetValueOrDefault<bool>(ALL_SMS_PREF, true);
        }

        internal static bool isNotificationsEnabled()
        {
            return GetValueOrDefault<bool>(NOTIFICATION_PREF, true);
        }

        /* internal static String getNotificationRingtone()
         {
             return GetValueOrDefault<string>(RINGTONE_PREF, Settings.System.DEFAULT_NOTIFICATION_URI.toString());
         }*/

        internal static bool isNotificationVibrateEnabled()
        {
            return GetValueOrDefault<bool>(VIBRATE_PREF, true);
        }

        internal static String getNotificationLedColor()
        {
            return GetValueOrDefault<string>(LED_COLOR_PREF, "blue");
        }

        internal static String getNotificationLedPattern()
        {
            return GetValueOrDefault<string>(LED_BLINK_PREF, "500,2000");
        }

        internal static String getNotificationLedPatternCustom()
        {
            return GetValueOrDefault<string>(LED_BLINK_PREF_CUSTOM, "500,2000");
        }

        internal static void setNotificationLedPatternCustom(String pattern)
        {
            AddOrUpdateValue(LED_BLINK_PREF_CUSTOM, pattern);
        }

        internal static bool isThreadLengthTrimmingEnabled()
        {
            return GetValueOrDefault<bool>(THREAD_TRIM_ENABLED, false);
        }

        /*internal static int getThreadTrimLength()
        {
            return Integer.parseInt(GetValueOrDefault<string>(THREAD_TRIM_LENGTH, "500"));
        }*/

        private static bool AddOrUpdateValue(string Key, Object value)
        {
            var settings = ApplicationData.Current.LocalSettings.Values;
            bool valueChanged = false;

            // If the key exists
            if (settings.ContainsKey(Key))
            {
                // If the value has changed
                if (settings[Key] != value)
                {
                    // Store the new value
                    settings[Key] = value;
                    valueChanged = true;
                }
            }
            // Otherwise create the key.
            else
            {
                settings.Add(Key, value);
                valueChanged = true;
            }
            return valueChanged;
        }

        /// <summary>
        /// Get the current value of the setting, or if it is not found, set the 
        /// setting to the default setting.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        private static T GetValueOrDefault<T>(string Key, T defaultValue)
        {
            T value;
            var settings = ApplicationData.Current.LocalSettings.Values;
            // If the key exists, retrieve the value.
            if (settings.ContainsKey(Key))
            {
                value = (T)settings[Key];
            }
            // Otherwise, use the default value.
            else
            {
                value = defaultValue;
            }
            return value;
        }
    }
}
