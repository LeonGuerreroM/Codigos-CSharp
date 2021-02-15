using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Radio
    {
        private double frecuencia;
        private int volumen;

        public Radio()
        {
            frecuencia = 99.1;
            volumen = 15;
        }

        /*public Radio(double f, int v)
        {


        }*/

        ~Radio()
        {
            Console.WriteLine("Apagando...");
        }

        public void aumentarFrecuencia(double x)
        {
            frecuencia += x;
            mostrarDatos();
        }

        public void disminuirFrecuencia(double x)
        {
            frecuencia -= x;
            mostrarDatos();
        }

        public void aumentarVolumen(int x)
        {
            volumen += x;
            mostrarDatos();
        }

        public void disminuirVolumen(int x)
        {
            volumen -= x;
            mostrarDatos();
            /*Console.WriteLine("Frecuencia Actual: {0}", frecuencia);
            Console.WriteLine("Volumen Actual: {0}", volumen);*/
        }

        public void mostrarDatos() //para mostrar datos privados en el main, sin que éstos dejen de ser privados
        {
            Console.WriteLine("Frecuencia Actual: {0}", frecuencia);
            Console.WriteLine("Volumen Actual: {0}", volumen);
        } 

    }
}
