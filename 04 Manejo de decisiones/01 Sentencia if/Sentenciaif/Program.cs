using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentenciaif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("\t Solicitud de licencia de conducir");
            Console.Write("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            if (edad >= 18) Console.WriteLine("Esta acto para su licencia");
        }
    }
}
