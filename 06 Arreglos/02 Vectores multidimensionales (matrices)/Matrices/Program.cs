using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //************************************
            //**      Matrices bidimensionales  **
            //************************************

            //Declaración de variables 
            int filas, columnas, paginas, i, j, k;
            string respuesta;
            //Creación de random 
            Random random = new Random();
            Console.WriteLine("\t Matrices ");
            Console.Write("Ingrese el numero de filas: ");
            filas = Convert.ToInt32(Console.ReadLine());
            //Manejo de ingreso de valores negativos o ceros 
            while (filas == 0 || filas < 0)
            {
                Console.WriteLine("No se aceptan numeros negativos o ceros");
                Console.Write("Ingrese el numero de filas: ");
                filas = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Ingrese el numero de columnas: ");
            columnas = Convert.ToInt32(Console.ReadLine());
            //Manejo de ingreso de valores negativos o ceros 
            while (columnas == 0 || columnas < 0)
            {
                Console.WriteLine("No se aceptan numeros negativos o ceros");
                Console.Write("\n Ingrese el numero de filas: ");
                columnas = Convert.ToInt32(Console.ReadLine());
            }
            //Creacion de un matriz de n filas y m columnas dadas por el usuario
            int[,] matriz = new int[filas, columnas];
            //Recorrido de la matriz 
            //Comenzamos por las filas 
            for (i =0; i < filas; i++)
            {
                //Comenzamos por las columnas 
                for (j =0; j < columnas; j++)
                {
                    //Llenado aleatorio
                    matriz[i, j] = random.Next(5,9);
                    Console.WriteLine("Matriz bidimensional [" + i + "," + j + "] = " + matriz[i,j]);
                }
            }

            //************************************
            //**     Matrices tridimensionales  **
            //************************************

            Console.WriteLine("Desea imprimir una matriz tridimensional: [Si/No]");
            respuesta = Console.ReadLine();
            if (respuesta == "Si" || respuesta == "si")
            {
                Console.Clear();
                Console.WriteLine("Matriz Tridimesional");
                Console.WriteLine("Ingrese el numero de filas: ");
                filas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el numero de columnas: ");
                columnas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el numero de paginas: ");
                paginas = Convert.ToInt32(Console.ReadLine());
                //Declaración de la matriz tridimensional 
                int[,,] matrizTridimensional = new int[filas, columnas, paginas];
                //Recorrido de la matriz tridimensional
                //Filas 
                for(i = 0; i < filas; i++)
                {
                    //Columnas 
                    for(j = 0; j < columnas; j++)
                    {
                        //Paginas 
                        for (k = 0; k < paginas; k++)
                        {
                            //Llenado con valores aleatorio 
                            matrizTridimensional[i, j, k] = random.Next(5, 9);
                            //Impresión por pantalla
                            Console.WriteLine("Matriz tridimensional [" + i + "," + j + "," + k + "] = " + matrizTridimensional[i, j, k]);
                        } 
                    }
                }
            }
            else Console.WriteLine("Fue un gusto Chao");

        }
    }
}
