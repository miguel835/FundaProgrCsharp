using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Para que una persona pueda ejercer su voto en una elección de gobierno debe ser mayor de edad y de nacionalidad ecuatoriana 
            string respuesta, nacionalidad;
            int edad;
            respuesta = "Si";
            while (respuesta == "Si")
            {
                Console.Clear();
                Console.WriteLine("\t Programa para ejercer su derecho al voto");
                Console.WriteLine("Ingrese su edad: ");
                edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese su nacionalidad:");
                nacionalidad = Console.ReadLine();
                if (edad <= 18 && nacionalidad == "Ecuatoriana") Console.WriteLine("Si puede ejercer su derecho al voto");
                else Console.WriteLine("No puede ejercer su derecho al voto. ");
                Console.WriteLine("¿Desea continuar?");
                respuesta = Console.ReadLine();
            }
        }
    }
}
