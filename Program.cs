using System.Globalization;
using c_;
using MyLoops;

internal class Program
{
  // Primitive Types
  // static readonly byte byteNumber = 255; // From 0 to 255
  // static readonly short shortNumber = 32767; // From -32768 to 32767
  // static readonly int intNumber = 2100000000; // From -2.1B to 2.1B
  // //static readonly long longNumber = 2200000000; // Infinite
  // //REAL NUMBERS
  // static readonly float floatNumber = 2.14f; // Need use "f" at the end
  // static readonly double doubleNumber = 2.14; // ==> This is the default
  //static decimal decimalNumber = 2.14m; // Need use "m" at the end

  // CHARACTER
  //char charLetter = 'd';

  // BOOBLEAN
  //bool booleanVariable = true;

  // CONSTANTS

  // const double PI = 3.14;
  private static void Main()
  {
    // Console.WriteLine("Hello, World!");
    // Console.WriteLine("The second line");
    // Console.Write("This is the first Write");
    // Console.Write("This is the second Write");

    // PrintIn(byteNumber);
    // PrintIn(shortNumber);
    // PrintIn(intNumber);
    // //PrintIn(longNumber);
    // PrintInDouble(floatNumber);
    // PrintInDouble(doubleNumber);
   // PrintIn(decimalNumber);
    // Console.WriteLine($"This is the constant: {PI}");

      // OVERFLOWING ==> SI el número que puede contener un tipo de datos es excedido
    // checked {
    //   byte number = 255;
    //   number = number + 1;

    // }
    
    // Loops MyFn = new();
    // MyFn.WriteInConsole(-1);
    // MyFn.WriteInConsole(0);
    // MyFn.WriteInConsole(1);

    // Loops.LoopFromZeroTo(20);

    // Loops.WritePairNumbersUntil(50);

    // ARRAYS
    // int[] myArray = [1, 2, 3, 4, 5];
    // Arrays.WriteTheArray(myArray);

    // LISTS

    Lists myList = new(10, 20, 30);
    myList.writeList();

  }




  public static void PrintIn (int arg) {
    Console.WriteLine(arg);
  }

  public static void PrintInDouble (double arg) {
    Console.WriteLine(arg);
  }
}