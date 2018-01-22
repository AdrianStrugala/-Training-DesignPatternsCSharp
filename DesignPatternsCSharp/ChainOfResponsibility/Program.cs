using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        { 
            Chain chain = new Chain(new List<IJob>
            {
                new Job1(),
                new Job2()
            });


            Dictionary<string, object> context = new Dictionary<string, object>();
            context.Add("some parameter", "some value");


            chain.Start(context);

            Console.ReadKey();
        }
    }
}
