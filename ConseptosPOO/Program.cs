// NO ES RECOMENDADO IMPORTAR ASI 
using static System.Console;
using static System.Math;
// USAR VARIOS FICHEROS FUENTES
// OBJETO DE TIPO PUNTO 
// VARIABLES Y CONTANTE NORMALES => se crea una copia de la variable en cada objeto
// VARIABLE Y CONSTANTE STATIC => no se crea una copia de la variable se comparte entre todos los objetos
// la dueña de la variable es la clase y no el objeto

namespace ConseptosDePOO
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      //RealizarTarea();


      // Podemos Importar todos los metodos de una clase math para ahorrar codigo
      double raiz = Sqrt(9);
      double potencia = Pow(3, 4);
      WriteLine(raiz);
      Console.WriteLine(potencia);

      // CLASES ANONIMAS NO EXPECIFICAMOS EL TIPO DE DATO C# LO DETERMINA SOLO ASI
      var miVariable = new { Nombre = "Juan", Edad = 20 };
      WriteLine(miVariable);
      WriteLine(miVariable.Nombre);


      // CLASES ANONIMAS DETERMINA QUE SE TRATA DE LA MISMA CLASE PERO UNO ES STRING Y OTRO INT
      var miOtraVariable = new { Nombre = "Jorge", Edad = "35" };
      WriteLine(miOtraVariable);

    }
    static void RealizarTarea()
    {
      // COMENTARIO TODO: para informar de que falta por hacer
      // llama a la funcion de la clase Punto
      // Podemos pasarle parametros a la funcion o crearemos un constructor sin parametros
      Punto origen = new Punto();
      Punto destino = new Punto(50, 60);

      // Podemos llamar a la funcion de la clase Punto
      double distancia = origen.getMostrarDistancia(destino);
      Console.WriteLine("La distancia es: " + distancia);
      // Podemos llamar a la funcion static de la clase Punto
      int contador = Punto.getContadorObjetos();
      Console.WriteLine("El contador es: " + contador);

      // Podemos llamar a la funcion de la clase Punto suma
      int suma = origen.suma(5, 6);
      Console.WriteLine("La suma es: " + suma);

      //Punto.constantePrueba = 20;
    }
  }
}

// RESTRICION AL USAR CLASES ANONIMAS
// SOLO PUEDEN CONTENER CAMPOS PUBLICOS
// TODOS LOS CAMPOS DEBEN SER INICIALIZADOS
// LOS CAMPOS NO PUEDEN SER STACIC
// NO PUEDEN DEFINIR METODOS