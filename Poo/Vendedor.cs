﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    class Vendedor:Empleado
    {
        public double Ventas { get; set; }

        public override void setSueldo(double s)
        {
            Sueldo = s + (Ventas * 0.01);
        }
    }
}
