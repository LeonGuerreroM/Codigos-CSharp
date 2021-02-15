using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancaEnLinea
{
        class Cuenta
        {
            private int num_cuenta;
            private double saldo;
            private double x;

        public int Num_cuenta
        {
            get
            {
                return num_cuenta;
            }

            set
            {
                num_cuenta = value;
            }
        }

        public double Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                saldo = value;
            }
        }

        public double X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public Cuenta()
            {
                Num_cuenta = 00000000;
                Saldo = 0;
            }

            public Cuenta(int x, double y)
            {
                Num_cuenta = x;
                Saldo = y;
            }

            public void saldos()
            {
                Console.WriteLine("Su saldo actual es: {0}", Saldo);
            }
            public void Retiro()
            {
                Console.WriteLine("¿Cuanto desea retirar?");
                X = double.Parse(Console.ReadLine());
                Saldo -= X;
                saldos();
            }

            public void comprarTiempoAire(double t)
            {
                Saldo -= t;
            }
        }
}
