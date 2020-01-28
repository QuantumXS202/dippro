using System;
using scope;
using Henkie;

namespace scopeoefen
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("WAAROM IS DIT ZO MOEILIJK");

            classB Geert = new classB();
            Geert.Iets();

            Console.WriteLine(classB.Openbaar);
        }
    }
}
