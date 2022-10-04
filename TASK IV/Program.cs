// CANCELACIONES DE TASKS MIENTRAS SE ESTAN EJECUTANDO
// CancelationTokenSource => señala a un objeto que puede cancelar una tarea
// CancelationToken =>  


namespace TASK_IV
{

  class Program
  {
    static int acumulador = 0;
    static void Main(string[] args)
    {
      // señala a un objeto que puede cancelar una tarea
      CancellationTokenSource miToken = new CancellationTokenSource();

      // caneclamos la tarea
      CancellationToken cancelatoken = miToken.Token;

      Task tarea = Task.Run(() => RealizarTarea(cancelatoken));

      for (int i = 0; i < 100; i++)
      {
        acumulador += 30;
        Thread.Sleep(1000);
        if (acumulador > 100)
        {
          miToken.Cancel();
          break;
        }
      }

      Thread.Sleep(1000);
      Console.WriteLine("El valor de acumulador es: " + acumulador);

      Console.ReadLine();
    }
    static void RealizarTarea(CancellationToken token)
    {
      for (int i = 0; i < 100; i++)
      {
        acumulador++;
        var miTheread = Thread.CurrentThread.ManagedThreadId;
        Thread.Sleep(1000);
        System.Console.WriteLine("Ejecutando la tarea en threads " + miTheread);
        System.Console.WriteLine(acumulador);

        if (token.IsCancellationRequested)
        {
          acumulador = 0;
          return;
        }
      }
    }

  }
}