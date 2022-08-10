using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public static class SwapTwoNumber
    {
        public static void DisplaySwapTwoNumber()
        {
            int a = 5;
            int b = 10;

            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine("after swap the value is " + a +" " + b);
        }
    }
}
