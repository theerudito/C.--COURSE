// TASK EN C# 
// LAS TASK DE COLOCAN ENCIMA DE LOS THREADS YA Q SON UN GRUPO DE POOL DE THREADS
// DEPENTIENDO LA MAQUINA LA TASK SE ENCARGA DE CREAR LOS THREADS NECESARIOS

namespace TASK
{
  class Program
  {
    static void Main(string[] args)
    {
      // creamos una tarea
      Task tarea = new Task(Task1);

      // iniciamos la tarea
      tarea.Start();

      // segunda tarea
      Task tarea2 = new Task(() =>
      {
        for (int i = 0; i < 100; i++)
        {
          var miThread = Thread.CurrentThread.ManagedThreadId;
          Thread.Sleep(1000);
          Console.WriteLine("Tarea correspondinte al hilo: " + miThread + " Ejecutandose desde el main");
        }
      });

      tarea2.Start();

      System.Console.ReadLine();
    }


    static void Task1()
    {
      for (int i = 0; i < 100; i++)
      {
        var miThread = Thread.CurrentThread.ManagedThreadId;
        Thread.Sleep(1000);
        System.Console.WriteLine("Soy la tarea 1 y mi id es: " + miThread);
      }
    }
  }
}


