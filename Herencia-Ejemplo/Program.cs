using System;
using System.Collections.Generic;
using System.Text;
namespace Vehiculo
{
  class Program
  {
    static void Main(string[] args)
    {

      System.Console.WriteLine("Provando El Avion");
      Avion miAvion = new Avion();
      miAvion.ArrancarMotor("tratra");
      miAvion.Despegar();
      miAvion.Conducir();
      miAvion.Aterrizar();
      miAvion.PararMotor("trutru");

      System.Console.WriteLine();

      Coche miCoche = new Coche();
      miCoche.ArrancarMotor("rannn");
      miCoche.Accelarar();
      miCoche.Conducir();
      miCoche.Frenar();
      miCoche.PararMotor("unnn");

      System.Console.WriteLine();
      System.Console.WriteLine("Pilomosfirmo en accion");
      Vehiculo miVehiculo = miCoche;
      miVehiculo.Conducir();
      miVehiculo = miAvion;
      miVehiculo.Conducir();


    }
  }

}
