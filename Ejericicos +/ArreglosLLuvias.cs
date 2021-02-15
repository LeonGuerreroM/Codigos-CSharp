using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] lluvias = new int[10, 12];
            string[] estados = { "Son", "Agcs", "Oax", "Col", "Chi", "SLP", "Dur", "Ver", "Yuc", "Tab" };
            string[] meses = {"     ", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Sept", "Oct", "Nov", "Dic" };
            Random obj = new Random();
            int i, j, acumulador = 0, comparado = 0, mesMas = 0, mesMayor = 0; ;

            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 12; j++)
                {
                    lluvias[i, j] = obj.Next(40, 120);
                }
            }

            for (i = 0; i < meses.Length; i++)
            {
                Console.Write("{0}\t", meses[i]);
                
            }

            Console.WriteLine();

            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}\t", estados[i]);
                for (j = 0; j < 12; j++)
                {
                    Console.Write("{0}\t", lluvias[i, j]);
                }
                Console.WriteLine();
            }

            for (i = 0; i < 10; i++)
            {
                
                for (j = 0; j < 12; j++)
                {
                    acumulador += lluvias[i, j];
                        
                }
                Console.WriteLine("Suma de lluvias de {0} = {1}", estados[i], acumulador);
                if (comparado < acumulador)
                {
                    comparado = acumulador;
                    mesMas = i;
                }
                acumulador = 0;
            }
            Console.WriteLine();
            Console.WriteLine("El estado con mas lluvias fue {0}",estados[mesMas]);

            for (i = 0; i < 10; i++)
            {

                for (j = 0; j < 12; j++)
                {
                    acumulador += lluvias[i, j];

                }
                
                if (comparado > acumulador)
                {
                    comparado = acumulador;
                    mesMas = i;
                }
                acumulador = 0;
            }
            
            Console.WriteLine("El estado con menos lluvias fue {0}", estados[mesMas]);
            mesMas = 0;
            for (i = 1; i <2; i++)
            {
                for (j = 0; j < 12; j++)
                {
                    //mesCurso = lluvias[i, j];
                    if (lluvias[i, j] > mesMayor)
                    {
                        mesMayor = lluvias[i, j];
                        mesMas = j;
                    }
                }
            }

            Console.WriteLine("El mes en el que se registraron mayores lluvias en Aguascalientes fue: {0}", meses[mesMas+1]);

            Console.ReadKey();




        }
    }
}
