using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidaPolimorfismo
{
    class Program
    {
        public static void variasFormas(Comida obj)
        {
            obj.dar_tiempo_preparacion();
            obj.preparar();
        }

        static void Main(string[] args)
        {
            Comida[] platillo = new Comida[2];
            pescado salmon = new pescado(50, "Verduras, especias");
            Pizza europea = new Pizza(10, "carne, queso, pan, verduras");
            platillo[0] = new pescado(60, "Verduras, especias");
            platillo[1]=new Pizza(20, "carne, queso, pan, verduras");
            int i;

            for (i = 0; i < 2; i++)
            {
                platillo[i].dar_tiempo_preparacion();
                platillo[i].preparar();
            }

            variasFormas(salmon);
            variasFormas(europea);

            Console.ReadKey();

        }
    }
}
