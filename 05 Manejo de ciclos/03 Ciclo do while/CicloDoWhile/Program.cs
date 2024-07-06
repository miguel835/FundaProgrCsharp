using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que lee una serie de numeros por teclado hasta llegar a cero e indica cual es el mayor
            int n, mayor;
            mayor = 0;
            Console.WriteLine("\t Programa de numeros");
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > mayor) mayor = n;
            } while (n != 0);
            Console.WriteLine("El numero mayor es: " + mayor);
        }
    }
}
