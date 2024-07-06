using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //La lista de arreglo son mucho más flexibles que un arreglo
            string lectura;
            int cantidad;
            string[] otrosAnimales = { "Armadillo Gigante", "Delfin Rosado", "Túcan Andino" };
            //Creación de una lista de arreglo 
            ArrayList miListaDeArreglo = new ArrayList()
            {
                "Cóndor Andino",
                "Nutria Gigante",
                "Cocodrilo de la Costa"
            };
            Console.Write("Ingrese un animal en peligro de extinción: ");
            lectura = Console.ReadLine();
            Console.Write("\nIngrese una cantidad: ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            //Añadir elementos a la lista de arreglo
            miListaDeArreglo.Add(lectura);
            miListaDeArreglo.Add(cantidad);
            //Añadir varios elementos a la vez 
            miListaDeArreglo.AddRange(otrosAnimales);
            Console.WriteLine(" ");
            //Imprimir todo lo que contiene la lista de arreglo
            foreach (var item in miListaDeArreglo)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\n");
            //Cambiar un elemento de la lista de arreglo manualmente
            miListaDeArreglo[1] = "Boa";
            Console.WriteLine("Cambiamos un elemento de la lista de arreglo\n");
            foreach (var item in miListaDeArreglo)
            {
                Console.Write(item + ", ");
            }
            //Contar los elementos de la lista de arreglo 
            Console.WriteLine("\n\tLa cantidad de elementos que hay en la lista de arreglo es de " + miListaDeArreglo.Count);

            //Remover elementos de la lista de arreglo en caso se va a eliminar Boa 
            miListaDeArreglo.Remove("Boa");
            //Remover elementos poniendo su posicion 
            miListaDeArreglo.RemoveAt(0);
            //Remover elementos poniendo un rango de elementos 
            miListaDeArreglo.RemoveRange(1, 2);
            foreach (var item in miListaDeArreglo)
            {
                Console.Write(item + ", ");
            }

            //Hay muchos más metodos como por ejemplo 
            //Para insertar
            //.Insert();
            //.InsertRange();
            //Para buscar
            //.IndexOf();
            //.LastIndexOf();
            //.Contains();
            //Para ordenar y revertir
            //.Sort();
            //.Reverse();



        }
    }
}
