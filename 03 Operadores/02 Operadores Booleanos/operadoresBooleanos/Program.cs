using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadoresBooleanos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool p = true;
            bool q = false;
            Console.WriteLine("El valor de verdad para p es: " + p);
            Console.WriteLine("El valor de verdad para q es: " + q);
            //Operador AND(&&)
            Console.WriteLine("La conjunción entre p y q es: {0}", (p && q));
            //Operador OR(||)
            Console.WriteLine("La disyunción entre p y q es: {0}", (p || q));
            //Operador NOT(!) 
            Console.WriteLine("La negación de p es: {0}", !p);
        }
    }
}
