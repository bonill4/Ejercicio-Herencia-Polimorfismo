using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPractico
{
    internal class Vehiculo
    {
        public void ArrancarMotor(String sonidoAlArrancar)
        {
            Console.WriteLine($"Arranca el motor: {sonidoAlArrancar}");
        }
        public void PararMotor(String sonidoAlParar)
        {
            Console.WriteLine($"Parando el motor: {sonidoAlParar}");
        }
        public virtual void Conducir()
        {
            Console.WriteLine("Este es el codigo generico para conducir");
        }
    }
}
