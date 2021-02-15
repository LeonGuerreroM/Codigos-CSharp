using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tablero =
            {
                {1,2,1,1,0,0},
                {1,0,1,1,0,1},
                {1,0,1,1,0,1},
                {1,0,0,0,0,1},
                {1,1,0,1,1,1}
            };
            //int[] lugarAct = { 0, 1 };
            int i, j, PosFilas = 0, PosColumnas = 1;
            char entrada;



            Console.WriteLine("Tablero de juego, usted es el numero 2");
            Console.WriteLine("Para ir hacia arriba presione la tecla A\nHacia abajo la tecla B\nHacia la derecha la tecla D\nHacia la izquierda la tecla I\nNo importa si usa mayusculas o minusculas");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    Console.Write("{0}\t", tablero[i, j]);
                }
                Console.WriteLine();
            }





            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    if (tablero[i, j] == 2)
                    {
                        PosFilas = i;
                        PosColumnas = j;
                    }
                }
            }


            do
            {


                Console.WriteLine("Juegue");
                entrada = char.ToUpper(char.Parse(Console.ReadLine()));
                Console.WriteLine("Tiraste {0}:", entrada);

                if (entrada == 'A')
                {
                    if (PosFilas == 0)
                    {
                        Console.WriteLine("No es posible subir mas\nSigues en el mismo lugar");
                    }
                    else if (tablero[(PosFilas - 1), PosColumnas] == 1)
                    {
                        Console.WriteLine("¡Oh! Has encontrado un obstaculo\nSigues en el mismo lugar");
                    }
                    else
                    {
                        tablero[(PosFilas - 1), PosColumnas] = 2;
                        tablero[(PosFilas), PosColumnas] = 0;

                        for (i = 0; i < 5; i++)
                        {
                            for (j = 0; j < 6; j++)
                            {
                                Console.Write("{0}\t", tablero[i, j]);
                            }
                            Console.WriteLine();
                        }

                    }
                }
                else if (entrada == 'B')
                {
                    if (PosFilas == 4)
                    {
                        Console.WriteLine("No es posible bajar mas\nSigues en el mismo lugar");
                    }
                    else if (tablero[(PosFilas + 1), PosColumnas] == 1)
                    {
                        Console.WriteLine("¡Oh! Has encontrado un obstaculo\nSigues en el mismo lugar");
                    }
                    else
                    {
                        tablero[(PosFilas + 1), PosColumnas] = 2;
                        tablero[(PosFilas), PosColumnas] = 0;

                        for (i = 0; i < 5; i++)
                        {
                            for (j = 0; j < 6; j++)
                            {
                                Console.Write("{0}\t", tablero[i, j]);
                            }
                            Console.WriteLine();
                        }
                    }
                }
                else if (entrada == 'D')
                {
                    if (PosColumnas == 5)
                    {
                        Console.WriteLine("No es posible ir mas a la derecha\nSigues en el mismo lugar");
                    }
                    else if (tablero[PosFilas, (PosColumnas + 1)] == 1)
                    {
                        Console.WriteLine("¡Oh! Has encontrado un obstaculo\nSigues en el mismo lugar");
                    }
                    else
                    {
                        tablero[PosFilas, (PosColumnas + 1)] = 2;
                        tablero[(PosFilas), PosColumnas] = 0;

                        for (i = 0; i < 5; i++)
                        {
                            for (j = 0; j < 6; j++)
                            {
                                Console.Write("{0}\t", tablero[i, j]);
                            }
                            Console.WriteLine();
                        }
                    }
                }
                else if (entrada == 'I')
                {
                    if (PosColumnas == 0)
                    {
                        Console.WriteLine("No es posible ir mas a la izquierda\nSigues en el mismo lugar");
                    }
                    else if (tablero[(PosFilas), (PosColumnas - 1)] == 1)
                    {
                        Console.WriteLine("¡Oh! Has encontrado un obstaculo\nSigues en el mismo lugar");
                    }
                    else
                    {
                        tablero[PosFilas, (PosColumnas - 1)] = 2;
                        tablero[(PosFilas), PosColumnas] = 0;

                        for (i = 0; i < 5; i++)
                        {
                            for (j = 0; j < 6; j++)
                            {
                                Console.Write("{0}\t", tablero[i, j]);
                            }
                            Console.WriteLine();
                        }
                    }
                }

                for (i = 0; i < 5; i++)
                {
                    for (j = 0; j < 6; j++)
                    {
                        if (tablero[i, j] == 2)
                        {
                            PosFilas = i;
                            PosColumnas = j;
                        }
                    }
                }

            } while (tablero[0,5]!=2);
            Console.WriteLine("¡Felicidades, saliste!");








            Console.ReadKey();

        }
    }
}
