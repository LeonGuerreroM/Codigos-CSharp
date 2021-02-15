using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        public static void leer(int [,] bidi)
        {
            int i,j;
            Console.WriteLine("Llene la matriz");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("Matriz[{0},{1}]", i, j);
                    bidi[i, j] = int.Parse(Console.ReadLine());
                } 
            }
        }

        public static void escribir(int[,] bidi)
        {
            int i, j;
            Console.WriteLine("Matriz");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("{0}",bidi[i,j]);
                    
                }
                Console.WriteLine();
            }
        }





        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];

            leer(matriz);
            Console.WriteLine();
            escribir(matriz);


            Console.ReadKey();

        }
    }
}
