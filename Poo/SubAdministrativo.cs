using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    class SubAdministrativo : Administrativo
    {
        public override string metodoPadre()
        {
            return base.metodoPadre() + " bis"; // Hola Mundo bis
        }
    }
}
