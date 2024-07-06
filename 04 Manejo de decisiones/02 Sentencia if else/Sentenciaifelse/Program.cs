using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sentenciaifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad; 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t Bienvenido a la discoteca \"NO ME ACUERDO\" ");
            Console.Write("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Espere un momento que vamos a verificar si está apto para ingresar...");
            Thread.Sleep(3500);
            if (edad <= 17) Console.WriteLine("Sorry, no esta apto");
            else Console.WriteLine("Congratulations esta apto, disfrute de la fiesta");


        }
    }
}
