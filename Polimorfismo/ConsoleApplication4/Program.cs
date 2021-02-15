using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApplication4;

namespace ConsoleApplication4
{
    class Program
    {
        public static void polimorfismo(figura obj)
        {
            obj.dibujar(); //se comporta como pilimorfismo porque esto recibe objeto de tipo figura y segun lo que recibe se comporta como circulo o triangulo. De nuevo, usa padres y luego los cambias a las formas de ssu hijos
        }

        static void Main(string[] args)
        {
            int i;
            figura[] arrayObj = new figura[2]; //array de clase padre
            arrayObj[0] = new circulo(); //cada indice toma forma de una de las clases hijas. Polimorfismo!!!!!!!!!!!
            arrayObj[1] = new triangulo();
            circulo c = new circulo();
            triangulo t = new triangulo();


            for (i = 0; i < 2; i++)
            {
                arrayObj[i].dibujar();
            }

            polimorfismo(c);
            polimorfismo(t);

            Console.ReadKey();
        }
    }
}
