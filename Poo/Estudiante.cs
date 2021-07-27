using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    public class Estudiante
    {
        private string dni;
        
        public string Nombre { get; set; }

        /*private string Nombre;

        public void setNombre(string nombre_param)
        {
            Nombre = nombre_param;
        }

        public string getNombre()
        {
            return Nombre;
        }*/

        private int edad;

        private string direccion;

        
        
        
        public Estudiante(string dni_param)
        {
            Console.WriteLine("Entrada al constructor de la clase que recibe el parámetro DNI");
            dni = dni_param;
        }

        public Estudiante(string dni_param,int edad_param)
        {
            Console.WriteLine("Entrada al constructor que recibe el DNI y la edad");
        }

        public Estudiante(int edad_param_bis,string nombre_param)
        {
            Console.WriteLine("Entrada al constructor que recibe el edad y el nombre");
        }

        public Estudiante()
        {
            Console.WriteLine("Entrada al constructor de la clase");
        }
        


        public void saludar() {
            Console.WriteLine("Hola yo soy estudiante de Programación");    
        }

        public void saludar(string materia)
        {
            Console.WriteLine("Hola yo soy estudiante de Programación, y estoy estudiando {0}", materia);
        }

        public string getDni()
        {
            return dni;
        }

        public void setEdad(int edad_param)
        {
            if(edad_param < 18)
            {
                Console.WriteLine("No tenés edad suficiente para registrarte");
                edad = 0;
            }
            else
            {
                edad = edad_param;
            }
        }

        public int getEdad()
        {
            return edad;
        }

        public void setDireccion(string direccion)
        {
            this.direccion = direccion;
        }

        public string getDireccion()
        {
            return direccion;
        }
    }
}
