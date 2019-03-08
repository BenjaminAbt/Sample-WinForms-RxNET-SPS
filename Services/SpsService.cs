using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using BenjaminAbt.Samples.WinFormsSpsRxNet.Models;
using BenjaminAbt.Samples.WinFormsSpsRxNet.Providers;

namespace BenjaminAbt.Samples.WinFormsSpsRxNet.Services
{
    public class SpsService : IDisposable, ISpsService
    {
        private ISpsConnection _spsConection;

        private Subject<SpsMessage> _message = new Subject<SpsMessage>();
        public IObservable<SpsMessage> Message => _message.AsObservable();

        public SpsService(ISpsConnection spsConection)
        {
            _spsConection = spsConection;

            _spsConection.NewMessage += HandleNewSpsMessage;
        }

        private void HandleNewSpsMessage(object sender, NewSpsMessageEventArgs args)
        {
            _message.OnNext(args.Message);
        }

        public void Dispose()
        {
            if (_spsConection != null)
            {
                _spsConection.NewMessage -= HandleNewSpsMessage;
                _spsConection = null;
            }
        }
    }
}