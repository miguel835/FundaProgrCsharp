using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucleFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa para imprimir el abecedario
            char caracter;
            Console.WriteLine("\t Impresión del abecedario");
            for (caracter = 'a'; caracter <= 'z'; caracter++)
            {
                if (caracter == 'z') Console.Write($"{caracter} \n");
                else Console.Write($"{caracter}, ");
            }
            Console.SetCursorPosition(9,2);
            Console.WriteLine("Impresión del abecedario de manera inversa");
            for (caracter = 'z'; caracter >= 'a'; caracter--)
            {
                if (caracter == 'a') Console.Write($"{caracter} \n");
                else Console.Write($"{caracter}, ");
            }

        }
    }
}
