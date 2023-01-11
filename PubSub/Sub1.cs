using System;

namespace PubSub
{
    public class Sub1
    {
        public void ProcessEvent(string data)
        {
            Console.WriteLine($"Subscriber 1 Value: {data}");
        }
    }
}