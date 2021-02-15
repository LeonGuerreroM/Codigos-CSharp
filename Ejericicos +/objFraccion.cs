using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication28
{
    class racional
    {
        public double numerador;
        public double denominador;

        public racional(double a, double b)
        {
            numerador = a;
            denominador = b;
        }
        
        public void imprimir()
        {
            Console.WriteLine("Fraccion {0}/{1}", numerador, denominador);
        }

        public void convertir()
        {
            Console.WriteLine("Fraccion convertida: {0}",numerador / denominador);
        }

        public void invertir()
        {
            Console.WriteLine("Fraccion inversa {0}/{1}",denominador,numerador);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Ingrese el numerador");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el denominador");
            y = double.Parse(Console.ReadLine());
            racional obj = new racional(x, y);
            obj.imprimir();
            obj.convertir();
            obj.invertir();


            Console.ReadKey();
        }
    }
}
