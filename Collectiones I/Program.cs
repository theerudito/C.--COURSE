// COLLECTIONES => todas son genericos <T> no permite agregar en ejecucion los array no
// que son => son clases que pertenesen al namespace System.Collections.Generic
// estas clases permiten almacenar elementos
// son clases genericas como indica el namespace
// no tienen las limitaciones  de los arrays a cambio de mayor consumo de recursos
// ejemplo ordenar añadir eliminar buscar
// colecciones mas usadas => List, Queue, Stack, Dictionary y SortedList, HashSet
// List<T> => parecidos a los arrays pero con metodos para añadir eliminar buscar ordenar
// Queue<T> => las colas un elemento entra por un lado y sale por el otro
// Stack<T> => parecido a las queues primero en entrar ultimo en salir
// Dictionary<TKey, TValue> => almacenas elementos en estructura clave valor
// SortedList<TKey, TValue> => igual que el anterior pero ordenado
// HashSet<T> => almacena elementos sin orden

namespace COLLECIONES_LIST
{
  class Program
  {
    // EJEMPLO 1
    static void Main(string[] args)
    {
      // SYNTAXIS declarar una colección tipo list
      List<int> lista = new List<int>();
      // añadir elementos
      lista.Add(1);
      lista.Add(2);
      lista.Add(3);

      // for para recorrer la lista
      for (int i = 0; i < lista.Count; i++)
      {
        Console.WriteLine(lista[i]);
      }

      // EJEMPLO 2
      // almacenar elementos en una lista que tengo en un array
      int[] listaNumero = new int[] { 1, 2, 3, 4 };
      List<int> listaNumero2 = new List<int>();
      for (int i = 0; i < listaNumero.Length; i++)
      {
        listaNumero2.Add(listaNumero[i]);
        System.Console.WriteLine(listaNumero2[i]);
      }

      // EJEMPLO 3
      System.Console.WriteLine("Cuantos elementos quieres añadir a la lista");
      int numero = int.Parse(Console.ReadLine());
      List<int> listaNumero3 = new List<int>();
      for (int i = 0; i < numero; i++)
      {
        listaNumero3.Add(int.Parse(Console.ReadLine()));
      }
      System.Console.WriteLine("Elementos de la lista");
      for (int i = 0; i < listaNumero3.Count; i++)
      {
        System.Console.WriteLine(listaNumero3[i]);
      }

      // EJEMPLO 4
      List<int> listaNumero4 = new List<int>();
      System.Console.WriteLine("Introduce un numero (0 para salir)");
      int numero2 = 1;
      while (numero2 != 0)
      {
        numero2 = int.Parse(Console.ReadLine());
        if (numero2 != 0)
        {
          listaNumero4.Add(numero2);
        }
      }
    }
  }
}