using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            double pies, yardas, pulgadas, centimetros, metros;

            Console.WriteLine("Conversor d emedidas");
            Console.WriteLine("Ingrese una cantidad en pies");
            pies = double.Parse(Console.ReadLine());

            yardas = pies / 3;
            pulgadas = pies * 12;
            centimetros = pulgadas * 2.54;
            metros = centimetros / 100;

            Console.WriteLine("EL valor en yardas es: {0} yardas\nEl valor en pulgadas es: {1} pulgadas\nEl valor en cm es: {2} centimetros\nEL valor en metros es: {3} metros",yardas,pulgadas,centimetros,metros);





            Console.ReadKey();
        }
    }
}
