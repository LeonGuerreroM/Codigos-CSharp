using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        public static double hipotenusa(double cat1, double cat2)
        {
            return Math.Sqrt(Math.Pow(cat1, 2) + Math.Pow(cat2, 2));
        }



        static void Main(string[] args)
        {

            double lado1, lado2;
            double[] hips = new double[3];
            int i;

            Console.WriteLine("Calculadora de hipotenusas");
            Console.WriteLine("Ingrese las longitudes de los lados de los triangulos");

            for (i = 0; i < hips.Length; i++)
            {
                Console.WriteLine("Ingrese los datos del triangulo {0}",i+1);
                Console.WriteLine("Lado 1:");
                lado1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Lado 2:");
                lado2 = double.Parse(Console.ReadLine());
                hips[i] = hipotenusa(lado1, lado2);
            }

            for (i = 0; i < hips.Length; i++)
            {
                Console.WriteLine("Hipotenusa del triangulo {0} = {1}", i + 1,hips[i]);
            }



            Console.ReadKey();


        }
    }
}
