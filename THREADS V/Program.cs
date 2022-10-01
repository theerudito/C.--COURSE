// pool de threads
// utilidad de la clase Thread
// ejemplo en bases de datos con threads cuando tenemos 10 o 100 tareas

namespace POOL_THREADS
{
  class Program
  {
    static void Main(string[] args)
    {

      for (int i = 0; i < 100; i++)
      {
        ThreadPool.QueueUserWorkItem(EjecutarTarea, i);
      }
      System.Console.ReadLine();

    }

    static void EjecutarTarea(Object obj)
    {
      int nTarea = (int)obj;
      // tarea
      System.Console.WriteLine($"Thread n° {Thread.CurrentThread.ManagedThreadId} ha comenzado la tarea tarea n° {nTarea}");
      Thread.Sleep(1000);
      System.Console.WriteLine($"Thread n° {Thread.CurrentThread.ManagedThreadId} ha finalizado la tarea tarea n° {nTarea}");
    }
  }
}
