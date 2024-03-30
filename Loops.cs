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

        public static void WritePairNumbersUntil(int num) {
            if (num < 1) throw new ArgumentException("The number can't be minor than 1");
            int count = 1;
            List<int> numbers = new List<int>();
            while(count <= num) {
                if(count % 2 == 0) {
                numbers.Add(count);
                }

                count++;
            }
            numbers.ForEach(Console.WriteLine);

        }
    }
}