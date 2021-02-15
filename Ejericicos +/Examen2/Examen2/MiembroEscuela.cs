using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    class MiembroEscuela
    {
        public string nombre;
        public string apellido;
        public int edad;

        public MiembroEscuela(string a, string b, int c)
        {
            nombre = a;
            apellido = b;
            edad = c;
        }
    }

    class Estudiante : MiembroEscuela
    {
        private string no_Boleta;
        private double promedio;
        private string carrera;

        public string No_Boleta
        {
            get
            {
                return no_Boleta;
            }

            set
            {
                no_Boleta = value;
            }
        }

        public double Promedio
        {
            get
            {
                return promedio;
            }

            set
            {
                promedio = value;
            }
        }

        public string Carrera
        {
            get
            {
                return carrera;
            }

            set
            {
                carrera = value;
            }
        }

        public Estudiante(string a, string b, int c, string d, double e, string f ) : base(a,b,c)
        {
            no_Boleta = d;
            promedio = e;
            carrera = f;
        }

        public void mostrar_info()
        {
            Console.WriteLine("{0} {1} {2}", nombre, apellido, no_Boleta);
        }

        ~Estudiante()
        {
            Console.WriteLine("Cerrando...");
        }
    }
}
