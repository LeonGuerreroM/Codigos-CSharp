using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[11];
            Random obj = new Random();
            int x;


            for(int i=0; i<array.Length; i++)
            {
                array[i] = obj.Next(0, 10);
                Console.WriteLine("array en la posicion {0} es {1}",i, array[i]);
            }

           

            Console.WriteLine("Indica el numero que quieres buscar (0-9)");
            x = int.Parse(Console.ReadLine());


            for (int i = 0; i < array.Length; i++)
            {
                if (x == array[i])
                {
                    Console.WriteLine("Se encontro el numero a buscar ({0}) en la posicion {1}", x, i);
                }
            }





            Console.ReadKey();



        }
    }
}
