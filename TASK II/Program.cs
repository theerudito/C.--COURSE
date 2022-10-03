namespace TASK_II
{
  class Program
  {
    static void Main(string[] args)
    {

      Task tarea = Task.Run(() => Task1());

      // ejecutar luego que la tarea 1 se haya ejecutado o terminado
      Task tarea2 = tarea.ContinueWith(Task2);

      System.Console.ReadLine();
    }

    static void Task1()
    {
      for (int i = 0; i < 10; i++)
      {
        var miThread = Thread.CurrentThread.ManagedThreadId;
        Thread.Sleep(1000);
        System.Console.WriteLine("Soy la tarea 1 y mi id es: " + miThread);
      }
    }

    static void Task2(Task obj)
    {
      for (int i = 0; i < 10; i++)
      {
        var miThread = Thread.CurrentThread.ManagedThreadId;
        Thread.Sleep(1000);
        System.Console.WriteLine("Soy la tarea 2 y mi id es: " + miThread);
      }
    }
  }
}
