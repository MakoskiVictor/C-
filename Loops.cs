using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLoops
{
    public class Loops
    {
        public void WriteInConsole (int num) {
            if(num < 0) System.Console.WriteLine("The number is negative");
            if(num == 0) System.Console.WriteLine("The number is 0");
            if(num > 0) System.Console.WriteLine("The number is positive");
        }

        public static void LoopFromZeroTo (int num) {
            for (int i = 0; i <= num; i++) {
                if(i == 0) System.Console.WriteLine($"{i} es cero");
                else if(i % 2 == 0) System.Console.WriteLine($"{i} es par");
                else if (i % 2 != 0) System.Console.WriteLine($"{i} es impar");
            }
        }
    }
}