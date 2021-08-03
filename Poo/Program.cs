using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Encapsulamiento establece que los atributos de una clase deben ser privados, y los metodos de acceso públicos
            //Estudiante e1 = new Estudiante();
            /*e1.dni = "11456789";
            e1.nombre = "Maria Perez";
            e1.edad = 74;
            e1.materia = "PHP";
            e1.regular = true;*/

            //Console.WriteLine("El nombre de la estudiante es {0}", e1.nombre);

            /*Estudiante e2 = new Estudiante();
            e2.saludar();
            Console.WriteLine("El DNI del estudiante es {0}", e2.getDni());
            Console.ReadLine();*/

            /*Estudiante e3 = new Estudiante();
            e3.setEdad(12);
            if(e3.getEdad() != 0)
            {
                Console.WriteLine("Bienvenida/o a mi sitio de cerveza artesanal");
            }

            e3.Nombre = "Maria";
            Console.WriteLine("Gracias {0} por registrarte con nosotros", e3.Nombre);*/

            /*if(e3.getEdad() >= 18)
            {
                Console.WriteLine("Bienvenida/o a mi sitio de cerveza artesanal");
            }
            else
            {
                Console.WriteLine("No tenes edad suficiente para registrarte");
            }*/



            /*Estudiante e1 = new Estudiante("11111111");
            Estudiante e2 = new Estudiante("22222222");
            Estudiante e3 = new Estudiante("33333333");


            e1.Nombre = "Maria Perez";
            e1.setEdad(20);
            e2.Nombre = "Ramiro Gomez";
            e2.setEdad(33);
            e3.Nombre = "Carla Rodriguez";
            e3.setEdad(32);*/

            /*Console.WriteLine("Estudiante 1: {0}, {1} años, DNI: {2}", e1.Nombre, e1.getEdad(), e1.getDni());
            Console.WriteLine("Estudiante 2: {0}, {1} años, DNI: {2}", e2.Nombre, e2.getEdad(), e2.getDni());
            Console.WriteLine("Estudiante 3: {0}, {1} años, DNI: {2}", e3.Nombre, e3.getEdad(), e3.getDni());*/


            /*Estudiante e1 = new Estudiante();
            Estudiante e2 = new Estudiante("1111111");
            Estudiante e3 = new Estudiante("111111", 12);

            e3.saludar();
            e3.saludar("PHP");
            Console.ReadLine();*/


            /*Administrativo a1 = new Administrativo();
            a1.Trabajar();
           

            a1.Nombre = "Florencio Rodriguez";
            a1.Legajo = 123;
            a1.setSueldo(50000);
            Console.WriteLine("{0}, {1}, ${2}", a1.Nombre, a1.Legajo, a1.getSueldo());


            Vendedor v1 = new Vendedor();
            v1.Trabajar();

            v1.Nombre = "Marta Perez";
            v1.Legajo = 545655;
            v1.setSueldo(100000);

            Console.WriteLine("{0}, {1}, ${2}", v1.Nombre, v1.Legajo, v1.getSueldo());*/


            /*Vendedor v1 = new Vendedor();
            v1.Ventas = 1000000;
            v1.setSueldo(50000);

            Console.WriteLine("El sueldo del vendedor es " + v1.getSueldo());*/

            /*Administrativo a2 = new Administrativo();
            Console.WriteLine(a2.metodoPadre());

            SubAdministrativo s1 = new SubAdministrativo();
            Console.WriteLine(s1.metodoPadre());*/


            /*ClaseA ca = new ClaseA(5);
            ClaseB cb = new ClaseB(111111111);
            ClaseB cb2 = new ClaseB("Cadena parámetro");
            ClaseB cb3 = new ClaseB(555555, "Parámetro loco");
            Console.WriteLine(cb3.imprimir());*/

            ClaseB cb = new ClaseB(6662);
            ClaseC cc = new ClaseC();

            cb.AttrC = cc;

            //Console.WriteLine(cb.AttrC);
            /*
             * ClaseC cc2 = cb.AttrC;
             * cc2.imprimirMensaje();
             * */

            cb.AttrC.imprimirMensaje();




            Console.ReadLine();
        }
    }
}
