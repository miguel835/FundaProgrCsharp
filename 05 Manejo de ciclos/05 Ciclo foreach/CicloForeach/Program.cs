using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CicloForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //El bucle foreach nos es útil cuando trabajamos con listas de elementos y queremos realizar acciones especificas
            //en cada uno de ellos. 

            //Recorrido de un arreglo
            //Creación de un arreglo de tipo string
            Console.WriteLine("Recorrido de un arreglo con foreach");
            string[] diosesGriegos = {"Zeus", "Poseidón", "Atenea", "Hefesto", "Ares"};
            //Recorrido con foreach
            foreach (string recorrido in diosesGriegos)
            {
                if (recorrido != "Ares") Console.Write(recorrido + ", ");
                else Console.WriteLine(recorrido);
            }
            Thread.Sleep(3500);
            Console.Clear();

            //Recorrido de una lista
            //Creacion de la lista
            Console.WriteLine("Recorrido de una lista con foreach");
            List<string> data = new List<string> {"Fabiola", "2bRg7*6~Qr", "Andrea", ")?<4lP57EK", "Hector", "9e36KP$J$d"};
            //Recorrido con foreach
            foreach (string impresion in data)
            {
                if (impresion != "2bRg7*6~Qr" && impresion != ")?<4lP57EK" && impresion != "9e36KP$J$d") Console.WriteLine("Usuario: " + impresion);
                else Console.WriteLine("Contraseña: " + impresion + "\n");
            }
            Thread.Sleep(3500);
            Console.Clear();

            //Recorrido de diccionario
            //Creación de diccionario 
            Console.WriteLine("Recorrido de un diccionario con foreach");
            Random numeroAleatorio = new Random();
            Dictionary<string, double> listadoDeudores = new Dictionary<string, double>
            {
                {"Alan", numeroAleatorio.NextDouble()},
                {"Noelia", numeroAleatorio.NextDouble()},
                {"Marting", numeroAleatorio.NextDouble()},
                {"Snoopy", numeroAleatorio.NextDouble()}
            };
            foreach (KeyValuePair<string, double> morosos in listadoDeudores)
            {
                Console.WriteLine("El nombre del moroso es: " + morosos.Key + "\n" + "Y debe la cantidad de: " + morosos.Value + "\n");
            }
        }
    }
}
