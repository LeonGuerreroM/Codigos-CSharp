using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class figura
    {
        public int x, y;
        public float ancho, alto;

        public virtual void dibujar() //los metodos virtuales solo se usan para esqueleto. Simpre se sobreescriben y no se usan
        {
            Console.WriteLine("Dibujando la figura");
        }
    }

    class circulo : figura
    {
        public override void dibujar() //override para que se entienda que lo sobreescribve y para que ejecute éste
        {
            base.dibujar(); //con el base manda a llamar al metodo de la base o clase padre, el virtual
            Console.WriteLine("o");
        }
    }
    class triangulo : figura
    {
        public override void dibujar() //override para que se entienda que lo sobreescribve y para que ejecute éste
        {
            base.dibujar();
            Console.WriteLine("^");
        }
    }

}
