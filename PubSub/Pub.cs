using System;

namespace PubSub
{
    public class Pub
    {
        //OnChange property containing all the list of subscribers callback methods.
        public event EventHandler<CustomEventArgs> OnChange = delegate { };

        public void Raise(string initData)
        {
            var uppercase = initData.ToUpper();

            foreach (var handler in OnChange.GetInvocationList())
            {
                try
                {
                    handler.DynamicInvoke(this, new CustomEventArgs(uppercase));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.InnerException?.Message);
                }
            }
            // raise event without exception check
            //OnChange(this, new CustomEventArgs(uppercase));
        }
    }
}