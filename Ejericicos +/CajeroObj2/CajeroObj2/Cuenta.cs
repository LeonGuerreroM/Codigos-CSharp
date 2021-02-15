using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroObj2
{
    class Cuenta
    {
        private int num_cuenta;
        private double saldo;
        private double x;

        public Cuenta()
        {
            num_cuenta = 00000000;
            saldo = 0;
        }

        public Cuenta(int x, double y)
        {
            num_cuenta = x;
            saldo = y;
        }

        ~Cuenta()
        {
            Console.WriteLine("Gracias por utilizar cajeros BanUpii");
        }
        
        public void saldos()
        {
            Console.WriteLine("Su saldo actual es: {0}", saldo);
        }
        public void Retiro()
        {
            Console.WriteLine("¿Cuanto desea retirar?");
            x = double.Parse(Console.ReadLine());
            saldo -= x;
            saldos();
        }

        public void comprarTiempoAire()
        {
            Console.WriteLine("¿Cuanto tiempo aire desea comprar?");
            x = double.Parse(Console.ReadLine());
            saldo -= x;
            saldos();
        }



    }
}
