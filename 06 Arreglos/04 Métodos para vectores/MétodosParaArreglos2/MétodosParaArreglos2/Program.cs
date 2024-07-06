using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MétodosParaArreglos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[5];
            Random random = new Random();
            int i, aleatorio;
            Console.WriteLine("El arreglo tiene " + arreglo.Length + " cantidad");

            for (i = 0; i < arreglo.Length; i++)
            {
                aleatorio = random.Next(2,10);
                arreglo[i] = aleatorio;
                Console.WriteLine("El valor del arreglo en [" + i + "] es :" + arreglo[i]);
            }
            //Primera manera de buscar elementos en un arreglo metodo Array.IndexOf()
            Console.Write("Ingrese el numero a buscar: ");
            int elementoABuscar = Convert.ToInt32(Console.ReadLine());
            
            int busqueda = Array.IndexOf(arreglo, elementoABuscar);
            if (busqueda >= 0) Console.WriteLine("Elemento {0} encontrado en la posicion {1}", elementoABuscar, busqueda);
            else Console.WriteLine("Elemento no encontrado");

            //Segunda manera de buscar elementos en un arreglo metodo Array.Find()
            Console.WriteLine("Busqueda de elementos con el metodo Array.Find()");
            Console.Write("Ingrese el numero a buscar: ");
            elementoABuscar = Convert.ToInt32(Console.ReadLine());
            busqueda = Array.Find(arreglo, x => x > elementoABuscar);
            if (busqueda != 0) Console.WriteLine("Elemento {0} encontrado", elementoABuscar);
            else Console.WriteLine("Elemento no encontrado");

            //Tercera manera de buscar elementos en un arreglo metodo Array.Exits()
            Console.WriteLine("Busqueda de elementos con el metodo Array.Exits()");
            Console.Write("Ingrese el numero a buscar: ");
            elementoABuscar = Convert.ToInt32(Console.ReadLine());
            bool nuevaBusqueda  = Array.Exists(arreglo, x => x > elementoABuscar);
            if (nuevaBusqueda == true) Console.WriteLine("Elemento {0} encontrado", elementoABuscar);
            else Console.WriteLine("Elemento no encontrado");

            Console.ReadKey();
        }
    }
}
