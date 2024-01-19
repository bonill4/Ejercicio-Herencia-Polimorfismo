using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPractico
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Avion();
            Console.WriteLine();
            Coche();
            Console.WriteLine();
            Console.WriteLine("Polimorfismo en accion");

            Avion miAvion = new Avion();

            Coche miCoche = new Coche();

            Vehiculo miVehiculo = miCoche;

            miVehiculo.Conducir();

            miVehiculo = miAvion;

            miVehiculo.Conducir();

        }

        static void Avion()
        {
            Console.WriteLine("Probando el avion");

            Avion miAvion = new Avion();

            miAvion.ArrancarMotor("tracatracatraca");

            miAvion.Despegar();

            miAvion.Conducir();

            miAvion.PararMotor("plooooooof");
        }
        static void Coche()
        {
            Console.WriteLine("Probando el coche");

            Coche miCoche = new Coche();

            miCoche.ArrancarMotor("grrrrrrrr grrrrrrrrr");

            miCoche.Acelerar();

            miCoche.Conducir();

            miCoche.Frenar();

            miCoche.PararMotor("bluuuuuuf");
        }
    }
}
