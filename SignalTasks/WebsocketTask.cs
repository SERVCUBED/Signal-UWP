using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Background;
using Windows.Networking.Sockets;
using Windows.Storage.Streams;
using Windows.UI.ViewManagement;
using Windows.Web;
using Google.ProtocolBuffers;
using libsignalservice.util;
using libsignalservice.websocket;

namespace SignalTasks
{


    public sealed class WebsocketTask : IBackgroundTask
    {
#if RELEASE
        private static readonly string PUSH_URL = "https://textsecure-service.whispersystems.org";
#else
        private static readonly string PUSH_URL = "https://textsecure-service-staging.whispersystems.org";
#endif

        BackgroundTaskCancellationReason _cancelReason = BackgroundTaskCancellationReason.Abort;
        private volatile bool _cancelRequested = false;
        private BackgroundTaskDeferral _deferral = null;
        private IBackgroundTaskInstance _taskInstance = null;

        private static string CurrentVersion => $"TextSecure for Windows {Package.Current.Id.Version.Major}.{Package.Current.Id.Version.Minor}.{Package.Current.Id.Version.Build}-{Package.Current.Id.Version.Revision}";

        private WebSocketConnection connection;

        private bool HasRecieved = false;

        public async void Run(IBackgroundTaskInstance taskInstance)
        {
            taskInstance.Canceled += OnCanceled;

            _deferral = taskInstance.GetDeferral();
            _taskInstance = taskInstance;
            
            var username = TextSecurePreferences.getLocalNumber();
            var password = TextSecurePreferences.getPushServerPassword();
            
            connection = new WebSocketConnection(PUSH_URL, new TextSecurePushTrustStore(), new StaticCredentialsProvider(username, password, TextSecurePreferences.getSignalingKey()), CurrentVersion);

            await connection.connect();
            //var pipe = messageReceiver.createMessagePipe();
            //pipe.MessageReceived += OnMessageRecevied;

        }
        
        private void OnMessageReceived()
        {
            _deferral.Complete();
        }

        private void OnCanceled(IBackgroundTaskInstance sender, BackgroundTaskCancellationReason reason)
        {
            // TODO return
            _cancelRequested = true;
            _cancelReason = reason;
        }
    }
}
