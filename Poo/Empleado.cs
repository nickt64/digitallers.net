using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    class Empleado
    {
        public string Nombre { get; set; }
        public int Legajo { get; set; }
        //public double Sueldo { get; set; }

        protected double Sueldo;

        public void Trabajar()
        {
            Console.WriteLine("Estoy trabajando como un empleado");
        }


        public virtual void setSueldo(double s)
        {
            Sueldo = s;
        }

        public double getSueldo()
        {
            return Sueldo;
        }


    }
}
