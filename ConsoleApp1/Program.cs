using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            string guardarNombre;
            string guardarApellido;
            string guardarCiudad;
            int guardarEdad;

            //-------------------------------------
            Console.WriteLine("Ingresa tu nombre");
            guardarNombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu apellido");
            guardarApellido = Console.ReadLine();
            Console.WriteLine("Ingresa tu ciudad");
            guardarCiudad = Console.ReadLine();
            Console.WriteLine("Ingresa tu edad");
            guardarEdad = int.Parse(Console.ReadLine());


            Console.WriteLine("--------------------------------");

            Console.WriteLine($"Hola tu nombre completo es: {guardarNombre} {guardarApellido} Tienes {guardarEdad} y vives en {guardarCiudad}");



        }
    }

}
