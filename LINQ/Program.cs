
// LINQ to SQL classes.
// ventajas
// uniformidad lengauje consulta 
// reducion de codigo
// codigo mas legible
// integracion en C#    
// la api de LINQ son formadas por 2 clases enumerable y queryable
namespace LINQ
{
  class Program
  {
    static void Main(string[] args)
    {
      // SIN LINQ
      int[] valoresArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
      System.Console.WriteLine("Numeros pares: ");

      List<int> numerosPares = new List<int>();
      List<int> numerosInpares = new List<int>();

      foreach (int valor in valoresArray)
      {
        if (valor % 2 == 0)
        {
          numerosPares.Add(valor);
        }
        else
        {
          numerosInpares.Add(valor);
        }
      }

      foreach (int i in numerosPares)
      {
        System.Console.WriteLine(i);
      }


      // CON LINQ
      int[] valoresArray2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
      IEnumerable<int> numerosPares2 = from valor in valoresArray2
                                       where valor % 2 == 0
                                       select valor;

      foreach (int i in numerosPares2)
      {
        System.Console.WriteLine("Par " + i);
      }


      // LINQ CON OBJETOS
      

    }
  }
}
