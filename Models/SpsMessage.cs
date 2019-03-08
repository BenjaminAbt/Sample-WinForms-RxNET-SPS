using System;

namespace BenjaminAbt.Samples.WinFormsSpsRxNet.Models
{
    public class SpsMessage
    {
        public SpsMessage(DateTime timestamp, string message)
        {
            Timestamp = timestamp;
            Message = message;
        }

        public DateTime Timestamp { get; }
        public String Message { get; }
    }
}
