using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculo
{
  class Avion : Vehiculo
  {
    public void Despegar()
    {
      System.Console.WriteLine("Despegando");
    }
    public void Aterrizar()
    {
      System.Console.WriteLine("Aterrizando");
    }
    public override void Conducir()
    {
      //base.Conducir();
      System.Console.WriteLine("Este es el codigo para conducir un avion");
    }
  }
}