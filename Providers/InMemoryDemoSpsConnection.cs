using System;
using System.Reactive.Linq;
using BenjaminAbt.Samples.WinFormsSpsRxNet.Models;

namespace BenjaminAbt.Samples.WinFormsSpsRxNet.Providers
{
    public class InMemoryDemoSpsConnection : ISpsConnection, IDisposable
    {
        private IDisposable _nwMessageTimer;

        public InMemoryDemoSpsConnection()
        {
            _nwMessageTimer = Observable
                .Interval(TimeSpan.FromSeconds(1))
                .Subscribe(x =>
                {
                    NewMessage?.Invoke(this,
                        new NewSpsMessageEventArgs(
                            new SpsMessage(DateTime.UtcNow, Guid.NewGuid().ToString())));
                });
        }



        public delegate void NewMessageHandler(object sender, NewSpsMessageEventArgs args);

        public event NewMessageHandler NewMessage;

        public void Dispose()
        {
            if (_nwMessageTimer != null)
            {
                _nwMessageTimer.Dispose();
                _nwMessageTimer = null;
            }
        }
    }
}