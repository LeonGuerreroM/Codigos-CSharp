using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {

        public static double serie(double n)
        {
            double i,acumulador=0;
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    acumulador += -Math.Pow((i),i);
                    //Console.WriteLine("Acumulador {0} = {1}", i, acumulador);
                    
                }
                else
                {
                    acumulador += Math.Pow((i), i);
                    //Console.WriteLine("Acumulador {0} = {1}", i, acumulador);

                }
            }
            return acumulador;
        }
        

        static void Main(string[] args)
        {
            double n,r;


            Console.WriteLine("Calculadora de serie 1^(1)-2^(2)+3^(3)-...+/-N^(N)");
            Console.WriteLine("Ingrese n");
            n = double.Parse(Console.ReadLine());
            r = serie(n);
            Console.WriteLine("El resultado es: {0}", r);
            

            Console.ReadKey();

        }
    }
}
