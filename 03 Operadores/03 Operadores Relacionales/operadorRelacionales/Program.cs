using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadorRelacionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //###################################
            //       Operadores de asignación   # 
            //###################################

            //Operador de asignación
            float number = 8; Console.WriteLine("El numero que vamos a usar : {0}", number);
            //Operador de suma y asignación
            number += 5;
            Console.WriteLine("El resultado de haberle sumado 5 es: {0}", number);
            //Operador de resta y asignación 
            number -= 2;
            Console.WriteLine("El resultado de haberle restado 2 es: {0}", number);
            //Operador de multiplicación y asignación 
            number *= 9;
            Console.WriteLine("El resultado de haberle multiplicado 9 es: {0}", number);
            //Operador de división y asignación 
            number /= 2;
            Console.WriteLine("El resultado de haberle dividido entre 2 es: {0:N2}", number);

            //###################################
            //       Operadores de comparación  # Devuelven un valor booleano
            //###################################

            //Operador de comparación 
            Console.WriteLine(number == 9);
            //Operador de desigualdad
            Console.WriteLine(number != 9);
            //Operador de mayor que 
            Console.WriteLine(number > 9);
            //Operador de mayor que o igual
            Console.WriteLine(number >= 9);
            //Operador de menor que 
            Console.WriteLine(number < 9);
            //Operador de menor que o igual
            Console.WriteLine(number <= 9);
        }
    }
}
