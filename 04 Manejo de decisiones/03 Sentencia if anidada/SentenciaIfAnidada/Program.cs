using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenciaIfAnidada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa para determinar el mayor de tres numeros
            Console.ForegroundColor = ConsoleColor.Green;
            int n1, n2, n3;
            Console.SetCursorPosition(19, 0);
            Console.WriteLine("Programa para calcular el mayor de tres numeros");
            Console.Write("Ingrese el valor para el primer numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write("Ingrese el valor para el segundo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write("Ingrese el valor para el tercer numero: ");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            if (n1 > n2 && n1 > n3) Console.WriteLine("El numero mayor es: {0}", n1);
            else if (n2 > n1 && n2 > n3) Console.WriteLine("El numero mayor es: {0}", n2);
            else if (n3 > n1 && n3 > n2) Console.WriteLine("El numero mayor es: {0}", n3);
        }
    }
}
