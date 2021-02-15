using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int nota;
            Console.WriteLine("Introduce tu nota");
            nota = int.Parse(Console.ReadLine());

            if (nota >= 0 && nota <= 10)
            {

                switch (nota)
                {
                    case 10: Console.WriteLine("Felicidades, examen superado");
                        break;
                    case 9: Console.WriteLine("Notable");
                        break;
                    case 8: Console.WriteLine("Aprobado");
                        break;
                    default: Console.WriteLine("Estudia mas");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Introduce una nota valida");
            }*/

            //cuando evaluas chars, ponlos entre comillas simples
            do
            {
                char letra;
                int n;
                Console.WriteLine("Introduce una letra");
                try
                {
                    letra = char.Parse(Console.ReadLine());

                    if (letra >= 0 && letra >= 9)
                    {
                        Console.WriteLine("Introduce un valor valido");
                    }
                    else
                    {


                        switch (letra)
                        {
                            case 'a': //como se repite codigo para variosa casos, los puedes apilar asi
                            case 'e':
                            case 'i':
                            case 'o':
                            case 'u': Console.WriteLine("Vocal");
                                break;
                            default: Console.WriteLine("No es vocal");
                                break;
                        }

                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Introduce un valor valido");
                }

                Console.ReadKey();
                Console.WriteLine("SI quieres repetir el programa presiona 1, en caso contrario presiona cualquier otra letra");
                n = int.Parse(Console.ReadLine());
            } while (n == 1);
        }
    }
}
