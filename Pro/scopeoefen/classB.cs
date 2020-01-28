using System;
using Henkie;

namespace scope
{
    public class classB : Iemand
    {

        public static int Openbaar = 0;

        //private static int Prive = 55;
        public classB()
        {
            Console.WriteLine(this.Getal);
        }

        public void Iets()
        {
            Console.WriteLine("Iets");
            Console.WriteLine("private iets");
            int Diego = 10;
            Console.WriteLine(Diego);

            {
                int Cass = 23;
                Console.WriteLine(Cass);
            }
        }

        private void DoeIets()
        {
            Console.WriteLine("doe iets");
        }
    }
}