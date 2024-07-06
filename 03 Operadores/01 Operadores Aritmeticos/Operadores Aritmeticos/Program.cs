using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Aritmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculadora
            Console.ForegroundColor = ConsoleColor.Green;
            float numeroUno, numeroDos;
            Random aleatorio1 = new Random();
            numeroUno = aleatorio1.Next(100);
            numeroDos = aleatorio1.Next(50);
            Console.Write("El primer numero es: {0}", numeroUno);
            Console.Write("\nEl segundo numero es: {0} \n", numeroDos);
            Console.WriteLine("La suma entre {0} y {1} es: {2} \t", numeroUno, numeroDos, (numeroUno + numeroDos));
            Console.WriteLine("La resta entre {0} y {1} es: {2} \t", numeroUno, numeroDos, (numeroUno - numeroDos));
            Console.WriteLine("La multiplicación entre {0} y {1} es: {2} \t", numeroUno, numeroDos, (numeroUno * numeroDos));
            Console.WriteLine("La división {0} y {1} es: {2:N2} \t", numeroUno, numeroDos, numeroUno / numeroDos);
            Console.WriteLine("El módulo entre {0} y {1} es: {2} \t", numeroUno, numeroDos, (numeroUno % numeroDos));



        }
    }
}
