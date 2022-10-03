// CLASE PARALLEL
// EL TRABAJO DEL PROGRAMA SE EJECUTEN DE MANERA PARALELA O CONCURRENTE
namespace CLASE_PARALLEL
{
  class Program
  {
    private static int acumulador = 0;

    static void Main(string[] args)
    {
      // for (int i = 0; i < 100; i++)
      // {
      //   RealizarTodasTareas(i);
      //   System.Console.WriteLine("El valor del acumulador es:  " +
      //   acumulador + " tarea realizada por el hilo " +
      //   Thread.CurrentThread.ManagedThreadId);
      // }

      Parallel.For(0, 100, dato =>
      {
        System.Console.WriteLine("El valor del acumulador es:  " +
        acumulador + " tarea realizada por el hilo " +
        Thread.CurrentThread.ManagedThreadId);

        if ((acumulador % 2) == 0)
        {
          acumulador += dato;
          Thread.Sleep(100);
        }
        else
        {
          acumulador -= dato;
          Thread.Sleep(100);
        }
      });

    }
    
    // METODO 2
    // static void RealizarTodasTareas(int dato)
    // {
    //   System.Console.WriteLine("El valor del acumulador es:  " +
    //   acumulador + " tarea realizada por el hilo " +
    //   Thread.CurrentThread.ManagedThreadId);

    //   if ((acumulador % 2) == 0)
    //   {
    //     acumulador += dato;
    //     Thread.Sleep(100);
    //   }
    //   else
    //   {
    //     acumulador -= dato;
    //     Thread.Sleep(100);
    //   }
    // }
  }
}