using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] juegos ={{200, 155, 300, 205, 210},
                           {180, 301, 255, 304, 199},
                           {210, 179, 152, 215, 299},
                           {304, 315, 152, 202, 156}};

            string [] nombres = {"Pacman","Dinosaurio de Google","Minecraft", "sonic"};



            int i, j,k=0,aux, anterior=0;
            int fila,promedios=0,promedio;

            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.Write("{0}\t",juegos[i, j]);
                }

                Console.WriteLine("{0}", nombres[k]);
                k++;
                Console.WriteLine();
            }

            for (i = 0; i < 4; i++) 
            {
                for (j = 0; j < 5; j++)
                {
                    aux = juegos[i, j];
                    if (aux > anterior)
                    {
                        anterior = aux;
                        //tambien puedes inicializarlo para hacer la comparacion con el primer valor de la matriz (por si usas numeros negativos y no puedes usar el 0)
                    }

                }
            }


            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (juegos[i, j] == anterior)
                    {
                        fila = i;
                        Console.WriteLine("El juego que tiene el puntaje mas alto es: {0}", nombres[fila]);
                    }
        
                }
            }




            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    promedios += juegos[i, j]; 
               
                }

                promedio = promedios / 5;
                Console.WriteLine("El promedio del juego {0} es: {1}",nombres[i],promedio);
            }







            Console.ReadKey();



        }
    }
}
