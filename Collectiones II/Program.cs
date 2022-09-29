// collecoines II LinkeList lista enlazada
// diferencia entre list y linkedlist
// list son las lentas
// la linkedlist funcionan con nodos son lugares de memoria tiene enlaces

// metodos AddFist, AddLast, AddBefore, AddAfter, Remove, RemoveFirst, 
//RemoveLast, RemoveBefore, RemoveAfter, Find, FindLast, FindBefore, FindAfter, 
//Clear, Count, Contains, CopyTo, Reverse, Sort, GetEnumerator, ToString, Equals, GetHashCode, GetType

namespace COLLECIONES_LINK_LIST
{
  class Program
  {
    static void Main(string[] args)
    {

      LinkedList<int> lista = new LinkedList<int>();
      foreach (int item in new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })
      // agrega de forma el ultimo al primero
      {

        lista.AddFirst(item);
      }

      // elimiar elemento de la lista
      lista.Remove(5);

      // con nodo de la linkedlist
      LinkedListNode<int> nodo = lista.Find(7);

      //agrega de forma el primero al ultimo
      {

        lista.AddLast(item);
      }
      //  normal foreach
      foreach (int item in lista)
      {
        Console.WriteLine(item);
      }

      // foreach con linkedlistnode
      for (LinkedListNode<int> nodo = lista.First; nodo != null; nodo = nodo.Next)
      {
        Console.WriteLine(nodo.Value);

      }
    }
  }
}
