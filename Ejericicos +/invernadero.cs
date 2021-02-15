using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            double hr,hrma,hrmi;
            int cultivo;

            Console.WriteLine("Seleccione el cultivo en turno");
            Console.WriteLine("1.-Tomate");
            Console.WriteLine("2.-Melon");
            Console.WriteLine("3.-Pepino");
            Console.WriteLine("4.-Calabacita");
            cultivo = int.Parse(Console.ReadLine());

            switch (cultivo)
            {
                case 1:
                    Console.WriteLine("Seleccionaste Tomate");
                    for (int i = 0; i <= 6; i++)
                    {
                        hrma = 60;
                        hrmi = 50;
                        Console.WriteLine("Los valores idoneos para el cultivio de tomate son de un HR entre 50% y 60%");
                        Console.WriteLine("Ingrese el valor actual del HR");
                        hr = double.Parse(Console.ReadLine());
                        if (hr < hrmi)
                        {
                            while (hr < hrmi)
                            {
                                Console.WriteLine("HR menor que el optimo\nRegando...");
                                hr += 4;
                                Thread.Sleep(3000);
                                Console.WriteLine("Riego detenido");

                            }
                        }
                        else if (hr > hrma)
                        {
                            while (hr > hrma)
                            {
                                Console.WriteLine("HR mayor que el optimo\nVentilas abiertas...");
                                hr -= 3;
                                Thread.Sleep(5000);
                                Console.WriteLine("Ventilas cerradas");
                            }
                        }

                        Thread.Sleep(10000);
                    }
                        break;

                case 2:
                    Console.WriteLine("Seleccionaste Melon");
                    for (int i = 0; i <= 6; i++)
                    {
                        hrma = 70;
                        hrmi = 60;
                        Console.WriteLine("Los valores idoneos para el cultivio de melon son de un HR entre 60% y 70%");
                        Console.WriteLine("Ingrese el valor actual del HR");
                        hr = double.Parse(Console.ReadLine());
                        if (hr < hrmi)
                        {
                            while (hr < hrmi)
                            {
                                Console.WriteLine("HR menor que el optimo\nRegando...");
                                hr += 4;
                                Thread.Sleep(3000);
                                Console.WriteLine("Riego detenido");

                            }
                        }
                        else if (hr > hrma)
                        {
                            while (hr > hrma)
                            {
                                Console.WriteLine("HR mayor que el optimo\nVentilas abiertas...");
                                hr -= 3;
                                Thread.Sleep(5000);
                                Console.WriteLine("Ventilas cerradas");
                            }
                        }

                        Thread.Sleep(10000);
                    }
                    break;

                case 3:
                    Console.WriteLine("Seleccionaste Pepino");
                    for (int i = 0; i <= 6; i++)
                    {
                        hrma = 90;
                        hrmi = 70;
                        Console.WriteLine("Los valores idoneos para el cultivio de pepino son de un HR entre 70% y 90%");
                        Console.WriteLine("Ingrese el valor actual del HR");
                        hr = double.Parse(Console.ReadLine());
                        if (hr < hrmi)
                        {
                            while (hr < hrmi)
                            {
                                Console.WriteLine("HR menor que el optimo\nRegando...");
                                hr += 4;
                                Thread.Sleep(3000);
                                Console.WriteLine("Riego detenido");

                            }
                        }
                        else if (hr > hrma)
                        {
                            while (hr > hrma)
                            {
                                Console.WriteLine("HR mayor que el optimo\nVentilas abiertas...");
                                hr -= 3;
                                Thread.Sleep(5000);
                                Console.WriteLine("Ventilas cerradas");
                            }
                        }

                        Thread.Sleep(10000);
                    }
                    break;

                case 4:
                    Console.WriteLine("Seleccionaste Calabacita");
                    for (int i = 0; i <= 6; i++)
                    {
                        hrma = 80;
                        hrmi = 55;
                        Console.WriteLine("Los valores idoneos para el cultivio de calabacita son de un HR entre 55% y 80%");
                        Console.WriteLine("Ingrese el valor actual del HR");
                        hr = double.Parse(Console.ReadLine());
                        if (hr < hrmi)
                        {
                            while (hr < hrmi)
                            {
                                Console.WriteLine("HR menor que el optimo\nRegando...");
                                hr += 4;
                                Thread.Sleep(3000);
                                Console.WriteLine("Riego detenido");

                            }
                        }
                        else if (hr > hrma)
                        {
                            while (hr > hrma)
                            {
                                Console.WriteLine("HR mayor que el optimo\nVentilas abiertas...");
                                hr -= 3;
                                Thread.Sleep(5000);
                                Console.WriteLine("Ventilas cerradas");
                            }
                        }

                        Thread.Sleep(10000);
                    }
                    break;
                default:
                    Console.WriteLine("Selecciona un valor valido");
                    break;
            }

            Console.ReadKey();






        }
    }
}
