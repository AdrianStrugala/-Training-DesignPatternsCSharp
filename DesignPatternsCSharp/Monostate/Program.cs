using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monostate
{
    //all instances of this class has exacly the same values of properties
    class Program
    {
        static void Main(string[] args)
        {
            Monostate monostate1 = new Monostate();

            monostate1.X = 3;

            Monostate monostate2 = new Monostate();

            Console.WriteLine("Monostate1 x: {0}", monostate1.X);
            Console.WriteLine("Monostate2 x: {0}", monostate2.X);

            Console.ReadKey();
        }
    }
}
