using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloGoto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ciclo goto
            int i;
            Console.WriteLine("Ingresa un numero: ");
            i = Convert.ToInt32(Console.ReadLine());

        Incrementador:
            Console.WriteLine("El numero: {0}", i);

            if (i > 100)
            {
                goto terminacion;
            }

            i++;
            goto Incrementador;
        terminacion:
            Console.WriteLine("Fin de la ejecución porque el numero ya es mayor a 100");
        }
    }
}
