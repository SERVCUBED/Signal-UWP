﻿/** 
 * Copyright (C) 2015-2017 smndtrl, golf1052
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

using libsignalservice;
using libsignalservice.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libsignalservice.push;
using TextSecure.util;

namespace Signal.Push
{
    public class TextSecureCommunicationFactory
    {
        // TODO: fix cert pinning
#if RELEASE
        public static readonly string PUSH_URL = "https://textsecure-service.whispersystems.org";
#else
        public static readonly string PUSH_URL = "https://textsecure-service-staging.whispersystems.org";
#endif

        //#if RELEASE // TODO: RELEASE
        //        public static readonly string PUSH_URL = "http://textsecure.simondieterle.net";
        //#else
        //        public static readonly string PUSH_URL = "http://textsecure-staging.simondieterle.net";
        //#endif
        public static SignalServiceUrl[] PUSH_URLS = {new SignalServiceUrl(PUSH_URL, new TextSecurePushTrustStore()) };

        private static readonly string USER_AGENT = Signal.App.CurrentVersion;

        public static SignalServiceAccountManager createManager()
        {
            return new SignalServiceAccountManager(PUSH_URLS,
                                                TextSecurePreferences.getLocalNumber(),
                                                TextSecurePreferences.getPushServerPassword(), USER_AGENT);
        }

        public static SignalServiceAccountManager createManager(String number, String password)
        {
            return new SignalServiceAccountManager(PUSH_URLS,
                                                number, password, USER_AGENT);
        }

        public static SignalServiceMessageReceiver createReceiver()
        {
            return new SignalServiceMessageReceiver(PUSH_URLS,
                                             new DynamicCredentialsProvider(), USER_AGENT);
        }

        public class DynamicCredentialsProvider : CredentialsProvider
        {
            public DynamicCredentialsProvider() { }


            public String GetUser()
            {
                return TextSecurePreferences.getLocalNumber();
            }


            public String GetPassword()
            {
                return TextSecurePreferences.getPushServerPassword();
            }

            public String GetSignalingKey()
            {
                return TextSecurePreferences.getSignalingKey();
            }


        }

    }
}
