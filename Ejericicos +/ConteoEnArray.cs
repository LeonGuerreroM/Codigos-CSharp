using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            Random obj = new Random();
            int i, j, acumulado = 0, impresion = 1, x=0;



            for(i=0; i<100; i++)
            {
                array[i] = obj.Next(1, 11);
            }


            for (i = 0; i < 100; i++)
            {
                    if (impresion < 11)
                    {
                        Console.Write("{0}\t", array[i]);
                        impresion++;
                    }
                    else if(impresion>10)
                    {
                        impresion = 1;
                        Console.WriteLine("");
                        Console.Write("{0}\t", array[i]);
                        impresion++;
                    }
            }

            Console.WriteLine("");

            for (j = 1; j < 11; j++)
            {

                for (i = 0; i < 100; i++)
                {
                    if (array[i] == j)
                    {
                        acumulado += 1;
                    }
                }
                Console.WriteLine("El numero {0} se repite {1} veces", j, acumulado);
                acumulado = 0;
            }







            Console.ReadKey();




        }
    }
}
