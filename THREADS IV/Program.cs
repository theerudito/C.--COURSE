// Tareas Completadas
namespace Tareas_Completadas_Theread
{
  class Program
  {
    static void Main(string[] args)
    {

      // create a new task
      var TaskCompleted = new TaskCompletionSource<bool>();


      // crear el hilo
      var Hilo1 = new Thread(() =>
      {
        for (int i = 0; i < 5; i++)
        {
          System.Console.WriteLine($"Hilo 1: {i}");
          Thread.Sleep(1000);
        }
        TaskCompleted.SetResult(true);
      });


      var Hilo2 = new Thread(() =>
      {
        for (int i = 0; i < 5; i++)
        {
          System.Console.WriteLine($"Hilo 2: {i}");
          Thread.Sleep(1000);
        }
      });


      // Ejecutar el hilo
      Hilo1.Start();
      
      var result = TaskCompleted.Task.Result;

      Hilo2.Start();


    }
  }
}
