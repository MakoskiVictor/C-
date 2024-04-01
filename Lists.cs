using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_
{
    public class Lists(int arg1, int arg2, int arg3)
  {

    //     Listas:

    // Tamaño dinámico: Las listas tienen un tamaño dinámico que puede cambiar durante la ejecución del programa. 
    // Puedes agregar o eliminar elementos de una lista en cualquier momento, y la lista se redimensionará 
    // automáticamente según sea necesario.

    // Permiten elementos de diferentes tipos: A diferencia de los arrays, las listas pueden contener elementos de 
    // diferentes tipos de datos. Esto ofrece una mayor flexibilidad en la programación.

    // Métodos útiles: Las listas proporcionan una variedad de métodos útiles para agregar, eliminar, buscar y 
    // ordenar elementos. Estos métodos facilitan la manipulación de la lista de manera eficiente.

    // Sintaxis más compleja: La sintaxis para trabajar con listas puede ser un poco más compleja que la de los 
    // arrays, debido a la variedad de métodos disponibles y la necesidad de utilizar la clase List<T> del espacio
    //  de nombres System.Collections.Generic.

        private List<int> listNumbers = [arg1, arg2, arg3];

    public void WriteList() {
            System.Console.WriteLine("Numeros usados:");

            foreach (int item in listNumbers)
            {
                System.Console.WriteLine(item);
            }
        }

    }
}