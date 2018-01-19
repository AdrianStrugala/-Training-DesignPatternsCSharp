using System;

namespace Factory
{
    //you can create objects from a given qualifier
    //inicializated by a given cryterion
    class Program
    {
        static void Main(string[] args)
        {
            IFactoredElement one = Factory.Create("element1");

            IFactoredElement two = Factory.Create("element2");

            Console.WriteLine("One: " + one.WhoAmI());
            Console.WriteLine("Two: " + two.WhoAmI());

            Console.ReadKey();
        }
    }
}
