using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelecciónMultiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine("\t Bienvenido al menu de opciones del Restaurante \"Las Delicias\" ");
            Console.WriteLine("{1} Locro de papa");
            Console.WriteLine("{2} Cuy asado");
            Console.WriteLine("{3} Churrasco ecuatoriano");
            Console.WriteLine("{4} Monte pillo");
            Console.WriteLine("{5} Sancocho de pescado");
            Console.WriteLine("{6} Fanesca");
            Console.WriteLine("{7} Hornado");
            Console.Write("Ingrese la opcion {1-7}: ");
            op = Convert.ToChar(Console.ReadLine());
            switch (op) {
                case '1':
                    Console.Clear();
                    Console.WriteLine("El precio del locro de papa es de $2.50");
                    Console.Write("Es para servirse aqui o para llevar: ");
                    string estiloPrimerPlato = Console.ReadLine();
                    if (estiloPrimerPlato == "servirse") Console.WriteLine("No se le añadira ningún cargo adicional.");
                    else Console.WriteLine("Se le cobrara $0.25 ctvs por la tarrina. El precio que debe pagar es de $2.75");
                    break;
                case '2':
                    Console.Clear();
                    Console.WriteLine("El precio del cuy asado es de $2.75");
                    Console.Write("Es para servirse aqui o para llevar: ");
                    string estiloSegundoPlato = Console.ReadLine();
                    if (estiloSegundoPlato == "servirse") Console.WriteLine("No se le añadira ningún cargo adicional.");
                    else Console.WriteLine("Se le cobrara $0.25 ctvs por la tarrina. El precio que debe pagar es de $3.00");
                    break;
                case '3':
                    Console.Clear();
                    Console.WriteLine("El precio del churrasco es de $1.50");
                    Console.Write("Es para servirse aqui o para llevar: ");
                    string estiloTercerPlato = Console.ReadLine();
                    if (estiloTercerPlato == "servirse") Console.WriteLine("No se le añadira ningún cargo adicional.");
                    else Console.WriteLine("Se le cobrara $0.25 ctvs por la tarrina. El precio que debe pagar es de $1.75");
                    break;
                case '4':
                    Console.Clear();
                    Console.WriteLine("El precio del monte pillo es de $3.50");
                    Console.Write("Es para servirse aqui o para llevar: ");
                    string estiloCuartoPlato = Console.ReadLine();
                    if (estiloCuartoPlato == "servirse") Console.WriteLine("No se le añadira ningún cargo adicional.");
                    else Console.WriteLine("Se le cobrara $0.25 ctvs por la tarrina. El precio que debe pagar es de $3.75");
                    break;
                case '5':
                    Console.Clear();
                    Console.WriteLine("El precio del sancocho de pescado es de $5.50");
                    Console.Write("Es para servirse aqui o para llevar: ");
                    string estiloQuintoPlato = Console.ReadLine();
                    if (estiloQuintoPlato == "servirse") Console.WriteLine("No se le añadira ningún cargo adicional.");
                    else Console.WriteLine("Se le cobrara $0.25 ctvs por la tarrina. El precio que debe pagar es de $5.75");
                    break;
                case '6':
                    Console.Clear();
                    Console.WriteLine("El precio de la fanesca es de $1.60");
                    Console.Write("Es para servirse aqui o para llevar: ");
                    string estiloSextoPlato = Console.ReadLine();
                    if (estiloSextoPlato == "servirse") Console.WriteLine("No se le añadira ningún cargo adicional.");
                    else Console.WriteLine("Se le cobrara $0.25 ctvs por la tarrina. El precio que debe pagar es de $1.85");
                    break;
                case '7':
                    Console.Clear();
                    Console.WriteLine("El precio del hornado de papa es de $2.50");
                    Console.Write("Es para servirse aqui o para llevar: ");
                    string estiloSeptimoPlato = Console.ReadLine();
                    if (estiloSeptimoPlato == "servirse") Console.WriteLine("No se le añadira ningún cargo adicional.");
                    else Console.WriteLine("Se le cobrara $0.25 ctvs por la tarrina. El precio que debe pagar es de $2.75");
                    break;
            };
            

        }
    }
}
