using System;
using BenjaminAbt.Samples.WinFormsSpsRxNet.Models;

namespace BenjaminAbt.Samples.WinFormsSpsRxNet.Services
{
    public interface ISpsService
    {
        IObservable<SpsMessage> Message { get; }
    }
}