using System;
using System.Collections.Generic;
using System.Text;

// CREAREMOS CAMPOS DE CLASES PERO DENTRO DEL AMBITO DE LA CLASE
namespace ConseptosDePOO
{

  // Las Variables
  public class Punto
  {
    private int x, y;
    // Podemos crear una variable static que se comparta entre todos los objetos
    private static int contadorObjetos = 0;
    public Punto(int x, int y)
    {
      this.x = x;
      this.y = y;
      // Vamos a incrementar el contador de objetos
      contadorObjetos++;
    }
    public Punto()
    {
      this.x = 0;
      this.y = 0;
      // Vamos a incrementar el contador de objetos
      contadorObjetos++;
    }

    // cuando recibimos un parametro de tipo objeto y parametro string 
    public double getMostrarDistancia(Punto otroPunto)
    {
      // CREAREMOS UNA VARIABLE DE TIPO ENTERO
      int xDif = this.x - otroPunto.x;
      int yDif = this.y - otroPunto.y;
      // Math.Pow(xDif, 2) + Math.Pow(yDif, 2)
      // xDif * xDif + yDif * yDif
      double distancia = Math.Sqrt(xDif * xDif + yDif * yDif);
      return distancia;
    }
    // Podemos crear una funcion static que se comparta entre todos los objetos
    public static int getContadorObjetos() => contadorObjetos;

    // Funcion suma
    public int suma(int a, int b) => a + b;

    //public const int constantePrueba = 10;

  }
}