using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interfaceEmp
{
    public interface EmpleadoObj
    {
        string name {get; set;}
        int edad {get; set;}
        string[] hijos {get; set;}
    }
}