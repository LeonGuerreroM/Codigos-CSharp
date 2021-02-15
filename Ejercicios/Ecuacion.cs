using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, x, y;
            double res;

            Console.WriteLine("Bienvenido a la calculadora de ec. ((x+y)^2)(a-b)");
            Console.WriteLine("Ingrese el valor de x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de y");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de b");
            b = double.Parse(Console.ReadLine());                      

            res = (((x+y)*(x+y))*(a-b));
            Console.WriteLine("\m");
            Console.WriteLine("El resultado de la ecuacion es {0}", res);


            Console.ReadKey();

        }
    }
}
