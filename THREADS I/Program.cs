// threads se usa en programacion concurrente applicaciones multitareas
// que son los threads o hilos son procesos que se ejecutan en paralelo



using System.Threading;

namespace THEADS
{
  class Program
  {
    static void Main(string[] args)
    {
      Thread t1 = new Thread(MetodoSaludo);
      t1.Start();
      Console.WriteLine("Hello Perro desde thread o hilo 1");
      Thread.Sleep(500);
      Console.WriteLine("Hello Perro desde thread o hilo 1");
      Thread.Sleep(500);
      Console.WriteLine("Hello Perro desde thread o hilo 1");
      Thread.Sleep(500);
      Console.WriteLine("Hello Perro desde thread o hilo 1");

    }

    static void MetodoSaludo()
    {
      Console.WriteLine("Hello Perro desde thread o hilo 2");
      Thread.Sleep(500);
      Console.WriteLine("Hello Perro desde thread o hilo 2");
      Thread.Sleep(500);
      Console.WriteLine("Hello Perro desde thread o hilo 2");
      Thread.Sleep(500);
      Console.WriteLine("Hello Perro desde thread o hilo 2");
    }
  }
}

