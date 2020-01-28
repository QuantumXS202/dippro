using System;

namespace rekenmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1;
            int getal2;
            string total;
            float answer;

            Console.WriteLine("Je eerste getal:");
            getal1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("kies je soort som(+,*,-,/,%)");
            total = Console.ReadLine();

            Console.WriteLine("Je tweede getal:");
            getal2 = Convert.ToInt32(Console.ReadLine());

            switch (total)
            {
              case"+": 
                  answer = getal1 + getal2;
                  break;
              case"*":
                   answer = getal1 * getal2;
                   break;
              case"-":
                   answer = getal1 - getal2;
                   break;
              case"/":
                    answer = getal1 / getal2;
                    break;
               case"%":
                     answer = getal1 % getal2;
                     break;

                default:
                  answer =0;
                  break; 
            }
            Console.WriteLine("Je antwoordt:" + getal1.ToString() + " " + total + " " + getal2.ToString() + " = " + answer.ToString());
            Console.ReadLine();
        }
    }
}
