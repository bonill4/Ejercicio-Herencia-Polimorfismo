using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPractico
{
    internal class Coche : Vehiculo
    {

        public void Acelerar()
        {
            Console.WriteLine("Acelerando");
        }

        public void Frenar()
        {
            Console.WriteLine("Frenando");
        }

        public override void Conducir()
        {
            Console.WriteLine("Tomando las curvas con decision y destreza");
        }
    }
}
