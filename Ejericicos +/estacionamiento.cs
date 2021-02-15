using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] estacionamiento = new int[10];
            int[] estacionamiento = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Random obj = new Random();
            int x;




            for (int i = 1; i <= estacionamiento.Length; i++)
            {
                x=obj.Next(0,10);
                if (estacionamiento[x] == 0)
                {
                    estacionamiento[x] = 1;
                    Console.WriteLine("El auto {0} se ha estacionado en el cajon {1}", i, x);
                }
                else
                {
                    for (int j = 0; j < estacionamiento.Length; j++)
                    {
                        if (estacionamiento[j] == 0)
                        {
                            estacionamiento[j] = 1;
                            Console.WriteLine("El auto {0} se ha estacionado en el cajon {1}", i, j);
                            break;
                        }
                        

                    }

                    
                }



            }

            Console.WriteLine("Estacionamiento lleno");



            Console.ReadKey();















        }
    }
}
