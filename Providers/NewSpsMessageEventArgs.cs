using BenjaminAbt.Samples.WinFormsSpsRxNet.Models;

namespace BenjaminAbt.Samples.WinFormsSpsRxNet.Providers
{
    public class NewSpsMessageEventArgs
    {
        public SpsMessage Message { get; }

        public NewSpsMessageEventArgs(SpsMessage message)
        {
            Message = message;
        }
    }
}
