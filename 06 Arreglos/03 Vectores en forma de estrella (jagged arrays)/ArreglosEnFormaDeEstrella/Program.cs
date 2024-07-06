using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosEnFormaDeEstrella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //           Arreglos en forma de estrella
            //Son arrays de arrays, donde cada elemento es a su vez
            //un array unidimensional.Estos arrays permiten crear
            //estructuras de datos irregulares, como matrices de
            //diferentes longitudes. Se accede a sus elementos
            //utilizando dos índices: el primero para el array exterior
            //y el segundo para el array interior.
            int filas = 5;
            int n, k;
            Random random = new Random();   
            int[][] matrizIrregular = new int[filas][]; //Arreglo de 5 arreglos unidimensionales
            matrizIrregular[0] = new int[4]; //El primer arreglo es de 4 elementos 
            matrizIrregular[1] = new int[9]; //El segundo arreglo es de 9 elementos 
            matrizIrregular[2] = new int[3]; //El tercer arreglo es de 3 elementos 
            matrizIrregular[3] = new int[7]; //El cuarto arreglo es de 7 elementos 
            matrizIrregular[4] = new int[11]; //El quinto arreglo es de 11 elementos
            
            //Tambien se puede llenar manualmente
            //matrizIrregular[4] = new int[] {10, 8, 5, 9}; 

            //Recorrido y llenado del jagged arrays 
            //Impresión de los elementos del arreglo 
            for (n = 0; n < matrizIrregular.Length; n++)
            {
                //Escribe el numero de filas 
                Console.WriteLine("Fila({0})", n);
                //Acceso a los elementos 
                for(k = 0; k < matrizIrregular[n].Length; k++)
                {
                    //Llenado
                    matrizIrregular[n][k] = random.Next(4, 6);
                    //Impresión
                    Console.WriteLine("Posicion ["+ n+ ","+ k+ "] = "+ matrizIrregular[n][k]);
                }
            }

        }
    }
}
