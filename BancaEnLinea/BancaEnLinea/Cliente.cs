using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancaEnLinea
{
    class Cliente
    {
        private string nombre;
        private string usuario;
        private string contraseña;
        private int num_cuentas;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return contraseña;
            }

            set
            {
                contraseña = value;
            }
        }

        public int Num_cuentas
        {
            get
            {
                return num_cuentas;
            }

            set
            {
                num_cuentas = value;
            }
        }

        public Cliente()
        {
            Nombre = "Upiita";
            Usuario = "Upii";
            Contraseña = "TMB";
            Num_cuentas = 2;
        }
        ~Cliente()
        {
            Console.WriteLine("Gracias por utilizar cajeros BanUpii");
        }


    }
}
