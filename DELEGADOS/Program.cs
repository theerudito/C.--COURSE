// DELEGADOS 
// funciones que delegan tareas en otras funciones
// muy similar a los punteros de C++
// un delegado es un referencia a un metodo
// ele jefe es el delegado y los empleados son los metodos
// para q sirven los delegados?
// para llamar eventos, reduce el codigo en escenario, codigo muy reutilizable
// syntax de un delegado es: delegate tipoDato nombreDelegado (parametros)
// todo depende al metodo que apunta ejemplo si es void el delegado debe ser void 
// el delegado debe tener la misma estructura que el metodo que apunta

namespace DELEGADOS
{
  class Program
  {
    // variables  podemos dejar sin parametros
    delegate void Objetodelegado(string mensaje); // delegado

    static void Main(string[] args)
    {
      // crear un delegado
      Objetodelegado ElDelegado = new Objetodelegado(MensajeBienvenida.SaludoBienvenida);
      // invocar el delegado
      ElDelegado("Hola que tal");

      // crear un delegado
      ElDelegado = new Objetodelegado(MensajeDespedida.SaludoDespedida);

      ElDelegado("Adios ");
    }
  }
  class MensajeBienvenida
  {
    public static void SaludoBienvenida(string msj)
    {
      System.Console.WriteLine("Mensaje de bienvenida ", msj);
    }
  }
  class MensajeDespedida
  {
    public static void SaludoDespedida(string msj)
    {
      System.Console.WriteLine("Hasta pronto " + msj);
    }
  }
}
