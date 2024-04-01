using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_
{
    public class Arrays
    {
    //     Arrays:

    // Tamaño fijo: Los arrays tienen un tamaño fijo que se determina al momento de su creación. 
    // Una vez que se declara un array con un tamaño específico, no se puede cambiar.

    // Tipo de elementos fijo: Todos los elementos de un array deben ser del mismo tipo de datos. 
    // No puedes mezclar diferentes tipos de datos en un array.

    // Acceso directo a elementos: Puedes acceder a elementos individuales de un array directamente 
    // mediante su índice. Esto proporciona un acceso rápido a los elementos del array.

    // Sintaxis simple: La sintaxis para trabajar con arrays es relativamente simple y directa.
        // Inicialización
        //int[] numeros;

        // Inicialización especificando tamaño

        // int[] numbers = new int[5];
        // numbers[0] = 1;
        // numbers[1] = 2;
        // numbers[2] = 3;
        // numbers[3] = 4;
        // numbers[4] = 5;

        // Inicialización en línea
        //int[] numeros = {1, 2, 3, 4, 5};

        public static void WriteTheArray (int[] args) {
            System.Console.WriteLine($"The array length is: {args.Length}");
            foreach(int num in args) {
                System.Console.WriteLine(num);
            }
        }

    }
}