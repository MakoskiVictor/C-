using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using interfaceEmp;

namespace c_
{
    public class Diccionarios
    {
        private EmpleadoObj empleado;

        public Diccionarios(string name, int edad, string[] hijos){
            empleado = new EmpleadoClass();
            empleado.name = name;
            empleado.edad = edad;
            empleado.hijos = hijos;
        }

        public void writeEmpleadoInfo () {
            System.Console.WriteLine($"El empleado se llama {empleado.name}");
            System.Console.WriteLine($"El empleado tiene {empleado.edad} años");
            System.Console.WriteLine("Los hijos del empleado son: ");
            foreach (string item in empleado.hijos)
            {
                System.Console.Write($"{item} ");
            }
        }
    }
        // Clase que implementa la interfaz IEmpleadoObj
    public class EmpleadoClass : EmpleadoObj
    {
        public string name { get; set; } ="";
        public int edad { get; set; }
        public string[] hijos { get; set; } = Array.Empty<string>();
    }

}