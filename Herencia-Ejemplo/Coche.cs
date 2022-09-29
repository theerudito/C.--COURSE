using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculo
{
  class Coche : Vehiculo
  {
    public void Accelarar()
    {
      System.Console.WriteLine("Acelerando");
    }
    public void Frenar()
    {
      System.Console.WriteLine("Frenando");
    }
    public override void Conducir()
    {
      //base.Conducir();
      System.Console.WriteLine("Este es el codigo para conducir un coche");
    }

  }

}