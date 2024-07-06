using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectoresUnidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Del siguiente arreglo orden utilizando el algoritmo de ordenamiento burbuja
            int[] numeros = new int[9]; //Creación de un vector unidimesional de 9
            int posicion, aleatorio;
            Random valores = new Random();
            Console.WriteLine($"El vector tiene un tamaño de {numeros.Length}");

            //Recorrido y lLenado con valores aleatorios
            for (posicion = 0; posicion < numeros.Length; posicion++)
            {
                aleatorio = valores.Next(10);
                numeros[posicion] = aleatorio;
                Console.WriteLine("El valor asignado al arreglo numeros en la posición [{0}] es: {1}", posicion, aleatorio);
            }

            //Recorrido y impresion del vector
            posicion = 0;
            Console.WriteLine("\nRecorrido con el bucle while");
            while (posicion < numeros.Length) 
            {
                Console.WriteLine($"Vector [{posicion}]: {numeros[posicion]}");
                posicion++;
            }
        }
    }
}
