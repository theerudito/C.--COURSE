// LAS COLLECIONES -- QUEUE
// first in first out
// enqueue -- add
// salen en el mismo orden en que entraron
// cuando son utilizados cuando queremos app que se ejecuten en orden
namespace COLLECIONES_QUEUE
{
  class Program
  {
    static void Main(string[] args)
    {
      Queue<int> numeros = new Queue<int>();

      // rellenamos elementos a la cola
      //numeros.Enqueue(1);
      //numeros.Enqueue(2);

      // con foreach recorremos la cola
      System.Console.WriteLine("Recoriendo el queue");
      foreach (int numero in new int[5] { 2, 4, 6, 8, 10 })
      {
        numeros.Enqueue(numero);
      }

      // recorremos la cola


      foreach (int numero in numeros)
      {
        Console.WriteLine(numero);
      }

      System.Console.WriteLine("Eliminando elementos del queue");
      // eliminamos el primer elemento de la cola
      numeros.Dequeue();
      foreach (int numero in numeros)
      {
        Console.WriteLine(numero);
      }

    }
  }
}
