using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen2;

namespace Examen2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,i,j;
            char y;
            Estudiante[] grupo = new Estudiante[5];
            grupo[0] = new Estudiante("Juan", "Perez", 19,"2015123", 8.3, "Bionica");
            grupo[1] = new Estudiante("Vanessa", "Gomez", 18, "2015321",9.2, "Telematica");
            grupo[2] = new Estudiante("Itzel", "Teran", 21, "2015694", 7.7, "Mecatronica");
            grupo[3] = new Estudiante("Cesar", "Martinez", 17, "2015000", 8.5, "Bionica");
            grupo[4] = new Estudiante("Fernanda", "Gonzales", 19, "2015194", 9.8, "Telematica");

            Console.WriteLine("UPIITA\nCalle Laguna Ticoman...");
            do
            {
                Console.WriteLine("\nMenu:\n1.Mostrar lista de estudiantes\n2.Mostrar informacion de estudiantes");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Estudiantes:");
                        for (i = 0; i < 5; i++)
                        {
                            Console.Write("{0}.- ", i + 1);
                            grupo[i].mostrar_info();
                        }
                        break;
                    case 2:
                        Console.WriteLine("¿De cual estudiante desea conocer mas informacion?");
                        for (i = 0; i < 5; i++)
                        {
                            Console.Write("{0}.- ", i + 1);
                            grupo[i].mostrar_info();
                        }
                        j = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nombre: {0} {1}\nNumero de Boleta {2}\nEdad: {3}\nPromedio {4}\nCarrera: {5}", grupo[j - 1].nombre, grupo[j - 1].apellido, grupo[j - 1].No_Boleta, grupo[j - 1].edad, grupo[j - 1].Promedio, grupo[j - 1].Carrera);
                        break;
                    default:
                        Console.WriteLine("Valor no valido");
                        break;
                }
                Console.WriteLine("Si desea repetir el menu, presione s. En caso contrario, presione cualquier otra tecla");
                y = char.ToLower(char.Parse(Console.ReadLine()));
            } while (y == 's');






        }
    }
}
