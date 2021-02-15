using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace craps
{
    class Program
    {
        static void Main(string[] args)
        {
            int dado1, dado2, res, primerT;
            Random obj = new Random();
            dado1 = obj.Next(1, 7);
            dado2 = obj.Next(1, 7);

            primerT=dado1+dado2;

            res=primerT;

            if ((primerT == 7) || (primerT == 11))
            {
                Console.WriteLine("Dado 1 = {0}",dado1);
                Console.WriteLine("Dado 2 = {0}", dado2);
                Console.WriteLine("Suma = {0}", primerT);
                Console.WriteLine("Felicidades. ¡Ganaste!");
            }
            else if ((primerT == 2) || (primerT== 2) || (primerT== 12))
            {
                Console.WriteLine("Dado 1 = {0}", dado1);
                Console.WriteLine("Dado 2 = {0}", dado2);
                Console.WriteLine("Suma = {0}", primerT);
                Console.WriteLine("Perdiste, juego terminado");
            }
            else
            {
                Console.WriteLine("No has sacado ninguno, tu punto es: {0}", res);
                while(primerT != 7){
                    dado1 = obj.Next(1, 7);
                    dado2 = obj.Next(1, 7);
                    primerT = dado1+dado2;

                    if (primerT != 7)
                    {
                        Console.WriteLine("Dado 1 = {0}", dado1);
                        Console.WriteLine("Dado 2 = {0}", dado2);
                        Console.WriteLine("Suma = {0}", primerT);
                    }

                    if (primerT == res)
                    {
                        Console.WriteLine("Dado 1 = {0}", dado1);
                        Console.WriteLine("Dado 2 = {0}", dado2);
                        Console.WriteLine("Suma = {0}", primerT);
                        Console.WriteLine("Felicidades. ¡Ganaste!");
                        break;
                    }


                }
                Console.WriteLine("Dado 1 = {0}", dado1);
                Console.WriteLine("Dado 2 = {0}", dado2);
                Console.WriteLine("Suma = {0}", primerT);
                Console.WriteLine("Perdiste, juego terminado");

            }



            Console.ReadKey();



        }
    }
}
