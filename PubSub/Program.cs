using System;

namespace PubSub
{
    class Program
    {
        static void Main(string[] args)
        {
            Pub p = new Pub();

            Sub1 s1 = new Sub1();

            Sub2 s2 = new Sub2();

            //register for OnChange event - Subscriber 1
            p.OnChange += (sender, e) => s1.ProcessEvent(e.Data);
            //register for OnChange event - Subscriber 2
            p.OnChange += (sender, e) => s2.ProcessEvent(e.Data);
            //raise the event > this will trigger all the subscribers callback methods
            p.Raise("this string is all uppercase");

            Console.WriteLine("Press enter to terminate!");
            Console.ReadLine();
        }
    }
}