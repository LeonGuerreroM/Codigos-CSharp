using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
           // int[] array = new int[5]; Declaracion de arreglos en C#
           // int[] array = {10,20,30,40}; si le dices que trae, ya no usas el new

            /*string array;
            int i;
            int [] numeros = {10, 20, 30, 40, 50, 60};

            int[] n = { 3, 4, 5 };

            char[] c = {'L', 'u', 'i', 's' };

            int[] precios = new int [3];

            precios[0] = 10;
            precios[1] = 20;
            precios[2] = 30;


            
            Console.WriteLine("Por favor indique el arreglo que quiere visualizar (numeros, n, c)");
            array = Console.ReadLine();

            if (array.Equals("numeros"))
            {
                Console.WriteLine("Indique el indice del dato que quiere ver(0-5)");
                i = int.Parse(Console.ReadLine());
                Console.WriteLine("numeros{0}={1}",i, numeros[i]);

            }else if(array.Equals("n"))
            {
                Console.WriteLine("Indique el indice del dato que quiere ver(0-2)");
                i = int.Parse(Console.ReadLine());
                Console.WriteLine("n{0}={1}",i, n[i]);
            }
            else if (array.Equals("c"))
            {
                Console.WriteLine("Indique el indice del dato que quiere ver(0-2)");
                i = int.Parse(Console.ReadLine());
                Console.WriteLine("c{0}={1}", i, c[i]);

            }*/

            int[] cuenta = new int[10];
            int total = 0;


            for (int i = 0; i < cuenta.Length; i++)
            {
                Console.WriteLine("Intruduzca un numero");
                cuenta[i]=int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Listado de numeros");


            //foreach (tipo de dato/ variable donde se guarda el contenido de la posicion que se este indicando/ in/ nombre) LA VENTAJA ES QUE YA NO PONGO EL TAMAÑO





            for (int i = 0; i < cuenta.Length; i++)
            {
                Console.WriteLine("cuentas{0} = {1}",i,cuenta[i]);
                total += cuenta[i];
            }


            Console.WriteLine("La suma de los numeros es {0}", total);









            Console.ReadKey();

        }
    }
}
