﻿/** 
 * Copyright (C) 2015-2017 smndtrl
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

using libsignalservice.push;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.Streams;
using TextSecure.crypto.storage;
using Signal.Database;
using System.IO;
using SQLite.Net;
using libsignal.state;
using libsignal;

namespace TextSecure
{
    public class TextSecureAxolotlStore : SignalProtocolStore
    {
        private readonly PreKeyStore preKeyStore;
        private readonly SignedPreKeyStore signedPreKeyStore;
        private readonly IdentityKeyStore identityKeyStore;
        private readonly SessionStore sessionStore;

        public static string AXOLOTLDB_PATH = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "axolotl.db");
        private SQLiteConnection connection;

        public TextSecureAxolotlStore()
        {
            connection = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), AXOLOTLDB_PATH);

            this.preKeyStore = new TextSecurePreKeyStore(connection);
            this.signedPreKeyStore = new TextSecurePreKeyStore(connection);
            this.identityKeyStore = new TextSecureIdentityKeyStore(connection);
            this.sessionStore = new TextSecureSessionStore(connection);
        }

        public bool ContainsPreKey(uint preKeyId)
        {
            return preKeyStore.ContainsPreKey(preKeyId);
        }

        public bool ContainsSession(SignalProtocolAddress address)
        {
            return sessionStore.ContainsSession(address);
        }

        public bool ContainsSignedPreKey(uint signedPreKeyId)
        {
            return signedPreKeyStore.ContainsSignedPreKey(signedPreKeyId);
        }

        public void DeleteAllSessions(string name)
        {
            sessionStore.DeleteAllSessions(name);
        }

        public void DeleteSession(SignalProtocolAddress address)
        {
            sessionStore.DeleteSession(address);
        }

        public IdentityKeyPair GetIdentityKeyPair()
        {
            return identityKeyStore.GetIdentityKeyPair();
        }

        public uint GetLocalRegistrationId()
        {
            return identityKeyStore.GetLocalRegistrationId();
        }

        public List<uint> GetSubDeviceSessions(string name)
        {
            return sessionStore.GetSubDeviceSessions(name);
        }

        public bool IsTrustedIdentity(SignalProtocolAddress address, IdentityKey identityKey)
        {
            return identityKeyStore.IsTrustedIdentity(address, identityKey);
        }

        public PreKeyRecord LoadPreKey(uint preKeyId)
        {
            return preKeyStore.LoadPreKey(preKeyId);
        }

        public SessionRecord LoadSession(SignalProtocolAddress address)
        {
            return sessionStore.LoadSession(address);
        }

        public SignedPreKeyRecord LoadSignedPreKey(uint signedPreKeyId)
        {
            return signedPreKeyStore.LoadSignedPreKey(signedPreKeyId);
        }

        public List<SignedPreKeyRecord> LoadSignedPreKeys()
        {
            return signedPreKeyStore.LoadSignedPreKeys();
        }

        public void RemovePreKey(uint preKeyId)
        {
            preKeyStore.RemovePreKey(preKeyId);
        }

        public void RemoveSignedPreKey(uint signedPreKeyId)
        {
            signedPreKeyStore.RemoveSignedPreKey(signedPreKeyId);
        }

        public bool SaveIdentity(SignalProtocolAddress address, IdentityKey identityKey)
        {
            identityKeyStore.SaveIdentity(address, identityKey);
            return true;
        }

        public void StorePreKey(uint preKeyId, PreKeyRecord record)
        {
            preKeyStore.StorePreKey(preKeyId, record);
        }

        public void StoreSession(SignalProtocolAddress address, SessionRecord record)
        {
            sessionStore.StoreSession(address, record);
        }

        public void StoreSignedPreKey(uint signedPreKeyId, SignedPreKeyRecord record)
        {
            signedPreKeyStore.StoreSignedPreKey(signedPreKeyId, record);
        }
    }
}
