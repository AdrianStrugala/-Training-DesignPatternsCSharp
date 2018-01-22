using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public class Job2 : IJob
    {
        public bool Run(object context)
        {
            Console.WriteLine("Command 2 executed! :D");

            return true;
        }
    }
}
