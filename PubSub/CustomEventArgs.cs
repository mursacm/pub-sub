using System;

namespace PubSub
{
    public class CustomEventArgs : EventArgs
    {
        public string Data { get; set; }

        public CustomEventArgs(string data)
        {
            Data = data;
        }
    }
}