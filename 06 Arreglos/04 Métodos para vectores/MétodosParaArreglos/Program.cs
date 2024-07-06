using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MétodosParaArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int i; 
            int[] vector = new int[9];
            //Recorrido y llenado con el bucle while
            for (i = 0; i < vector.Length; i++)
            {
                vector[i] = rnd.Next(9);
                Console.WriteLine("Posicion {0}: {1}", i, vector[i]);
            }
            Console.WriteLine(" ");
            //Metodo Array.ForEach
            Console.WriteLine("Impresión de arreglos con Array.ForEach");
            Array.ForEach(vector, vectores => Console.Write(vectores + " "));

            //Metodo .Length
            Console.WriteLine("\n El tamaño del arreglos es de: " + vector.Length);

            //Recorrido con el foreach
            Console.WriteLine("Impresión con el foreach");
            i = 0;
            foreach (int valores in vector)
            {
                Console.WriteLine("Posicion "+ i + " es : " + valores);
                i++; //Esta es para mostrar la posicion en la que se encuentra No es del bucle foreach 
            }

            //Ordenar de manera ascendente los elementos de un arreglo 
            Array.Sort(vector);
            Console.WriteLine("Vector ordenado de manera ascendente");
            foreach (int ordenadoAscendente in vector)
            {
                Console.Write(ordenadoAscendente + " ");
            }
            Console.WriteLine("");

            //Ordenar de manera descendente los elementos del arreglo 
            Array.Reverse(vector);
            Console.WriteLine("Vector ordenado de manera descendente");
            foreach (int ordenadoDesdecente in vector)
            {
                Console.Write(ordenadoDesdecente + " ");        
            }
            Console.WriteLine(" ");

            //Ordenamiento burbuja 
            for (i = 0; i < vector.Length - 1; i++)
            {
                for (int j = 0; j < vector.Length - 1 - i; j++)
                {
                    if (vector[j] > vector[j + 1])
                    {
                        // Intercambiar elementos
                        int temp = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Arreglo por ordenamiento burbuja");
            foreach (int imprimir in vector)
            {
                Console.WriteLine(imprimir + " ");
            }
        }
    }
}
