using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesYTiposDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Numeros enteros
            byte edad = 18;
            short fecha = 31;
            int cantidadDeTrabajos = 1000;
            long totalDeHormigas = 1515415615154;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(10, 2);
            Console.WriteLine("TIPOS DE DATOS");
            Console.WriteLine("Numeros enteros");
            Console.WriteLine("El tipo de datos byte: {0}", edad);
            Console.WriteLine("El tipo de datos short: {0}", fecha);
            Console.WriteLine("El tipo de datos int: {0}", cantidadDeTrabajos);
            Console.WriteLine("El tipo de datos long: {0}", totalDeHormigas);
            Console.WriteLine("El minimo de datos byte es {0} y el maximo de datos byte es {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("El minimo de datos short es {0} y el maximo de datos short es {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("El minimo de datos int es {0} y el maximo de datos int es {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("El minimo de datos long es {0} y el maximo de datos long es {1}", long.MinValue, long.MaxValue);

            //Numeros decimales
            float pi = 3.14f;
            double interes = Convert.ToDouble(0.50);
            decimal salario = 75000.00m;
            Console.WriteLine(" ");
            Console.WriteLine("Numeros decimales");
            Console.WriteLine("El tipo de dato float: {0}", pi);
            Console.WriteLine("El tipo de dato double: {0}", interes);
            Console.WriteLine("El tipo de dato decimal: {0}", salario);
            Console.WriteLine("El minimo de datos float es {0} y el maximo de datos float es {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("El minimo de datos double es {0} y el maximo de datos double es {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("El minimo de datos decimal es {0} y el maximo de datos decimal es {1} \n", decimal.MinValue, decimal.MaxValue);

            //Caracter
            char caracter = 'A';
            Console.WriteLine("Caracter");
            Console.WriteLine("El tipo de dato char: " + caracter + "\n");

            //Cadena de caracteres
            string palabra = "Hola mundo";
            Console.WriteLine("Cadena de caracteres");
            Console.WriteLine("El tipo de dato string: " + palabra + "\n");

            //Boleanos 
            bool valorVerdadero = true;
            bool valorFalso = false;
            Console.WriteLine("Boleanos");
            Console.WriteLine("El tipo de dato bool es: " + valorVerdadero + " y \t" + valorFalso + "\n");

            //Declaración de variables con tipo implicito
            var mensaje = "Hola soy un mensaje";
            Console.WriteLine("Var");
            Console.WriteLine("El mensaje de la variable mensaje es: " + mensaje);
            Console.ReadKey();
        }
    }
}
