using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaYSalidaDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Hola mundo");
            Console.WriteLine("Hello world");
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Los datos ingresados son: ");
            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine("Imprimir caracteres especiales");
            Console.WriteLine("Hola \t mundo");
            Console.WriteLine("Hola \"World\"" );
            Console.WriteLine("c:\\source\\repos");
            Console.WriteLine("Insertamos un espacio \t\t en la palabra");
            Console.WriteLine("Insertamos un salto de linea \n");
            Console.WriteLine("Nueva linea");
            Console.WriteLine("******Literal de cadena palabra por palabra*******");
            Console.WriteLine(@"c:\invoices");
            Console.WriteLine("Imprimir caracteres de la tabla unicode");
            Console.WriteLine("\u0664\u058E");
            Console.WriteLine("Imprimir Japoneses");
            Console.WriteLine("\u315C\u318C");
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
            Console.WriteLine(@"c:\invoices\app.exe -j");
            Console.ReadKey();
        }
    }
}
