using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidaPolimorfismo
{
    class Comida
    {
        public int tiempo_preparacion;
        public string ingredientes;

        public Comida(int x, string y)
        {
            tiempo_preparacion = x;
            ingredientes = y;
        }

        public virtual void dar_tiempo_preparacion()
        {
            Console.WriteLine("Tiempo: {0}",tiempo_preparacion);
        }

        public virtual void preparar()
        {
            Console.WriteLine("Preparando");
        }
    }

    class pescado : Comida 
    {
        public pescado(int a, string b) : base(a, b)
        {

        }

        public override void dar_tiempo_preparacion()
        {
            Console.WriteLine("El tiempo del pescado es: {0}", tiempo_preparacion);

        }

        public override void preparar()
        {
            Console.WriteLine("Meter al sarten");
        }
    }

    class Pizza : Comida
    {
        public Pizza(int x, string y) : base(x, y)
        {

        }

        public override void dar_tiempo_preparacion()
        {
            Console.WriteLine("Tiempo de preparacion: {0}", tiempo_preparacion);
        }

        public override void preparar()
        {
            Console.WriteLine("Meter al microondas");
        }
    }
}
