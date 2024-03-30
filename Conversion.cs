using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_
{
    public class Conversion
    {
        static float f = 1.0f;
        static int i = (int)f;
        static string s = "1";
        static int num = int.Parse(s);

        static void Main (int arg) {
            System.Console.WriteLine(num);
        }
    }
}