using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculo
{
  class Vehiculo
  {
    public void ArrancarMotor(string sonidoAlArrancar)
    {
      System.Console.WriteLine("Arranca el motor: " + sonidoAlArrancar);
    }
    public void PararMotor(string sonidoAlParar)
    {
      System.Console.WriteLine("Parando el motor: " + sonidoAlParar);
    }
    public virtual void Conducir()
    {
      System.Console.WriteLine("Este es el codigo para conducir");
    }
  }
}