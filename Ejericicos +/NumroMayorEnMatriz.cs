using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {

            //float [,] cd = new float[2,4]; Declaracion de matriz en c#
            //float [,] cd

            int[,] matriz = new int[2, 4];
            int i, j,aux;
            int anterior = 0;
            Random obj = new Random();


            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    matriz[i,j]=obj.Next(10, 100);
                }
            }


            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.WriteLine("Posicion [{0},{1}] = {2}",i,j,matriz[i,j]);
                }
            }





            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    aux=matriz[i,j];
                    if (aux > anterior)
                    {
                        anterior = aux;
                    }
                    
                }
            }

            Console.WriteLine("El valor mas alto en la matriz es: {0}", anterior);

            Console.ReadKey();
        }
    }
}
