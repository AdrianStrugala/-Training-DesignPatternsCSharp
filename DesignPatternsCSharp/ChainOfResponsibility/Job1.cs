using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public class Job1 : IJob
    {
        public bool Run(object context)
        {
            Console.WriteLine("Command 1 executed! :O");

            return true;
        }
    }
}
