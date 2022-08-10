using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public static class EvenOdd
    {
        public static void CalculateEvenOrOdd()
        {
            int i;
            Console.WriteLine("Enter the Number");
            i=int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                Console.WriteLine("Entered Number is even Number");
            }
            else
            {
                Console.WriteLine("Entered Number is an Odd Number");
            }
        }
    }
}
