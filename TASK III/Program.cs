// TASK CONSECUTIVAS Y METODOS
// WAIT, WAITALL, WAITANY
// WAIT => espera a que la tarea se ejecute y que este terminada
// WAITALL => espera a que todas las tareas se ejecuten
// WAITANY => espera a que cualquiera de las tareas se ejecute

namespace TASK_III
{
  class Program
  {
    static void Main(string[] args)
    {
      RealizarTodasTareas();

      Console.WriteLine();
    }

    static void RealizarTodasTareas()
    {
      var tarea1 = Task.Run(() => EjecutarTarea1());
      tarea1.Wait();
      var tarea2 = Task.Run(() => EjecutarTarea2());

      //Task.WaitAny(tarea1, tarea2);
      // ejemplo imaginemo un proceso en comun esta tarea
      var tarea3 = Task.Run(() => EjecutarTarea3());

      // espera a que todas las tareas se ejecuten
      Task.WaitAll(tarea1, tarea2);
    }

    static void EjecutarTarea1()
    {
      for (int i = 0; i < 5; i++)
      {
        var miThread = Thread.CurrentThread.ManagedThreadId;
        Thread.Sleep(1000);
        System.Console.WriteLine("Soy la tarea 1 y mi id es: " + miThread);
      }
    }
    static void EjecutarTarea2()
    {
      for (int i = 0; i < 5; i++)
      {
        var miThread = Thread.CurrentThread.ManagedThreadId;
        Thread.Sleep(500);
        System.Console.WriteLine("Soy la tarea 2 y mi id es: " + miThread);
      }
    }
    static void EjecutarTarea3()
    {
      for (int i = 0; i < 5; i++)
      {
        var miThread = Thread.CurrentThread.ManagedThreadId;
        Thread.Sleep(500);
        System.Console.WriteLine("Soy la tarea 3 y mi id es: " + miThread);
      }
    }
  }
}
