using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    class ClaseC : Object
    {

        public void imprimirMensaje()
        {
            Console.WriteLine("Método imprimir de la Clase C");
        }
        public override string ToString()
        {
            return "Método toString de la Clase C";
        }
    }
}
