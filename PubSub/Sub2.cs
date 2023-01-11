using System;

namespace PubSub
{
    public class Sub2
    {
        public void ProcessEvent(string data)
        {
            //throw new Exception("Something bad happened");
            Console.WriteLine($"Subscriber 2 Value: {data}");
        }
    }
}