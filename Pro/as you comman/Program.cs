using System;

namespace as_you_comman
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("kies een nummer");
            Console.ReadLine();
            Console.WriteLine("kies nog een nummer");
            Console.ReadLine();

            int[] createArray(int length, int max)
            {
                int[] numberArray = new int[length];

                for (int i = 0; i < length; i++)
                {
                    Random random = new Random();
                    int num = random.Next(max);
                    numberArray[i] = num;

                }
                foreach (var number in numberArray)
                {
                    Console.WriteLine(number.ToString());
                }

                return numberArray;

            }
        }
    }
}
