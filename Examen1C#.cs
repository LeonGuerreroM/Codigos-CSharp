using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {

        public static void busqueda(int [] v1, int[] v2)
        {
            int i,j;
            int x,contador=0;
            int[] atinados = new int[6];


            for (i = 0; i < v1.Length; i++)
            {
                x = v1[i];
                for (j = 0; j < v2.Length; j++)
                {
                    if (x == v2[j])
                    {
                        atinados[i] = x;
                        contador++;
                    }


                }
            }

            Console.WriteLine("Le atinaste a {0} numeros", contador);
            for (i = 0; i < atinados.Length; i++)
            {
                if(atinados[i] != 0){
                Console.Write("{0} ", atinados[i]);
                }
            }

            if (contador == 6)
            {
                Console.WriteLine("¡Gano la bolsa acumulada de 100 millones de pesos!");
            }





        }






        static void Main(string[] args)
        {
            int[] seleccion = new int[6];
            int[] sorteo = new int[6];
            
            Random obj = new Random();
            int i,guardado,comparador=0,j;

            for (i = 0; i < sorteo.Length; i++)
            {
                guardado = obj.Next(1, 57);
                if (comparador != guardado)
                {
                    sorteo[i] = guardado;
                    comparador = guardado;
                }
                else
                {
                    comparador = guardado;
                }
            }

            Console.WriteLine("El resultado del Melate es:");
            for (i = 0; i < sorteo.Length; i++)
            {

                Console.Write("{0} ", sorteo[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Escriba los numeros que escogio en el Melate ");
            for (i = 0; i < seleccion.Length; i++)
            {
                Console.WriteLine("Numero {0}:", i + 1);
                seleccion[i] = int.Parse(Console.ReadLine());
            }


            





            busqueda(seleccion, sorteo);

            

            Console.WriteLine("El resultado del Melate es:");
            for (i = 0; i < sorteo.Length; i++)
            {
                
                    Console.Write("{0} ", sorteo[i]);
            }



            Console.ReadKey();


        }
    }
}
