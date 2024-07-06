using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Funciones
{
    internal class Program
    {
        static void LecturaDeValores(ref int n1, ref int n2)
        {
            Console.Write("Ingrese el valor para n1: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el valor para n2: ");
            n2 = Convert.ToInt32(Console.ReadLine());
        }

        public static int Sumar(int numero1, int numero2)
        {
            int resultadoSuma = numero1 + numero2;
            return resultadoSuma;
        }

        public static int Restar(int n1 , int n2)
        {
            int resultadoDeLaResta = n1 - n2;
            return resultadoDeLaResta;
        }

        public static int Multiplicar(int numero1, int numero2)
        {
            int resultadoDeLaMultiplicacion = numero1 * numero2;
            return resultadoDeLaMultiplicacion;
        }

        public static int Dividir(int numero1, int numero2)
        {
            int resultadoDeLaDivision = numero1 / numero2;
            return resultadoDeLaDivision;
        }

        static void Main(string[] args)
        {
            int n1, n2, resultadoSuma, resultadoResta, resultadoMultiplicacion, resultadoDivision;
            n1 = 0; n2 = 0;
            LecturaDeValores(ref n1, ref n2);
            Console.WriteLine($"Los valores ingresados son : {n1} y {n2}");
            resultadoSuma = Sumar(n1, n2);
            Console.WriteLine($"La suma entre {n1} y {n2} es: {resultadoSuma}");
            resultadoResta = Restar(n1, n2);
            Console.WriteLine($"La resta entre {n1} y {n2} es: {resultadoResta}");
            resultadoMultiplicacion = Multiplicar(n1, n2);
            Console.WriteLine($"La multiplicacion entre {n1} y {n2} es: {resultadoMultiplicacion}");
            resultadoDivision = Dividir(n1, n2);
            Console.WriteLine("La division entre {0} y {1} es: {2}", n1, n2, resultadoDivision);


        }
    }
}
