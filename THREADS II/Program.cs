// sincornizacion de threads
// se usa para que los threads no se ejecuten al mismo tiempo usamos join()

// bloqueo de threads
// bloque de codigo que se ejecuta en un thread y no se puede ejecutar en otro thread usamos lock()
using System.Threading;

namespace THEADS_SING_LOCK
{
  class Program
  {
    static void Main(string[] args)
    {
      Thread t = new Thread(Saludar);
      t.Start();
      // singronizar los hilos
      t.Join();

      Thread t2 = new Thread(Saludar);
      t2.Start();
      t2.Join();

      System.Console.WriteLine("Hola saludo de theads 1");
      Thread.Sleep(500);
      System.Console.WriteLine("Hola saludo de theads 1");
      Thread.Sleep(500);
      System.Console.WriteLine("Hola saludo de theads 1");
    }

    static void Saludar()
    {
      System.Console.WriteLine("Hola saludo de theads 2");
      Thread.Sleep(500);
      System.Console.WriteLine("Hola saludo de theads 2");
      Thread.Sleep(500);
      System.Console.WriteLine("Hola saludo de theads 2");
    }
  }
}