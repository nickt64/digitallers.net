using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    class Administrativo : Empleado
    {
        private const double bono = 20000;

        public override void setSueldo(double s)
        {
            Sueldo = s + bono;
        }
    }
}
