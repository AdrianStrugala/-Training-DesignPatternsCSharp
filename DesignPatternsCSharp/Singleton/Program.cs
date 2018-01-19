using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        //properties of singleton are always the same, in every class etc. This class is static.
        //This is thread-safe singleton (contains lock)
        static void Main(string[] args)
        {

            Singleton.Instance.Property = 1;

            Singleton.Instance.Property = 3;

        }
    }
}
