using System;
using System.Collections.Generic;
using System.Text;

namespace LlamadasAMetodos
{
  public class Punto
  {
    public Punto(int x, int y)
    {
      Console.WriteLine($"Cordenada x: {x}, Coordenada y: {y}");
    }
    public Punto()
    {
      Console.WriteLine("Constructor sin parametros por defecto");
    }

  }
}