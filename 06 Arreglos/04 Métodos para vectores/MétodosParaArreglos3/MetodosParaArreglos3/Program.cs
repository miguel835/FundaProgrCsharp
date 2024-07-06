using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosParaArreglos3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uso Language Integrated Query (LINQ) 
            int[] nuevoArreglo = new int[5];
            Random random = new Random();
            int i, aleatorio;
            
            Console.WriteLine("El arreglo tiene una cantidad de " + nuevoArreglo.Length);

            for (i = 0; i < nuevoArreglo.Length; i++)
            {
                aleatorio = random.Next(2, 10);
                nuevoArreglo[i] = aleatorio;
                Console.WriteLine("El valor del arreglo en [" + i + "] es :" + nuevoArreglo[i]);
            }

            //Filtrado
            //Filtrar numeros impares 
            var impares = nuevoArreglo.Where(x => x % 2 == 1);
            Console.WriteLine("\nLos numeros impares encontrados son: ");
            foreach (var impresionDeImpares in impares)
            {
                Console.Write(impresionDeImpares + " ");
            }
            Console.WriteLine(" ");

            //Transformación de elementos 
            //Multiplicar todos los elementos por 5
            Console.WriteLine("\nTodos los numeros se van a multiplicar por cinco");
            var multiplicacionPorDos = nuevoArreglo.Select(x => x * 5);
            foreach (var impresionDeResultados in multiplicacionPorDos)
            {
                Console.Write(impresionDeResultados + " ");
            }

            //Agregar elementos de un arreglo
            //Se refiere a realizar operaciones en una colección que resulten en un único valor. 
            int suma = nuevoArreglo.Sum();
            double promedio = nuevoArreglo.Average();
            int maximo = nuevoArreglo.Max();
            int minimo = nuevoArreglo.Min();
            Console.WriteLine("\nLa suma de todos los elementos da: {0}", suma);
            Console.WriteLine("El promedio de todos los elementos da: {0}", promedio);
            Console.WriteLine("maximo de todos los elementos da: {0}", maximo);
            Console.WriteLine("El minimo de todos los elementos da: {0} \n", minimo);

            //Si se desea añadir elementos a un arreglo se hace lo siguiente
            nuevoArreglo = nuevoArreglo.Prepend(85).ToArray();
            Console.WriteLine("Para añadir un elemento al principio del arreglo es con el metodo .Prepend");
            nuevoArreglo = nuevoArreglo = nuevoArreglo.Append(100).ToArray();
            Console.WriteLine("Para añadir un elemento al final del arreglo es con el metodo .Append\n");
            //Recorrido e impresion del arreglo 
            for (i = 0; i < nuevoArreglo.Length; i++)
            {
                Console.WriteLine("El valor del arreglo en [" + i + "] es :" + nuevoArreglo[i]);
            }

            //Eliminar un elemento del arreglo 
            int elementoABorrar = 100;
            nuevoArreglo = nuevoArreglo.Where(x => x != elementoABorrar).ToArray();

            Console.WriteLine("\nEl mismo arreglo pero sin elemento 100");
            for (i = 0; i < nuevoArreglo.Length; i++)
            {
                Console.WriteLine("El valor del arreglo en [" + i + "] es :" + nuevoArreglo[i]);
            }

            Console.ReadKey();
        }
    }
}
