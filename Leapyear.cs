using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public static class Leapyear
    {
        public static void CalculateLeapYear()
        {
            Console.WriteLine("Enter the Year : ");
            int year = int.Parse(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine(" {0} is a leap year ", year);
            }
            else
            { 
                Console.WriteLine(" {0} is not a learyear ", year);
                    }
        }
    }
}
